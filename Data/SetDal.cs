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
        public List<SetDTO> GetSetByWedstrijd(int WedstrijdID)
        {
            List<SqlParameter> parametersmain = new List<SqlParameter>
            {
                new SqlParameter("@ID", WedstrijdID),

            };
            DataTable dt = DalAlgemeen.Select("SELECT Setinfo.AantalSet, Setinfo.ScoreTeamThuis, Setinfo.ScoreTeamUit, Team.Naam, Team.CompetitieID, SetInfo.WedstrijdID, Wedstrijd.TeamThuis, Wedstrijd.Teamuit, Wedstrijd.locatie, Setinfo.ID, Team.ID FROM SetInfo JOIN Team ON Team.ID=Setinfo.Winnaar JOIN Wedstrijd ON Wedstrijd.ID=Setinfo.WedstrijdID WHERE SetInfo.WedstrijdID = @ID;", parametersmain);
            List<SetDTO> Sets = new List<SetDTO>();
            foreach (DataRow dr in dt.Rows)
            {

                List<SqlParameter> parametersthuis = new List<SqlParameter>
            {
                new SqlParameter("@teamthuis", int.Parse(dr.ItemArray[6].ToString())),

            };
                string Thuisteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.TeamThuis=Team.ID WHERE Team.ID = @teamthuis;", parametersthuis).Rows[0].ItemArray[0].ToString();
                TeamDTO thuisteam = new TeamDTO(int.Parse(dr.ItemArray[6].ToString()), Thuisteam);

                List<SqlParameter> parametersuit = new List<SqlParameter>
            {
                new SqlParameter("@teamuit", int.Parse(dr.ItemArray[7].ToString())),

            };
                string Uitteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.Teamuit=Team.ID WHERE Team.ID = @teamuit;", parametersuit).Rows[0].ItemArray[0].ToString();
                TeamDTO uitteam = new TeamDTO(int.Parse(dr.ItemArray[7].ToString()), Uitteam);

                CompetitieDTO competitie = new CompetitieDTO(dr.ItemArray[3].ToString());
                WedstrijdDTO wedstrijd = new WedstrijdDTO(int.Parse(dr.ItemArray[5].ToString()), thuisteam, uitteam, dr.ItemArray[8].ToString(), competitie);
                TeamDTO Winaar = new TeamDTO(int.Parse(dr.ItemArray[10].ToString()), dr.ItemArray[3].ToString());
                SetDTO set = new SetDTO(int.Parse(dr.ItemArray[9].ToString()), wedstrijd, int.Parse(dr.ItemArray[0].ToString()), int.Parse(dr.ItemArray[1].ToString()), int.Parse(dr.ItemArray[2].ToString()), Winaar);
                Sets.Add(set);
            }
            return Sets;

        }
        public List<SetDTO> GetSetByID(int ID)
        {
            List<SqlParameter> parametersmain = new List<SqlParameter>
            {
                new SqlParameter("@ID", ID),

            };
            DataTable dt = DalAlgemeen.Select("SELECT Setinfo.AantalSet, Setinfo.ScoreTeamThuis, Setinfo.ScoreTeamUit, Team.Naam, Team.CompetitieID, SetInfo.WedstrijdID, Wedstrijd.TeamThuis, Wedstrijd.Teamuit, Wedstrijd.locatie, Setinfo.ID, Team.ID FROM SetInfo JOIN Team ON Team.ID=Setinfo.Winnaar JOIN Wedstrijd ON Wedstrijd.ID=Setinfo.WedstrijdID WHERE SetInfo.ID = @ID;", parametersmain);
            List<SetDTO> Sets = new List<SetDTO>();
            foreach (DataRow dr in dt.Rows)
            {

                List<SqlParameter> parametersthuis = new List<SqlParameter>
            {
                new SqlParameter("@teamthuis", int.Parse(dr.ItemArray[6].ToString())),

            };
                string Thuisteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.TeamThuis=Team.ID WHERE Team.ID = @teamthuis;", parametersthuis).Rows[0].ItemArray[0].ToString();
                TeamDTO thuisteam = new TeamDTO(int.Parse(dr.ItemArray[6].ToString()), Thuisteam);

                List<SqlParameter> parametersuit = new List<SqlParameter>
            {
                new SqlParameter("@teamuit", int.Parse(dr.ItemArray[7].ToString())),

            };
                string Uitteam = DalAlgemeen.Select("SELECT Team.Naam FROM Wedstrijd JOIN Team ON Wedstrijd.Teamuit=Team.ID WHERE Team.ID = @teamuit;", parametersuit).Rows[0].ItemArray[0].ToString();
                TeamDTO uitteam = new TeamDTO(int.Parse(dr.ItemArray[7].ToString()), Uitteam);

                CompetitieDTO competitie = new CompetitieDTO(dr.ItemArray[3].ToString());
                WedstrijdDTO wedstrijd = new WedstrijdDTO(int.Parse(dr.ItemArray[5].ToString()), thuisteam, uitteam, dr.ItemArray[8].ToString(), competitie);
                TeamDTO Winaar = new TeamDTO(int.Parse(dr.ItemArray[10].ToString()), dr.ItemArray[3].ToString());
                SetDTO set = new SetDTO(int.Parse(dr.ItemArray[9].ToString()), wedstrijd, int.Parse(dr.ItemArray[0].ToString()), int.Parse(dr.ItemArray[1].ToString()), int.Parse(dr.ItemArray[2].ToString()), Winaar);
                Sets.Add(set);
            }
            return Sets;

        }
        public int UpdateSet(int ScoreTeamThuis, int ScoreTeamUit, int Winnaar, int ID)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ScoreTeamThuis", ScoreTeamThuis),
                new SqlParameter("@ScoreTeamUit", ScoreTeamUit),
                new SqlParameter("@Winnaar", Winnaar),
                new SqlParameter("@ID", ID)
            };
            return DalAlgemeen.UpdateDeleteInsert("UPDATE SetInfo SET ScoreTeamThuis = @ScoreTeamThuis, ScoreTeamUit = @ScoreTeamUit, Winnaar= @Winnaar WHERE ID = @ID;", parameters);
        }
    }
}

