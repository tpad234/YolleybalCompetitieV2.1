using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public interface ISetDal
    {
        int UpdateSet(int ScoreTeamThuis, int ScoreTeamUit, int Winnaar, int ID);

   }
}
