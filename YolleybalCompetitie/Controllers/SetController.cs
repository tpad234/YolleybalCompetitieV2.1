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
        private readonly ISetCollectionDal collectionDal;

        public SetController(ISetDal isetDal , ISetCollectionDal icolsetDal)
        {
            iSetDal = isetDal;
            collectionDal = icolsetDal;
        }
        public IActionResult Index(int WedstrijdID)
        {
            Wedstrijd wedstrijd = new Wedstrijd(collectionDal);
            List<Set> Sets = wedstrijd.GetSetsByWedstrijd(WedstrijdID);

            SetsViewModel setsViewModel = new SetsViewModel()
            {
                Sets = Sets,

            };
            return View(setsViewModel);
        }
        public IActionResult DetailsSet(int SetID)
        {
            SetViewModel setViewModel = new SetViewModel();
            Wedstrijd wedstrijd = new Wedstrijd(collectionDal);
            List<Set> Sets = wedstrijd.GetSetByID(SetID);
            if (Sets.Count == 1)
            {

                //TODO error handling
                foreach (Set set1 in Sets)
                {
                    if (set1.ID == SetID)
                    {
                        setViewModel.Set = set1;

                    }
                }
            }
                return View("Update", setViewModel);
        }
        [HttpPost]
        public IActionResult UpdateSet(SetViewModel vm)
        {
            Set set = new Set(iSetDal);
            //TODO error handling

            int rijenAangepast = set.UpdateSet(vm.Scoreteamthuis, vm.Scoreteamuit, vm.Winaar, vm.ID);
            if (rijenAangepast != 1)
            {
                TempData["message"] = "er is iets fout gegaan ";
                return RedirectToAction("index", new { vm.WedstrijdID });

            }
            else
            {
                return RedirectToAction("index", new { vm.WedstrijdID});

            }

        }

    }
}