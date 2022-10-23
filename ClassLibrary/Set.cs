using System;
using System.Collections.Generic;
using System.Text;
using Core.Enum;
namespace Core
{
    class Set
    {
        private int ID { get; }
        private Wedstrijd WedstrijdID { get; }
        private int Aantalset { get; }
        public int Scoreteamthuis { get; private set; }
        public int Scoreteamuit { get; private set; }
        private Winaar Winaar { get;  }


        public Set(int ID, Wedstrijd WedstrijID, int aantalset, int Scoreteamthuis, int Scoreteamuit, Winaar Winaar)
        {

            this.WedstrijdID = WedstrijID;
            this.Aantalset = aantalset;
            this.Scoreteamthuis = Scoreteamthuis;
            this.Scoreteamuit = Scoreteamuit;
            this.Winaar = Winaar;


        }
    }


}
