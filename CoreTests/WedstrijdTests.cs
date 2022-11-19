using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;
using System.Collections.Generic;
using System.Text;
using DalMock;

namespace Core.Tests
{
    [TestClass()]
    public class WedstrijdTests
    {
        [TestMethod()]
        public void TryGetSetsByWedstrijdCheckByID()
        {
            ISetDal isetDal = new MockSetDal();
            Wedstrijd wedstrijd = new Wedstrijd(isetDal);

            List<Set> sets = wedstrijd.GetSetsByWedstrijd(1);


            Assert.IsTrue(sets[0].ID == 1 && sets[1].ID == 2 && sets[2].ID == 3 && sets[3].ID == 4);

        }

        [TestMethod()]
        public void TryGetSetsByWedstrijdCheckByNumber()
        {
            ISetDal isetDal = new MockSetDal();
            Wedstrijd wedstrijd = new Wedstrijd(isetDal);

            List<Set> sets = wedstrijd.GetSetsByWedstrijd(1);


            Assert.IsTrue(sets[0].Aantalset == 1 && sets[1].Aantalset == 2 && sets[2].Aantalset == 3 && sets[3].Aantalset == 4);

        }

    }
}