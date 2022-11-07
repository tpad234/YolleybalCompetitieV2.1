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
    public class CompetitieController : Controller
    {
        private readonly ICompetitiecollectieDal IcompetitiecollectieDal = new CompetitieDal();
        public IActionResult Index()
        {
            Competitiecolection Competitiecolection = new Competitiecolection(IcompetitiecollectieDal);
            List<Competitie> Competities = Competitiecolection.Test();
         
            CompetitieViewModel competitieViewModel = new CompetitieViewModel()
            {
                Competities = Competities,
            };
            return View(competitieViewModel);
        }


    }
}