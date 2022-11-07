﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Mvc;
using Data;
using YolleybalCompetitie.Models;

namespace YolleybalCompetitie.Controllers
{
    public class WedstrijdController : Controller
    {
        private readonly IWedstrijdColectionDal IwedstrijdColectionDal = new WedstrijdenDal();
        public IActionResult Index()
        {
            WedstrijdColection wedstrijdColection = new WedstrijdColection(IwedstrijdColectionDal);
            List<Wedstrijd> test3 = wedstrijdColection.GetWedstrijden();
         
            WedstrijdViewModel wedstrijdViewModel = new WedstrijdViewModel()
            {
                Wedstrijden = test3,
             //   score = "",

             //   Winaar = "",


            };
            return View(wedstrijdViewModel);
        }
    }
}