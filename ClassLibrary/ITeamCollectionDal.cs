using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public interface ITeamCollectionDal
    {
        List<Team> GetTeams();
        Team GetTeamByID(int ID);
    }
}
