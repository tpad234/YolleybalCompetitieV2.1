using Core;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class WedstrijdenDal : IWedstrijdColectionDal
    {
        public List<WedstrijdDTO> GetWedstrijden()
        {
            DataTable dt = DalAlgemeen.Select("SELECT Wedstrijd.ID, Wedstrijd.TeamThuis, Wedstrijd.Teamuit, Wedstrijd.Locatie, Competitie.Naam  FROM Wedstrijd JOIN Competitie ON Wedstrijd.CompetitieID=Competitie.ID;");
            List<WedstrijdDTO> wedstrijden = new List<WedstrijdDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                List<SqlParameter> parametersthuis = new List<SqlParameter>
            {
                new SqlParameter("@teamthuis", int.Parse(dr.ItemArray[1].ToString())),

            };
                string Thuisteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.TeamThuis=Team.ID WHERE Wedstrijd.ID = @teamthuis;", parametersthuis).Rows[0].ItemArray[0].ToString();
                TeamDTO thuisteam = new TeamDTO(Thuisteam);

                List<SqlParameter> parametersuit = new List<SqlParameter>
            {
                new SqlParameter("@teamuit", int.Parse(dr.ItemArray[1].ToString())),

            };
                string Uitteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.Teamuit=Team.ID WHERE Wedstrijd.ID = @teamuit;", parametersuit).Rows[0].ItemArray[0].ToString();
                TeamDTO uitteam = new TeamDTO(Uitteam);

                CompetitieDTO competitie = new CompetitieDTO(dr.ItemArray[4].ToString());
                WedstrijdDTO wedstrijd = new WedstrijdDTO(int.Parse(dr.ItemArray[0].ToString()), thuisteam, uitteam, dr.ItemArray[3].ToString(), competitie);

                wedstrijden.Add(wedstrijd);
            }
            return wedstrijden;
        }
    }
}
