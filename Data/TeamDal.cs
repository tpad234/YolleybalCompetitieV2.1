using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class TeamDal : ITeamCollectionDal
    {
        public List<Team> GetTeams()
        {
            DataTable dt = DalAlgemeen.Select("SELECT Team.Naam, Competitie.Naam  FROM Team JOIN Competitie ON Team.CompetitieID=Competitie.ID;");

            List<Team> Teams = new List<Team>();
            foreach (DataRow dr in dt.Rows)
            {
                Competitie competitie = new Competitie(dr.ItemArray[1].ToString());
                Team team = new Team(dr.ItemArray[0].ToString(), competitie);

                Teams.Add(team);
            }
            return Teams;
        }
        public Team GetTeamByID(int ID)
        {
            Team team = null;
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", ID)
            };
            DataTable dt = DalAlgemeen.Select("SELECT Naam FROM Team WHERE ID =@ID", parameters);


            foreach (DataRow dr in dt.Rows)
            {
                team = new Team(dr.ItemArray[1].ToString());

            }
            return team;
        }
    }
}

