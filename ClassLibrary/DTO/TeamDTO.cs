using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class TeamDTO
    {
        public string Naam { get; }

        public CompetitieDTO Competitie { get; }

        public List<SpelerDTO> Spelers { get; set; }
        public TeamDTO(string naam, CompetitieDTO competitie)
        {
            Naam = naam;
            Competitie = competitie;
        }
        public TeamDTO(string naam)
        {
            Naam = naam;
        }
    }
    
}
