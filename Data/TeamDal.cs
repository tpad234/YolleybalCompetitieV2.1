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
        public List<DataRow> GetTeams()
        {
            DataTable dt = DalAlgemeen.Select("SELECT * FROM Team;");

            List<DataRow> list = new List<DataRow>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr);
            }
            return list;
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

