using System;
using System.Collections.Generic;
using System.Text;
using Core.Enum;
using System.Data;
using Data;

namespace Core
{
   public class TeamCollection
    {

        ITeamDal teamDal;
        public DataTable Test()
        {

            return teamDal.GetTeams();
        }
        public TeamCollection(ITeamDal iteamdal)
        {
            teamDal = iteamdal;
        }
    }
}
