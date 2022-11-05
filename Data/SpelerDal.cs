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
            List<DataRow> spelers = new List<DataRow>();
            foreach (DataRow dr in dt.Rows)
            {
               // Speler  speler = new Speler(dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), int.Parse(dr.ItemArray[3].ToString()), dr.ItemArray[4].ToString(), getteam dr.ItemArray[5].ToString())
                spelers.Add(dr);
            }
            return spelers;

        }
    }
}
