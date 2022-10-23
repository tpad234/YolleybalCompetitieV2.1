using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Wedstrijd
    {
        Team Teamthuis { get; }
        Team Teamuit { get; }
        string Locatie { get; }

        private List<Team> _teams = new List<Team>();

        public List<Team> Teams
        {
            get { return _teams; }
            set { _teams = value; }
        }

        private List<Set> _sets = new List<Set>();

        public List<Set> Sets
        {
            get { return _sets; }
            set { _sets = value; }
        }

        public Wedstrijd(Team Teamthuis, Team Teamuit, string Locatie, List<Team> Teams, List<Set> Sets)
        {

            this.Teamthuis = Teamthuis;
            this.Teamuit = Teamuit;
            this.Locatie = Locatie;
            this.Teams = Teams;
            this.Sets = Sets;


        }
    }
}
