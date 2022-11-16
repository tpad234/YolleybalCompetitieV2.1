using Core;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DalMock
{
    public class MockCompetitieDal : ICompetitiecollectieDal
    {

            public List<CompetitieDTO> GetCompetities()
            {
                
                List<CompetitieDTO> Competities = new List<CompetitieDTO>();
            Competities.Add( new CompetitieDTO("test1"));
            Competities.Add(new CompetitieDTO("test2"));
            Competities.Add(new CompetitieDTO("test3"));


            return Competities;
            }
    }
}
