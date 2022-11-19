using System;
using System.Collections.Generic;
using System.Data;
using Core.DTO;
using Core.Enum;
namespace Core
{
   public class Gebruiker
    {
        readonly IGebruikerDal IgebruikerDal;
        string Naam { get; }
        private string Email { get; }
        string Wachtwoord { get; }
        private Rol Rol { get; }


        public Gebruiker(string Naam, String Email, string wachtwoord, Rol Rol)
        {

            this.Naam = Naam;
            this.Email = Email;
            this.Wachtwoord = wachtwoord;
            this.Rol = Rol;


        }
        public Gebruiker(IGebruikerDal gebruikerDal)
        {
            IgebruikerDal = gebruikerDal;
        }
        public Gebruiker(GeberuikerDTO geberuikerDTO)
        {
            Naam = geberuikerDTO.Naam;
            Email = geberuikerDTO.Naam;
            Wachtwoord = geberuikerDTO.Wachtwoord;
            Rol = geberuikerDTO.Rol;
        }
        public Boolean CheckInlog(string username, string Wachtwoord )
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>();
            List<GeberuikerDTO> gebruikerDTO = IgebruikerDal.GetGebruikerByName(username);
            foreach (GeberuikerDTO gebruiker in gebruikerDTO)
            {
                gebruikers.Add(new Gebruiker(gebruiker));
            }


            if (gebruikers.Count == 1)
            {
                if (gebruikers[0].Naam.ToString() == username && gebruikers[0].Wachtwoord.ToString() == Wachtwoord)
                {
                    return true;

                }
                else
                {
                return false;

                }
            }
            else
            {
                return false;
            }


        }
 
    }
}
