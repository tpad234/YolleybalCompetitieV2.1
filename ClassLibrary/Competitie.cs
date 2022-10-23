using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Competitie
    {
       public string Naam { get; }

        private List<Team> _teams = new List<Team>();

        public List<Team> Teams
        {
            get { return _teams; }
            set { _teams = value; }
        }

        private List<Wedstrijd> _wedstrijden = new List<Wedstrijd>();

        public List<Wedstrijd> Wedstrijden
        {
            get { return _wedstrijden; }
            set { _wedstrijden = value; }
        }
        public Competitie(string naam, List<Team> team, List<Wedstrijd> wedstijden)
        {

            Naam = naam;
            Teams = team;
            Wedstrijden = wedstijden;
            


        }
    }
}
