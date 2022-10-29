using System;
using System.Collections.Generic;
using System.Text;
using Core.Enum;
using System.Data;
using Data;

namespace Core
{
    public class Competitiecolection
    {
        readonly ICompetitiecollectieDal competitiecollectieDal;
        public DataTable Test()
        {
            
            return competitiecollectieDal.GetCompetities();
        }
        public Competitiecolection(ICompetitiecollectieDal IcompetitiecollectieDal)
        {
            competitiecollectieDal = IcompetitiecollectieDal;
        }
    }

}
