﻿using System;
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
    public class TeamController : Controller
    {
        private readonly ITeamCollectionDal IteamCollectionDal = new TeamDal();

        public IActionResult Index()
        {
            TeamCollection teamCollection = new TeamCollection(IteamCollectionDal);
            List<DataRow> test3 = teamCollection.GetTeams();

            TeamViewModel teamViewControler = new TeamViewModel()
            {
                Teams = test3,
            };
            return View(teamViewControler);
        }

    }
}