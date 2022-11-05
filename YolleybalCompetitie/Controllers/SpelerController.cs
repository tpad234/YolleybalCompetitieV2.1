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
        private readonly ISpelerColectionDal IspelerColectionDal = new SpelerDal();

        public IActionResult Index()
        {
            SpelerColection spelerColection = new SpelerColection(IspelerColectionDal);
            List<DataRow> test3 = spelerColection.GetSpelers();

            SpelerViewModel spelerViewModel = new SpelerViewModel()
            {
                Spelers = test3,
            };
            return View(spelerViewModel);
        }
    }
}