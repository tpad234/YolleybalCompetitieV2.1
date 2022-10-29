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
        public DataTable GetGebruikerByName(string username)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", username)
            };
            return DalAlgemeen.Select("SELECT * FROM Team WHERE Naam =@username", parameters);
        }

    }
}
