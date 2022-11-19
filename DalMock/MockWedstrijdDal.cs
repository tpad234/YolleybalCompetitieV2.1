using Core;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DalMock
{
    public class MockWedstrijdDal : IWedstrijdColectionDal
    {
        public List<WedstrijdDTO> GetWedstrijden()
        {
            List<WedstrijdDTO> wedstrijden = new List<WedstrijdDTO>();
            TeamDTO thuisteam = new TeamDTO("test1");
            TeamDTO uitteam = new TeamDTO("test2");


                CompetitieDTO competitie = new CompetitieDTO("test");
                wedstrijden.Add(new WedstrijdDTO(1, thuisteam, uitteam, "eindhoven", competitie));
               wedstrijden.Add( new WedstrijdDTO(2, uitteam , thuisteam, "ergens anders", competitie));

            return wedstrijden;
        }
    }
}
