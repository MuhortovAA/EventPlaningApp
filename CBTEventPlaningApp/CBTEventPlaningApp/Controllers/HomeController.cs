using CBTEventPlaningApp.Services.Interface;
using CBTEventPlaningApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Controllers
{
	public class HomeController : Controller
	{
		private IEFRepository repository;

		public HomeController(IEFRepository repo)
		{
			repository = repo;
		}
		public IActionResult Index() => View(repository.GetEvents());

		public IActionResult Detailes(string id) => View(repository.GetAllInfoEvent(id));

	}
}
