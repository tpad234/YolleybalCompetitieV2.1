using System;
using Core.Enum;
namespace Core
{
    public class Gebruiker
    {
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
    }
}
