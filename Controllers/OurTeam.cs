using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace NLXADRIA.Controllers
{
    public class OurTeam : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "OurTeam";
            return View();
        }

    }
}