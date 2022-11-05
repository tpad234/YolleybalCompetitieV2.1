using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class WedstrijdenDal : IWedstrijdColectionDal
    {
        public List<DataRow> GetWedstrijden()
        {
            DataTable dt = DalAlgemeen.Select("SELECT * FROM Wedstrijd;");
            List<DataRow> list = new List<DataRow>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr);
            }
            return list;
        }

    }
}
