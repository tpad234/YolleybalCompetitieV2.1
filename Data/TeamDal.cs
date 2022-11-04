﻿using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
   public class TeamDal : ITeamCollectionDal
    {
        public DataTable GetTeams()
        {
            return DalAlgemeen.Select("SELECT * FROM Team;");
        }

    }
}