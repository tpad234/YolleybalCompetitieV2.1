using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;
using System.Collections.Generic;
using System.Text;
using DalMock;

namespace Core.Tests
{
    [TestClass()]
    public class SetTests
    {
        [TestMethod()]
        public void TryUpdateSetSucces()
        {
            ISetDal isetDal = new MockSetDal();
            Set set = new Set(isetDal);

            int rowsafected = set.UpdateSet(25, 15, 1, 1);


            Assert.IsTrue(rowsafected == 1);

        }

        [TestMethod()]
        public void TryUpdateSethighScore()
        {
            ISetDal isetDal = new MockSetDal();
            Set set = new Set(isetDal);

            int rowsafected = set.UpdateSet(28, 26, 1, 1);


            Assert.IsTrue(rowsafected == 1);

        }

        [TestMethod()]
        public void TryUpdateSetToLowScore()
        {
            ISetDal isetDal = new MockSetDal();
            Set set = new Set(isetDal);

            int rowsafected = set.UpdateSet(20, 15, 1, 1);


            Assert.IsTrue(rowsafected == 0);

        }

        [TestMethod()]
        public void TryUpdateSetTyeScore()
        {
            ISetDal isetDal = new MockSetDal();
            Set set = new Set(isetDal);

            int rowsafected = set.UpdateSet(25, 25, 1, 1);


            Assert.IsTrue(rowsafected == 0);

        }

        [TestMethod()]
        public void TryUpdateSetTyeScoreToLow()
        {
            ISetDal isetDal = new MockSetDal();
            Set set = new Set(isetDal);

            int rowsafected = set.UpdateSet(22, 22, 1, 1);


            Assert.IsTrue(rowsafected == 0);

        }

        [TestMethod()]
        public void TryUpdateSetTyeScoreTohigh()
        {
            ISetDal isetDal = new MockSetDal();
            Set set = new Set(isetDal);

            int rowsafected = set.UpdateSet(22, 22, 1, 1);


            Assert.IsTrue(rowsafected == 0);

        }
    }
}