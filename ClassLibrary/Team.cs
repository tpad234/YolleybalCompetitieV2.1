using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class Team
    {
        private readonly ITeamCollectionDal teamDal;
        string Naam { get; }

        private List<Speler> _spelers = new List<Speler>();

        public List<Speler> Spelers
        {
            get { return _spelers; }
            set { _spelers = value; }
        }

        public Team(ITeamCollectionDal iteamdal)
        {

            teamDal = iteamdal;

        }
        public Team(string naam, List<Speler> spelers)
        {

            Naam = naam;
            Spelers = spelers;

        }
        public string GetTeamByID(int ID)
        {
            return teamDal.GetTeamnameByID(ID);
        }
    }
}
