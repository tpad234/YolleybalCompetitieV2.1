using Core;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class SetDal : ISetDal
    {
        public List<SetDTO> GetSetByWedstrijd(int ID)
        {
            List<SqlParameter> parametersmain = new List<SqlParameter>
            {
                new SqlParameter("@ID", ID),

            };
            DataTable dt = DalAlgemeen.Select("SELECT Setinfo.AantalSet, Setinfo.ScoreTeamThuis, Setinfo.ScoreTeamUit, Team.Naam, Team.CompetitieID, SetInfo.WedstrijdID, Wedstrijd.TeamThuis, Wedstrijd.Teamuit, Wedstrijd.locatie, Setinfo.ID FROM SetInfo JOIN Team ON Team.ID=Setinfo.Winnaar JOIN Wedstrijd ON Wedstrijd.ID=Setinfo.WedstrijdID WHERE SetInfo.WedstrijdID = @ID;", parametersmain);
            List<SetDTO> Sets = new List<SetDTO>();   
            foreach (DataRow dr in dt.Rows)
            {

                List<SqlParameter> parametersthuis = new List<SqlParameter>
            {
                new SqlParameter("@teamthuis", int.Parse(dr.ItemArray[6].ToString())),

            };
                string Thuisteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.TeamThuis=Team.ID WHERE Wedstrijd.ID = @teamthuis;", parametersthuis).Rows[0].ItemArray[0].ToString();
                TeamDTO thuisteam = new TeamDTO(Thuisteam);

                List<SqlParameter> parametersuit = new List<SqlParameter>
            {
                new SqlParameter("@teamuit", int.Parse(dr.ItemArray[7].ToString())),

            };
                string Uitteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.Teamuit=Team.ID WHERE Wedstrijd.ID = @teamuit;", parametersuit).Rows[0].ItemArray[0].ToString();
                TeamDTO uitteam = new TeamDTO(Uitteam);

                CompetitieDTO competitie = new CompetitieDTO(dr.ItemArray[3].ToString());
                WedstrijdDTO wedstrijd = new WedstrijdDTO(int.Parse(dr.ItemArray[5].ToString()),thuisteam, uitteam, dr.ItemArray[8].ToString() ,competitie);
                TeamDTO team = new TeamDTO(dr.ItemArray[3].ToString());
                SetDTO set = new SetDTO(int.Parse(dr.ItemArray[9].ToString()), wedstrijd, int.Parse(dr.ItemArray[0].ToString()), int.Parse(dr.ItemArray[1].ToString()), int.Parse(dr.ItemArray[2].ToString()), team );
                Sets.Add(set);
            }
            return Sets;

        }
    }
}
