using Core;
using System;
using System.Collections.Generic;
using System.Data;
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

    }
}
