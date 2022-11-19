using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Enum;
using Data;
using Microsoft.AspNetCore.Authorization;
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
            Wedstrijd wedstrijd = new Wedstrijd(iSetDal);
            List<Set> Sets = wedstrijd.GetSetsByWedstrijd(ID);

            SetsViewModel setViewModel = new SetsViewModel()
            {
                Sets = Sets,

            };
            return View(setViewModel);
        }
        [HttpPost]
        public IActionResult UpdateSet(SetsViewModel vm)
        {
            Set set = new Set(iSetDal);
            //TODO error handling
         
                int rijenAangepast = set.UpdateSet(vm.Scoreteamthuis, vm.Scoreteamuit, vm.Winaar, vm.ID);
                if (rijenAangepast == 2 && rijenAangepast == 0)
                {
                    TempData["message"] = "er is iets fout gegaan ";
                    return RedirectToAction("Index", new { vm.ID });

                }
                else
                {
                    return RedirectToAction("Index", "competitie");

                } 

        }

    }
}