﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            List<Competitie> competitiesbasic = new List<Competitie>();
            competitiesbasic.Add(new Competitie("test1"));
            List<Competitie> competities = new List<Competitie>();

            competities.Add(new Competitie(competitieDTO));


            Assert.IsTrue(competitiesbasic[0].Naam == competities[0].Naam);
        }


        [TestMethod()]
        public void TryGetCompetities()
        {
            ICompetitiecollectieDal ICompetitiecollectieDal = new MockCompetitieDal();
            Competitiecolection Competitiecolection = new Competitiecolection(ICompetitiecollectieDal);
            List<Competitie> Competities = Competitiecolection.GetCompetities();


            Assert.IsTrue(Competities.Count == 3);
        }
    }
}