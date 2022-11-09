using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class SpelerDTO
    {
        public string Voornaam { get; private set; }
        public string Achternaam { get; }
        public int Leeftijd { get; }
        public string Woonplaats { get; }
        public TeamDTO Team { get; }

        public SpelerDTO(string voornaam, string achternaam, int leeftijd, string woonplaats, TeamDTO Team)
        {

            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Leeftijd = leeftijd;
            this.Woonplaats = woonplaats;
            this.Team = Team;


        }
    }
}
