using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;
using System.Collections.Generic;
using System.Text;
using DalMock;
using Core.DTO;

namespace Core.Tests
{
    [TestClass()]
    public class WedstrijdColectionTests
    {
        //TODO
        [TestMethod()]
        public void TryWedstrijdDTOtoWedstrijdCheckByID()
        {
            TeamDTO thuisteam = new TeamDTO("test1");
            TeamDTO uitteam = new TeamDTO("test2");


            CompetitieDTO competitie = new CompetitieDTO("test");
            WedstrijdDTO wedstrijdDTO = new WedstrijdDTO(1, thuisteam, uitteam, "eindhoven", competitie);
            Wedstrijd wedstrijd = new Wedstrijd(wedstrijdDTO);

            Assert.IsTrue(wedstrijdDTO.ID == wedstrijd.ID);
        }
        [TestMethod()]
        public void TryWedstrijdDTOtoWedstrijdCheckByThuisteam()
        {
            TeamDTO thuisteam = new TeamDTO("test1");
            TeamDTO uitteam = new TeamDTO("test2");


            CompetitieDTO competitie = new CompetitieDTO("test");
            WedstrijdDTO wedstrijdDTO = new WedstrijdDTO(1, thuisteam, uitteam, "eindhoven", competitie);
            Wedstrijd wedstrijd = new Wedstrijd(wedstrijdDTO);

            Assert.IsTrue(wedstrijdDTO.Teamthuis.ID == wedstrijd.Teamthuis.ID);
        }
        [TestMethod()]
        public void TryWedstrijdDTOtoWedstrijdCheckByUitteam()
        {
            TeamDTO thuisteam = new TeamDTO("test1");
            TeamDTO uitteam = new TeamDTO("test2");


            CompetitieDTO competitie = new CompetitieDTO("test");
            WedstrijdDTO wedstrijdDTO = new WedstrijdDTO(1, thuisteam, uitteam, "eindhoven", competitie);
            Wedstrijd wedstrijd = new Wedstrijd(wedstrijdDTO);

            Assert.IsTrue(wedstrijdDTO.Teamuit.ID == wedstrijd.Teamuit.ID);
        }
        [TestMethod()]
        public void TryWedstrijdDTOtoWedstrijdCheckByLocatie()
        {
            TeamDTO thuisteam = new TeamDTO("test1");
            TeamDTO uitteam = new TeamDTO("test2");


            CompetitieDTO competitie = new CompetitieDTO("test");
            WedstrijdDTO wedstrijdDTO = new WedstrijdDTO(1, thuisteam, uitteam, "eindhoven", competitie);
            Wedstrijd wedstrijd = new Wedstrijd(wedstrijdDTO);

            Assert.IsTrue(wedstrijdDTO.Locatie == wedstrijd.Locatie);
        }
        [TestMethod()]
        public void TryWedstrijdDTOtoWedstrijdCheckByCompetitie()
        {
            TeamDTO thuisteam = new TeamDTO("test1");
            TeamDTO uitteam = new TeamDTO("test2");


            CompetitieDTO competitie = new CompetitieDTO("test");
            WedstrijdDTO wedstrijdDTO = new WedstrijdDTO(1, thuisteam, uitteam, "eindhoven", competitie);
            Wedstrijd wedstrijd = new Wedstrijd(wedstrijdDTO);

            Assert.IsTrue(wedstrijdDTO.Competitie.Naam == wedstrijd.Competitie.Naam);
        }
        [TestMethod()]
        public void TryGetWedstrijdenCheckByNumber()
        {
            IWedstrijdColectionDal iwedstrijdColectionDal = new MockWedstrijdDal();
            WedstrijdColection competitiecolection = new WedstrijdColection(iwedstrijdColectionDal);

            List<Wedstrijd> wedstrijden = competitiecolection.GetWedstrijden();


            Assert.IsTrue(wedstrijden.Count == 2);
        }

        [TestMethod()]
        public void TryGetWedstrijdenCheckById()
        {
            IWedstrijdColectionDal iwedstrijdColectionDal = new MockWedstrijdDal();
            WedstrijdColection competitiecolection = new WedstrijdColection(iwedstrijdColectionDal);

            List<Wedstrijd> wedstrijden = competitiecolection.GetWedstrijden();


            Assert.IsTrue(wedstrijden[0].ID == 1 && wedstrijden[1].ID == 2);
        }
        [TestMethod()]
        public void TryGetWedstrijdenCheckByThuisteam()
        {
            IWedstrijdColectionDal iwedstrijdColectionDal = new MockWedstrijdDal();
            WedstrijdColection competitiecolection = new WedstrijdColection(iwedstrijdColectionDal);

            List<Wedstrijd> wedstrijden = competitiecolection.GetWedstrijden();


            Assert.IsTrue(wedstrijden[0].Teamthuis.Naam == "test1" && wedstrijden[1].Teamthuis.Naam == "test2");
        }

        [TestMethod()]
        public void TryGetWedstrijdenCheckByUitteam()
        {
            IWedstrijdColectionDal iwedstrijdColectionDal = new MockWedstrijdDal();
            WedstrijdColection competitiecolection = new WedstrijdColection(iwedstrijdColectionDal);

            List<Wedstrijd> wedstrijden = competitiecolection.GetWedstrijden();


            Assert.IsTrue(wedstrijden[0].Teamuit.Naam == "test2" && wedstrijden[1].Teamuit.Naam == "test1");
        }
    }
}