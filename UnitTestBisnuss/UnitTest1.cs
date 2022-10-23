using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using System.Data;

namespace UnitTestBisnuss
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void TestOfConectieWerkt()
        {
            DataTable dataTable = CompetitieDal.GetCompetities();

            Assert.IsTrue(dataTable.Rows.Count == 1);
        }
    }
}
