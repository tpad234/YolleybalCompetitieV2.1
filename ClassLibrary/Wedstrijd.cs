using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Wedstrijd
    {
       public Team Teamthuis { get; }
       public  Team Teamuit { get; }
        public string Locatie { get; }

        private List<Team> _teams = new List<Team>();

        private List<Set> _sets = new List<Set>();

        public List<Set> Sets
        {
            get { return _sets; }
            set { _sets = value; }
        }

        public Wedstrijd(Team Teamthuis, Team Teamuit, string Locatie, List<Set> Sets)
        {

            this.Teamthuis = Teamthuis;
            this.Teamuit = Teamuit;
            this.Locatie = Locatie;
            this.Sets = Sets;


        }
    }
}
