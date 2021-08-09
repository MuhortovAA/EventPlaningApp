using EventPlaningApp.Services.Interfaces;
using EventPlaningApp.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventPlaningApp.Controllers
{
    public class HomeController : Controller
    {
        private ICBTEvent repository;

        public HomeController(ICBTEvent repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.GetData());
        }
    }
}
