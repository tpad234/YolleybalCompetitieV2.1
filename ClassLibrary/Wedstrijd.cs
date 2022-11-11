using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Wedstrijd
    {
        readonly IWedstrijdColectionDal IwedstrijdColectionDal;
        public int ID { get; }
        public Team Teamthuis { get; }
        public Team Teamuit { get; }
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
        public Wedstrijd(IWedstrijdColectionDal wedstrijdColectionDal)
        {
            IwedstrijdColectionDal = wedstrijdColectionDal;
        }

        public Wedstrijd(WedstrijdDTO wedstrijdDTO)
        {

            ID = wedstrijdDTO.ID;
            Teamthuis = new Team(wedstrijdDTO.Teamthuis);
            Teamuit = new Team(wedstrijdDTO.Teamuit);
            Locatie = wedstrijdDTO.Locatie;
            competitie = new Competitie(wedstrijdDTO.competitie);

        }

    }
}
