using Core.DTO;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public interface ICompetitiecollectieDal
    {
        List<CompetitieDTO> GetCompetities();

    }
 
}
   
