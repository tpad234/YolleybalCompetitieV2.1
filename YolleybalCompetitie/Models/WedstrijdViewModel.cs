﻿using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace YolleybalCompetitie.Models
{
    public class WedstrijdViewModel
    {
        public List<DataRow> Wedstrijden { get; set; }


        public Core.Enum.Winaar Winaar { get; set; }

        public string score { get; set; }
    }
}