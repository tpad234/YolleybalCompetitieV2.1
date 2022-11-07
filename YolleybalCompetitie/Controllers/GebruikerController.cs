using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Data;
using Microsoft.AspNetCore.Mvc;
using YolleybalCompetitie.Models;

namespace YolleybalCompetitie.Controllers
{
    public class GebruikerController : Controller
    {
        private readonly IGebruikerDal IgebruikerDal = new GebruikerDal();

        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Inloggen(string username, string Wachtwoord )
        {
            Gebruiker gebruiker = new Gebruiker(IgebruikerDal);

            if (gebruiker.CheckInlog(username, Wachtwoord))
            {
                return View();
            }
            return View();
        }
    }
}