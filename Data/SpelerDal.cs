using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class SpelerDal : ISpelerColectionDal
    {
        public DataTable GetSpelers()
        {
            return DalAlgemeen.Select("SELECT * FROM Speler;");
        }
    }
}
