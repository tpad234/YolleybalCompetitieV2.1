using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Core.DTO;

namespace Core
{
    public class SpelerColection
    {
        readonly ISpelerColectionDal IspelerColectionDal;
        public List<Speler> GetSpelers()
        {
            List<Speler> spelers = new List<Speler>();
          List<SpelerDTO> spelerDTOs =  IspelerColectionDal.GetSpelers();
            foreach (SpelerDTO spelerDTO in spelerDTOs)
            {
               spelers.Add( new Speler(spelerDTO));
            }
            return spelers;

        }
        public SpelerColection(ISpelerColectionDal spelerColectionDal)
        {
            IspelerColectionDal = spelerColectionDal;
        }
    }
}
