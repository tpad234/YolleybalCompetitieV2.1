using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class CompetitieDTO
    {
        public string Naam { get; }
        public List<TeamDTO> Teams { get; set; }
        public List<WedstrijdDTO> Wedstrijden { get; set; }

        public CompetitieDTO( string naam)
        {
            Naam = naam;
        }
    }
}
