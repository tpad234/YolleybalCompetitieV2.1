using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    class WedstrijdColection
    {
        readonly IWedstrijdColectionDal IwedstrijdColectionDal;
        public DataTable GetWedstrijden()
        {

            return IwedstrijdColectionDal.GetWedstrijden();
        }
        public WedstrijdColection(IWedstrijdColectionDal wedstrijdColectionDal)
        {
            IwedstrijdColectionDal = wedstrijdColectionDal;
        }
    }
}
