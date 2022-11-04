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
       private readonly ITeamCollectionDal teamDal;
        public DataTable GetTeams()
        {

            return teamDal.GetTeams();
        }
        public TeamCollection(ITeamCollectionDal iteamdal)
        {
            teamDal = iteamdal;
        }
    }
}
