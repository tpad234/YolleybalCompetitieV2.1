using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YolleybalCompetitie.Models;

namespace YolleybalCompetitie.Controllers
{
    public class SetController : Controller
    {
        private readonly ISetDal iSetDal;

        public SetController(ISetDal isetDal)
        {
            iSetDal = isetDal;
        }
        public IActionResult Index(int ID)
        {
            Set set = new Set(iSetDal);
           List<Set> Sets = set.GetSetsByWedstrijd(ID);

            SetViewModel setViewModel = new SetViewModel()
            {
                Sets = Sets,
            };
            return View(setViewModel);
        }


    }
}