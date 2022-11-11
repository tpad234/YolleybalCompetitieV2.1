using Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class WedstrijdColection
    {
        readonly IWedstrijdColectionDal IwedstrijdColectionDal;
        public List<Wedstrijd> GetWedstrijden()
        {

            List<Wedstrijd> wedstrijden = new List<Wedstrijd>();
            List<GebruikerDTO> wedstrijdDTOs = IwedstrijdColectionDal.GetWedstrijden();
            foreach (GebruikerDTO wedstrijdDTO in wedstrijdDTOs)
            {
                wedstrijden.Add(new Wedstrijd(wedstrijdDTO));
            }

            return wedstrijden;
        }
        public WedstrijdColection(IWedstrijdColectionDal wedstrijdColectionDal)
        {
            IwedstrijdColectionDal = wedstrijdColectionDal;
        }

    }
}
