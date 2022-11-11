using Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class GeberuikerDTO
    {

        public string Naam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public Rol Rol { get; set; }

        public GeberuikerDTO(string Naam, String Email, string wachtwoord, Rol Rol)
        {

            this.Naam = Naam;
            this.Email = Email;
            this.Wachtwoord = wachtwoord;
            this.Rol = Rol;


        }
    }
}
