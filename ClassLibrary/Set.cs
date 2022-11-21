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
        public Wedstrijd Wedstrijd { get; }
        public int Aantalset { get; }
        public int Scoreteamthuis { get; private set; }
        public int Scoreteamuit { get; private set; }
        public Team Winaar { get;  }

        private bool ScoreNotToHigh(int ScoreTeamThuis, int ScoreTeamUit)
        {
            if ((ScoreTeamThuis > 25 && ScoreTeamUit >= 25) ||
                 (ScoreTeamUit > 25 && ScoreTeamThuis >= 25))
            {
                return true;

            }
            else
            {

                return false;
            }
        }
        private bool ScoreToLow(int ScoreTeamThuis, int ScoreTeamUit)
        {
            if((ScoreTeamThuis == 25 && ScoreTeamUit < 25) ||
                (ScoreTeamUit == 25 && ScoreTeamThuis < 25))
            {
                return true;

            }
            else
            {

                return false;
            }
    }

        public int UpdateSet(int ScoreTeamThuis, int ScoreTeamUit, int WinnaarID, int ID)
        {
            if (ScoreNotToHigh(ScoreTeamThuis, ScoreTeamUit) || ScoreToLow(ScoreTeamThuis, ScoreTeamUit))
            {

                return isetDal.UpdateSet(ScoreTeamThuis, ScoreTeamUit, WinnaarID, ID);

            }
            else
            {
                return 0;
            }
            }
        public Set(ISetDal IsetDal)
        {
            isetDal = IsetDal;
        }
        public Set(SetDTO setDTO)
        {

            ID = setDTO.ID;
            Wedstrijd = new Wedstrijd(setDTO.Wedstrijd);
            Aantalset = setDTO.Aantalset;
            Scoreteamthuis = setDTO.Scoreteamthuis;
            Scoreteamuit = setDTO.Scoreteamuit;
            Winaar = new Team(setDTO.Winaar);

        }
    }


}
