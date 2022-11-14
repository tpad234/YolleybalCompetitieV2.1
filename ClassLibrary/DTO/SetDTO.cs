using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class SetDTO
    {
        public int ID { get; }
        public WedstrijdDTO wedstrijd { get; }
        public int Aantalset { get; }
        public int Scoreteamthuis { get; private set; }
        public int Scoreteamuit { get; private set; }
        public TeamDTO Winaar { get; }

        public SetDTO(int ID, WedstrijdDTO wedstrijd, int aantalset, int Scoreteamthuis, int Scoreteamuit, TeamDTO Winaar)
        {
            this.ID = ID;
            this.wedstrijd = wedstrijd;
            this.Aantalset = aantalset;
            this.Scoreteamthuis = Scoreteamthuis;
            this.Scoreteamuit = Scoreteamuit;
            this.Winaar = Winaar;



        }
    }
}
