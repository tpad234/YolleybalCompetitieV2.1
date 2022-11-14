using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class TeamDTO
    {
        public int ID { get; }
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
        public TeamDTO(int ID, String naam)
        {

            this.ID = ID;
            Naam = naam;

        }
    }
    
}
