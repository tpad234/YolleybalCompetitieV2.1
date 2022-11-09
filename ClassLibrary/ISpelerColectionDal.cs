using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Core.DTO;

namespace Core
{
   public  interface ISpelerColectionDal
    {
        List<SpelerDTO> GetSpelers();
    }
}
