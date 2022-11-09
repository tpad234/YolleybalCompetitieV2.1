
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Core;
using Core.DTO;

namespace Data
{
    public class CompetitieDal : ICompetitiecollectieDal
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