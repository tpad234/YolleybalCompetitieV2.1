using Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class Team
    {

        private readonly ITeamCollectionDal teamDal;
        public int ID { get; }
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
        public Team(int ID, string naam)
        {

            this.ID = ID;
            Naam = naam;

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
        public Team(TeamDTO teamDTO)
        {
            Naam = teamDTO.Naam;
            if (teamDTO.Competitie != null)
            {
                Competitie = new Competitie(teamDTO.Competitie);

            }
            if (teamDTO.ID != 0)
            {
                ID = teamDTO.ID;
            }
        }
    }
}
