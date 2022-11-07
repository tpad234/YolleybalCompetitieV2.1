using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace YolleybalCompetitie.Models
{
    public class WedstrijdViewModel
    {
        public List<Wedstrijd> Wedstrijden { get; set; }


        public Team Winaar { get; set; }

        public string Score { get; set; }
    }
}
