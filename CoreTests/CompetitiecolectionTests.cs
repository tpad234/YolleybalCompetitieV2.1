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
            List<CompetitieDTO> competitieDTOs = new List<CompetitieDTO>();
            CompetitieDTO competitieDTO = new CompetitieDTO("test1");
            competitieDTOs.Add(competitieDTO);
            List<Competitie> competitiesbasic = new List<Competitie>
            {
                new Competitie("test1")
            };
            List<Competitie> competities = new List<Competitie>
            {
                new Competitie(competitieDTO)
            };


            Assert.IsTrue(competitiesbasic[0].Naam == competities[0].Naam);
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