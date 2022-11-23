using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface ISetCollectionDal
    {
        List<SetDTO> GetSetByWedstrijd(int ID);
        public List<SetDTO> GetSetByID(int ID);

    }
}
