using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Core.DTO;

namespace Data
{
    public class TeamDal : ITeamCollectionDal
    {
        public List<TeamDTO> GetTeams()
        {
            DataTable dt = DalAlgemeen.Select("SELECT Team.Naam, Competitie.Naam  FROM Team JOIN Competitie ON Team.CompetitieID=Competitie.ID;");

            List<TeamDTO> Teams = new List<TeamDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                CompetitieDTO competitie = new CompetitieDTO(dr.ItemArray[1].ToString());
                TeamDTO team = new TeamDTO(dr.ItemArray[0].ToString(), competitie);

                Teams.Add(team);
            }
            return Teams;
        }
        public TeamDTO GetTeamByID(int ID)
        {
            TeamDTO team = null;
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ID", ID)
            };
            DataTable dt = DalAlgemeen.Select("SELECT  Team.Naam, Competitie.Naam FROM Team JOIN Competitie ON Team.CompetitieID=Competitie.ID WHERE ID =@ID", parameters);


            foreach (DataRow dr in dt.Rows)
            {
                CompetitieDTO competitie = new CompetitieDTO(dr.ItemArray[1].ToString());
                team = new TeamDTO(dr.ItemArray[0].ToString(), competitie);

            }
            return team;
        }
    }
}

