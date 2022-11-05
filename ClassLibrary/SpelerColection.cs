using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class SpelerColection
    {
        readonly ISpelerColectionDal IspelerColectionDal;
        public List<DataRow> GetSpelers()
        {

            return IspelerColectionDal.GetSpelers();
        }
        public SpelerColection(ISpelerColectionDal spelerColectionDal)
        {
            IspelerColectionDal = spelerColectionDal;
        }
    }
}
