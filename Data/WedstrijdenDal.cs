using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class WedstrijdenDal : IWedstrijdColectionDal
    {
        public List<Wedstrijd> GetWedstrijden()
        {
            DataTable dt = DalAlgemeen.Select("SELECT Wedstrijd.TeamThuis, Wedstrijd.Teamuit, Wedstrijd.Locatie, Competitie.Naam  FROM Wedstrijd JOIN Competitie ON Wedstrijd.CompetitieID=Competitie.ID;");
            List<Wedstrijd> wedstrijden = new List<Wedstrijd>();
            foreach (DataRow dr in dt.Rows)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@teamuit", int.Parse(dr.ItemArray[1].ToString())),
                new SqlParameter("@teamthuis", int.Parse(dr.ItemArray[0].ToString()))

            };
                string Thuisteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.TeamThuis=Team.ID WHERE Wedstrijd.ID =@teamthuis;", parameters).ToString();
                string Uitteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.Teamuit=Team.ID WHERE Wedstrijd.ID =@teamuit;", parameters).ToString();
                Team uitteam = new Team(Uitteam);
                Team thuisteam = new Team(Thuisteam);
                Competitie competitie = new Competitie(dr.ItemArray[1].ToString());
                Wedstrijd wedstrijd = new Wedstrijd(thuisteam, uitteam, dr.ItemArray[2].ToString(), competitie);

                wedstrijden.Add(wedstrijd);
            }
            return wedstrijden;
        }

    }
}
