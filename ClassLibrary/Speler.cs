using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Speler
    {
        string Voornaam { get; }
        string Achternaam { get; }
        int Leeftijd { get; }
        string Woonplaats { get; }
        Team Team { get; }


        public Speler(string voornaam, string achternaam, int leeftijd, string woonplaats, Team Team)
        {

            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Leeftijd = leeftijd;
            this.Woonplaats = woonplaats;
            this.Team = Team;


        }
    }

}
