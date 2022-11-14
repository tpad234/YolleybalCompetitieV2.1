using System;
using System.Collections.Generic;
using System.Text;
using Core.DTO;
using Core.Enum;
namespace Core
{
   public class Set
    {
        public int ID { get; }
        public Wedstrijd wedstrijd { get; }
        public int Aantalset { get; }
        public int Scoreteamthuis { get; private set; }
        public int Scoreteamuit { get; private set; }
        public Team Winaar { get;  }


        public Set(int ID, Wedstrijd wedstrijd, int aantalset, int Scoreteamthuis, int Scoreteamuit, Team Winaar)
        {
            this.ID = ID;
            this.wedstrijd = wedstrijd;
            this.Aantalset = aantalset;
            this.Scoreteamthuis = Scoreteamthuis;
            this.Scoreteamuit = Scoreteamuit;
            this.Winaar = Winaar;
            


        }

        readonly ISetDal isetDal;
        public List<Set> GetSetsByWedstrijd(int ID)
        {
            List<Set> sets = new List<Set>();
            List<SetDTO> setDTOs = isetDal.GetSetByWedstrijd(ID);
            foreach (SetDTO setDTO in setDTOs)
            {
                sets.Add(new Set(setDTO));
            }
            return sets;
        }
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
