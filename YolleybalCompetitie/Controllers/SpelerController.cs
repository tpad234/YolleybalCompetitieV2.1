using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Data;
using Microsoft.AspNetCore.Mvc;
using YolleybalCompetitie.Models;

namespace YolleybalCompetitie.Controllers
{
    public class SpelerController : Controller
    {
        private readonly ISpelerColectionDal ISpelerColectionDal;

        public SpelerController(ISpelerColectionDal IspelerColectionDal)
        {
            ISpelerColectionDal = IspelerColectionDal;
        }
        public IActionResult Index()
        {
            SpelerColection spelerColection = new SpelerColection(ISpelerColectionDal);
            List<Speler> spelers = spelerColection.GetSpelers();

            SpelerViewModel spelerViewModel = new SpelerViewModel()
            {
                Spelers = spelers,
            };
            return View(spelerViewModel);
        }
    }
}