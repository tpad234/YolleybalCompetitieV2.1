using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Wedstrijd
    {
        public int ID { get; }
       public Team Teamthuis { get; }
       public  Team Teamuit { get; }
        public string Locatie { get; }

        public Competitie competitie { get; }
        private List<Set> _sets = new List<Set>();

        public List<Set> Sets
        {
            get { return _sets; }
            set { _sets = value; }
        }

        public Wedstrijd(int ID, Team Teamthuis, Team Teamuit, string Locatie, Competitie competitie)
        {
            this.ID = ID;
            this.Teamthuis = Teamthuis;
            this.Teamuit = Teamuit;
            this.Locatie = Locatie;
            this.competitie = competitie;

        }
        public Wedstrijd(int ID, Team Teamthuis, Team Teamuit, Competitie competitie)
        {
            this.ID = ID;
            this.Teamthuis = Teamthuis;
            this.Teamuit = Teamuit;
            this.competitie = competitie;

        }
    }
}
