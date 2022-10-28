
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

        public DataTable GetCompetities()
        {
            return DalAlgemeen.Select("SELECT * FROM Competitie;");
        }

    }
}