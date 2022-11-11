using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class SetDTO
    {
        private int ID { get; }
        private WedstrijdDTO wedstrijd { get; }
        public int Aantalset { get; }
        public int Scoreteamthuis { get; private set; }
        public int Scoreteamuit { get; private set; }
        public TeamDTO Winaar { get; }

    }
}
