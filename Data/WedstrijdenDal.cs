using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    class WedstrijdenDal : IWedstrijdColectionDal
    {
        public DataTable GetWedstrijden()
        {
            return DalAlgemeen.Select("SELECT * FROM Wedstrijd;");
        }
    }
}
