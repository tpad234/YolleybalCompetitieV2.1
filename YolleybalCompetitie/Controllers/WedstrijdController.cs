using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Mvc;
using Data;
using YolleybalCompetitie.Models;
using Microsoft.AspNetCore.Authorization;

namespace YolleybalCompetitie.Controllers
{
    public class WedstrijdController : Controller
    {
        private readonly IWedstrijdColectionDal IWedstrijdColectionDal;
        private readonly ISetDal iSetDal;
        public WedstrijdController(IWedstrijdColectionDal IwedstrijdColectionDal, ISetDal isetDal)
        {
            IWedstrijdColectionDal = IwedstrijdColectionDal;
            iSetDal = isetDal;
        }
        public IActionResult Index()
        {
            WedstrijdColection wedstrijdColection = new WedstrijdColection(IWedstrijdColectionDal);
            List<Wedstrijd> wedstrijden = wedstrijdColection.GetWedstrijden();

            WedstrijdViewModel wedstrijdViewModel = new WedstrijdViewModel()
            {
                Wedstrijden = wedstrijden,


            };
            return View(wedstrijdViewModel);
        }
    
        public IActionResult Details(int ID)
        {

            Wedstrijd wedstrijd = new Wedstrijd(iSetDal);
            List<Set> Sets = wedstrijd.GetSetsByWedstrijd(ID);
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Set", new { ID });
            }
            else
            {
                SetsViewModel setViewModel = new SetsViewModel()
                {
                    Sets = Sets,
                };
                return View(setViewModel);

            }
        }
    }
}