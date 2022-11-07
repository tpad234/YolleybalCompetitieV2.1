using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class Team
    {
        private readonly ITeamCollectionDal teamDal;
       public string Naam { get; }

        private List<Speler> _spelers = new List<Speler>();

        public List<Speler> Spelers
        {
            get { return _spelers; }
            set { _spelers = value; }
        }

        public Competitie Competitie { get; }
    
        public Team(ITeamCollectionDal iteamdal)
        {

            teamDal = iteamdal;

        }
        public Team(string naam)
        {

            Naam = naam;
        }
        public Team(string naam, Competitie competitie)
        {

            Naam = naam;
            Competitie = competitie;

        }
        public Team GetTeamByID(int ID)
        {
            return teamDal.GetTeamByID(ID);
        }
    }
}
