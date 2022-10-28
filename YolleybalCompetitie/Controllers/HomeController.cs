using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YolleybalCompetitie.Models;
using Data;
using System.Data;
using Core;

namespace YolleybalCompetitie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICompetitiecollectieDal IcompetitiecollectieDal = new CompetitieDal();
        private readonly ITeamDal IteamDal = new TeamDal();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {  
            Competitiecolection Competitiecolection = new Competitiecolection(IcompetitiecollectieDal);
            DataTable test3 = Competitiecolection.Test();
            int test = test3.Rows.Count;
            if (test == 2)
            {
                TeamCollection teamCollection = new TeamCollection(IteamDal);
                DataTable test31 = teamCollection.Test();
                int test1 = test31.Rows.Count;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
