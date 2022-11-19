using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Core;
using Data;
using Microsoft.AspNetCore.Mvc;
using YolleybalCompetitie.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace YolleybalCompetitie.Controllers
{
    public class GebruikerController : Controller
    {
        private readonly IGebruikerDal IgebruikerDal = new GebruikerDal();
        
        public IActionResult Index()
        {
            HttpContext.SignOutAsync();
            return View();
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Inloggen(GebruikerViewModel vm)
      //  public IActionResult Inloggen(string username, string Wachtwoord)
        {

            Gebruiker gebruiker = new Gebruiker(IgebruikerDal);
            if (gebruiker.CheckInlog(vm.Gebruikersnaam, vm.Wachtwoord))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, vm.Gebruikersnaam)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return RedirectToAction("Index", "Competitie");
            }
            else
            {
            return (View());

            }
            
        }
    }
}