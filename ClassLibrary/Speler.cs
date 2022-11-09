using System;
using System.Collections.Generic;
using System.Text;
using Core.DTO;

namespace Core
{
   public  class Speler
    {
       public string Voornaam { get; private set; }
        
      public string Achternaam { get; }
       public int Leeftijd { get; }
       public string Woonplaats { get; }
        public Team Team { get; }


        public Speler(string voornaam, string achternaam, int leeftijd, string woonplaats, Team Team)
        {

            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Leeftijd = leeftijd;
            this.Woonplaats = woonplaats;
            this.Team = Team;


        }
        public Speler( SpelerDTO speler)
        {
            Voornaam = speler.Voornaam;
            Achternaam = speler.Achternaam;
            Leeftijd = speler.Leeftijd;
            Woonplaats = speler.Woonplaats;
            Team = new Team(speler.Team);
        }
    }

}
