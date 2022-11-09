using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class CompetitieDTO
    {
        public string Naam { get; }
        public List<Team> Teams { get; set; }
        public List<Wedstrijd> Wedstrijden { get; set; }

        public CompetitieDTO( string naam)
        {
            Naam = naam;
        }
    }
}
