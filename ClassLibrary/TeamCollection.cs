using System;
using System.Collections.Generic;
using System.Text;
using Core.Enum;
using System.Data;
using Data;
using Core.DTO;

namespace Core
{
   public class TeamCollection
    {
       private readonly ITeamCollectionDal teamDal;
        public List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();
            List<TeamDTO> teamDTOs = teamDal.GetTeams();
            foreach (TeamDTO teamDTO in teamDTOs)
            {
                teams.Add(new Team(teamDTO));
            }

            return teams;
        }
        public Team GetTeamByID(int ID)
        {
            TeamDTO teamDTO = teamDal.GetTeamByID(ID);
            Team team = new Team(teamDTO);

            return team;
        }
        public TeamCollection(ITeamCollectionDal iteamdal)
        {
            teamDal = iteamdal;
        }
    }
}
