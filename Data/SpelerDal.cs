using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class SpelerDal : ISpelerColectionDal
    {
        public List<DataRow> GetSpelers()
        {
            DataTable dt = DalAlgemeen.Select("SELECT * FROM Speler;");
            List<DataRow> list = new List<DataRow>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr);
            }
            return list;

        }
    }
}
