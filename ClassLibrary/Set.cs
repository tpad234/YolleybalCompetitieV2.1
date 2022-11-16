using System;
using System.Collections.Generic;
using System.Text;
using Core.DTO;
using Core.Enum;
namespace Core
{
   public class Set
    {
        readonly ISetDal isetDal;
        public int ID { get; }
        public Wedstrijd wedstrijd { get; }
        public int Aantalset { get; }
        public int Scoreteamthuis { get; private set; }
        public int Scoreteamuit { get; private set; }
        public Team Winaar { get;  }

        public int updateSet(int ScoreTeamThuis, int ScoreTeamUit, int Winnaar, int ID)
        {
            
            return isetDal.UpdateSet(ScoreTeamThuis, ScoreTeamUit, Winnaar, ID);
        }
        public Set(ISetDal IsetDal)
        {
            isetDal = IsetDal;
        }
        public Set(SetDTO setDTO)
        {

            ID = setDTO.ID;
            wedstrijd = new Wedstrijd(setDTO.wedstrijd);
            Aantalset = setDTO.Aantalset;
            Scoreteamthuis = setDTO.Scoreteamthuis;
            Scoreteamuit = setDTO.Scoreteamuit;
            Winaar = new Team(setDTO.Winaar);

        }
    }


}
