
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Core;

namespace Data
{
    public class CompetitieDal : ICompetitiecollectieDal
    {

        public List<Competitie> GetCompetities()
        {
            DataTable dt = DalAlgemeen.Select("SELECT Naam FROM Competitie;");
            List<Competitie> Competities = new List<Competitie>();
            foreach (DataRow dr in dt.Rows)
            {
                Competitie competitie = new Competitie(dr.ItemArray[0].ToString());
                Competities.Add(competitie);
            }
            return Competities;
        }

    }
}