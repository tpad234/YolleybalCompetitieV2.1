using Core.DTO;
using System;

namespace MockDal
{
    public class MockCompetitieDal
    {
            public List<CompetitieDTO> GetCompetities()
            {
                DataTable dt = DalAlgemeen.Select("SELECT Naam FROM Competitie;");
                List<CompetitieDTO> Competities = new List<CompetitieDTO>();
                foreach (DataRow dr in dt.Rows)
                {
                    CompetitieDTO competitie = new CompetitieDTO(dr.ItemArray[0].ToString());
                    Competities.Add(competitie);
                }
                return Competities;
            }

    }
}
