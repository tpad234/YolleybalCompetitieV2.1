using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DTO;
using DalMock;

namespace Core.Tests
{
    [TestClass()]
    public class CompetitieTests
    {
        [TestMethod()]
        public void CompetitieDTOToCompetitie()
        {
           
            CompetitieDTO competitieDTO = new CompetitieDTO("test1");
           Competitie competities = new Competitie(competitieDTO);

            Assert.IsTrue(competitieDTO.Naam == competities.Naam);
        }


        [TestMethod()]
        public void TryGetCompetitiesCheckBYCount()
        {
            ICompetitiecollectieDal ICompetitiecollectieDal = new MockCompetitieDal();
            Competitiecolection Competitiecolection = new Competitiecolection(ICompetitiecollectieDal);

            List<Competitie> Competities = Competitiecolection.GetCompetities();


            Assert.IsTrue(Competities.Count == 3);
        }

        [TestMethod()]
        public void TryGetCompetitiesCheckByName()
        {
            ICompetitiecollectieDal ICompetitiecollectieDal = new MockCompetitieDal();
            Competitiecolection Competitiecolection = new Competitiecolection(ICompetitiecollectieDal);

            List<Competitie> Competities = Competitiecolection.GetCompetities();


            Assert.IsTrue(Competities[0].Naam == "test1" && Competities[1].Naam == "test2" && Competities[2].Naam == "test3");
        }
    } 
}