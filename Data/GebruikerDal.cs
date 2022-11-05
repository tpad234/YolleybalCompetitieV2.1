using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    class GebruikerDal : IGebruikerDal
    {
        public List<DataRow> GetGebruikerByName(string username)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", username)
            };
            DataTable dt = DalAlgemeen.Select("SELECT * FROM Gebruiker WHERE Naam =@username", parameters);

            List<DataRow> list = new List<DataRow>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr);
            }
            return list;
        }


    }
}
