
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

        public List<DataRow> GetCompetities()
        {
            DataTable dt = DalAlgemeen.Select("SELECT * FROM Competitie;");
            List<DataRow> list = new List<DataRow>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr);
            }
            return list;
        }

    }
}