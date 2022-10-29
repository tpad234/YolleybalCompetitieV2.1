using System;
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


        public Gebruiker(string Naam, String Email, int aantalset, string wachtwoord, Rol Rol)
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
        public DataTable Getuser(string username)
        {

            return IgebruikerDal.GetGebruikerByName(username);
        }
    }
}
