using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public interface ISetDal
    {
        List<SetDTO> GetSetByWedstrijd(int ID);
   }
}
