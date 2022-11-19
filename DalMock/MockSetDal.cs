using Core;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DalMock
{
   public class MockSetDal : ISetDal
    {
        public List<SetDTO> GetSetByWedstrijd(int wedstrijdID)
        {
            List<SetDTO> Sets = new List<SetDTO>();
            TeamDTO thuisteam = new TeamDTO( 1, "team1");
            TeamDTO uitteam = new TeamDTO(2, "team2");

                CompetitieDTO competitie = new CompetitieDTO("test");
                WedstrijdDTO wedstrijd = new WedstrijdDTO(wedstrijdID, thuisteam, uitteam, "teststad", competitie);
                TeamDTO Winaar = new TeamDTO(1, "team2");
                Sets.Add(new SetDTO(1, wedstrijd, 1, 15, 25, Winaar));
                Sets.Add(new SetDTO(2, wedstrijd, 2, 20, 25, Winaar));
                Sets.Add(new SetDTO(3, wedstrijd, 3, 20, 25, Winaar));
                Sets.Add(new SetDTO(4, wedstrijd, 4, 25, 27, Winaar));
            return Sets;

        }
        public int UpdateSet(int ScoreTeamThuis, int ScoreTeamUit, int Winnaar, int ID)
        {
            return 1;
        }
    }
}
