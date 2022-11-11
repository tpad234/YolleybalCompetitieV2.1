using Core;
using Core.DTO;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
   public class GebruikerDal : IGebruikerDal
    {
        private Rol rol;
        public List<GeberuikerDTO> GetGebruikerByName(string username)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@username", username)
            };
            DataTable dt = DalAlgemeen.Select("SELECT Naam, Email, Wachtwoord, rol FROM Gebruiker WHERE Naam =@username", parameters);

            List<GeberuikerDTO> gebruikers = new List<GeberuikerDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                if (int.Parse(dr.ItemArray[3].ToString()) == 1)
                {
                     rol = Rol.gebruiker;

                }
                else
                {
                     rol = Rol.scheidsrechter;
                }
                GeberuikerDTO gebruiker = new GeberuikerDTO(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), rol);
                gebruikers.Add(gebruiker);
            }
            return gebruikers;
        }


    }
}
