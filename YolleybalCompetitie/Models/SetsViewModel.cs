using Core;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YolleybalCompetitie.Models
{
    public class SetsViewModel
    {
        public List<Set> Sets { get; set; }
        public int Scoreteamthuis { get; set; }
        public int Scoreteamuit { get; set; }
        public int Winaar { get; set; }
        public int ID { get; set; }
    }
}
