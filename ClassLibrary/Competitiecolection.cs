using System;
using System.Collections.Generic;
using System.Text;
using Core.Enum;
using System.Data;
using Data;
using Core.DTO;

namespace Core
{
    public class Competitiecolection
    {
        readonly ICompetitiecollectieDal competitiecollectieDal;
        public List<Competitie> Test()
        {
            {
                List<Competitie> competities = new List<Competitie>();
                List<CompetitieDTO> competitieDTOs = competitiecollectieDal.GetCompetities();
                foreach (CompetitieDTO competitieDTO in competitieDTOs)
                {
                    competities.Add(new Competitie(competitieDTO));
                }

                return competities;
            }
        }
        public Competitiecolection(ICompetitiecollectieDal IcompetitiecollectieDal)
        {
            competitiecollectieDal = IcompetitiecollectieDal;
        }
    }

}
