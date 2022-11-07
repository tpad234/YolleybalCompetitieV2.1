using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
   public  interface ISpelerColectionDal
    {
        List<Speler> GetSpelers();
    }
}
