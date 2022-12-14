using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Wedstrijd
    {
        private readonly IWedstrijdColectionDal IwedstrijdColectionDal;
        readonly ISetDal isetDal;
        readonly ISetCollectionDal collectionDal;
        public int ID { get; }
        public Team Teamthuis { get; }
        public Team Teamuit { get; }
        public string Locatie { get; }

        public Competitie Competitie { get; }
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
            this.Competitie = competitie;

        }
        public Wedstrijd(int ID, Team Teamthuis, Team Teamuit, Competitie competitie)
        {
            this.ID = ID;
            this.Teamthuis = Teamthuis;
            this.Teamuit = Teamuit;
            this.Competitie = competitie;

        }
        public Wedstrijd(IWedstrijdColectionDal wedstrijdColectionDal)
        {
            IwedstrijdColectionDal = wedstrijdColectionDal;
        }

        public Wedstrijd(ISetDal setDal)
        {
            isetDal = setDal;
        }
        public Wedstrijd(ISetCollectionDal setDal)
        {
            collectionDal = setDal;
        }

        public Wedstrijd(WedstrijdDTO wedstrijdDTO)
        {

            ID = wedstrijdDTO.ID;
            Teamthuis = new Team(wedstrijdDTO.Teamthuis);
            Teamuit = new Team(wedstrijdDTO.Teamuit);
            Locatie = wedstrijdDTO.Locatie;
            Competitie = new Competitie(wedstrijdDTO.Competitie);

        }
        public List<Set> GetSetsByWedstrijd(int ID)
        {
            List<Set> sets = new List<Set>();
            List<SetDTO> setDTOs = collectionDal.GetSetByWedstrijd(ID);
            foreach (SetDTO setDTO in setDTOs)
            {
                sets.Add(new Set(setDTO));
            }
            return sets;
        }
        public List<Set> GetSetByID(int ID)
        {
            List<Set> sets = new List<Set>();
            List<SetDTO> setDTOs = collectionDal.GetSetByID(ID);
            foreach (SetDTO setDTO in setDTOs)
            {
                sets.Add(new Set(setDTO));
            }
            return sets;
        }
    }
}
