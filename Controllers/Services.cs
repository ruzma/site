using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace NLXADRIA.Controllers
{
    public class Services : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Services";
            return View();
        }
    }
}