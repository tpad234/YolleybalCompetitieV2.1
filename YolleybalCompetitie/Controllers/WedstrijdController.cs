using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Mvc;
using Data;
using YolleybalCompetitie.Models;

namespace YolleybalCompetitie.Controllers
{
    public class WedstrijdController : Controller
    {
        private readonly IWedstrijdColectionDal IwedstrijdColectionDal = new WedstrijdenDal();
        private readonly ISetDal isetDal = new SetDal();
        public IActionResult Index()
        {
            WedstrijdColection wedstrijdColection = new WedstrijdColection(IwedstrijdColectionDal);
            List<Wedstrijd> wedstrijden = wedstrijdColection.GetWedstrijden();

            WedstrijdViewModel wedstrijdViewModel = new WedstrijdViewModel()
            {
                Wedstrijden = wedstrijden,
                 // score = "",



            };
            return View(wedstrijdViewModel);
        }
        public IActionResult Details(int ID)
        {
            Set set = new Set(isetDal);
            List<Set> Sets = set.GetSetsByWedstrijd(ID);

            SetViewModel setViewModel = new SetViewModel()
            {
                Sets = Sets,
            };
            return View(setViewModel);
        }
    }
}