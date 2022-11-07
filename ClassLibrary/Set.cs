using System;
using System.Collections.Generic;
using System.Text;
using Core.Enum;
namespace Core
{
   public class Set
    {
        private int ID { get; }
        private Wedstrijd wedstrijd { get; }
        public int Aantalset { get; }
        public int Scoreteamthuis { get; private set; }
        public int Scoreteamuit { get; private set; }
        public Team Winaar { get;  }


        public Set(Wedstrijd wedstrijd, int aantalset, int Scoreteamthuis, int Scoreteamuit, Team Winaar)
        {

            this.wedstrijd = wedstrijd;
            this.Aantalset = aantalset;
            this.Scoreteamthuis = Scoreteamthuis;
            this.Scoreteamuit = Scoreteamuit;
            this.Winaar = Winaar;
            


        }

        readonly ISetDal isetDal;
        public List<Set> GetSetsByWedstrijd(int ID)
        {

            return isetDal.GetSetByWedstrijd(ID);
        }
        public Set(ISetDal IsetDal)
        {
            isetDal = IsetDal;
        }
    }


}
