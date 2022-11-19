using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;
using System.Collections.Generic;
using System.Text;
using DalMock;

namespace Core.Tests
{
    [TestClass()]
    public class WedstrijdColectionTests
    {
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