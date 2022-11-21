using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YolleybalCompetitie.Models
{
    public class SetViewModel
    {
        public Set Set { get; set; }
        public int Scoreteamthuis { get; set; }
        public int Scoreteamuit { get; set; }
        public int Winaar { get; set; }
        public int ID { get; set; }
        public int WedstrijdID { get; set; }

    }
}
