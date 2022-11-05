using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class WedstrijdColection
    {
        readonly IWedstrijdColectionDal IwedstrijdColectionDal;
        public List<DataRow> GetWedstrijden()
        {

            return IwedstrijdColectionDal.GetWedstrijden();
        }
        public WedstrijdColection(IWedstrijdColectionDal wedstrijdColectionDal)
        {
            IwedstrijdColectionDal = wedstrijdColectionDal;
        }
    }
}
