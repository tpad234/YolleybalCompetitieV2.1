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
        private readonly ICompetitiecollectieDal ICompetitiecollectieDal ;
        public CompetitieController(ICompetitiecollectieDal IcompetitiecollectieDal)
        {
            ICompetitiecollectieDal = IcompetitiecollectieDal;
        }
        public IActionResult Index()
        {
            Competitiecolection Competitiecolection = new Competitiecolection(ICompetitiecollectieDal);
            List<Competitie> Competities = Competitiecolection.GetCompetities();
         
            CompetitieViewModel competitieViewModel = new CompetitieViewModel()
            {
                Competities = Competities,
            };
            return View(competitieViewModel);
        }


    }
}