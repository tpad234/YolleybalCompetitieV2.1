using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class SpelerDal : ISpelerColectionDal
    {
        public List<Speler> GetSpelers()
        {
            DataTable dt = DalAlgemeen.Select("SELECT Speler.ID, Speler.Voornaam, Speler.Achternaam, Speler.Leeftijd, Speler.Woonplaats, Team.Naam FROM Speler JOIN Team ON Speler.TeamID=Team.ID ;");
            List<Speler> spelers = new List<Speler>();
            foreach (DataRow dr in dt.Rows)
            {

                Team team = new Team(dr.ItemArray[5].ToString());
                Speler speler = new Speler(dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), int.Parse(dr.ItemArray[3].ToString()), dr.ItemArray[4].ToString(), team);
                spelers.Add(speler);
            }
            return spelers;

        }
    }
}
