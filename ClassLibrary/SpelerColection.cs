using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    class SpelerColection
    {
        readonly ISpelerColectionDal IspelerColectionDal;
        public DataTable GetSpelers()
        {

            return IspelerColectionDal.GetSpelers();
        }
        public SpelerColection(ISpelerColectionDal spelerColectionDal)
        {
            IspelerColectionDal = spelerColectionDal;
        }
    }
}
