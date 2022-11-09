using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Core.DTO;

namespace Data
{
    public class SpelerDal : ISpelerColectionDal
    {
        public List<SpelerDTO> GetSpelers()
        {
            DataTable dt = DalAlgemeen.Select("SELECT Speler.ID, Speler.Voornaam, Speler.Achternaam, Speler.Leeftijd, Speler.Woonplaats, Team.Naam FROM Speler JOIN Team ON Speler.TeamID=Team.ID ;");
            List<SpelerDTO> spelers = new List<SpelerDTO>();
            foreach (DataRow dr in dt.Rows)
            {

                TeamDTO team = new TeamDTO(dr.ItemArray[5].ToString());
                SpelerDTO speler = new SpelerDTO(dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), int.Parse(dr.ItemArray[3].ToString()), dr.ItemArray[4].ToString(), team);
                spelers.Add(speler);
            }
            return spelers;

        }
    }
}
