using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class WedstrijdDTO
    {
        public int ID { get; set; }
        public TeamDTO Teamthuis { get; set; }
        public TeamDTO Teamuit { get; set; }
        public string Locatie { get; set; }

        public CompetitieDTO competitie { get; set; }

        public List<Set> Sets { get; set; }


        public WedstrijdDTO(int ID, TeamDTO Teamthuis, TeamDTO Teamuit, string locatie,CompetitieDTO competitie)
        {
            this.ID = ID;
            this.Teamthuis = Teamthuis;
            this.Teamuit = Teamuit;
            this.Locatie = locatie;
            this.competitie = competitie;

        }

    }
}
