using System;
using System.Collections.Generic;
using System.Data;
using Core.Enum;
namespace Core
{
   public class Gebruiker
    {
        readonly IGebruikerDal IgebruikerDal;
        string Naam { get; }
        string Email { get; }
        string Wachtwoord { get; }
        Rol Rol { get; }


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
        public Boolean CheckInlog(string username, string Wachtwoord )
        {
          
            List<Gebruiker> gebruikers = IgebruikerDal.GetGebruikerByName(username);
            if (gebruikers.Count == 1)
            {
                if (gebruikers[0].Naam == username && gebruikers[0].Wachtwoord == Wachtwoord)
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
