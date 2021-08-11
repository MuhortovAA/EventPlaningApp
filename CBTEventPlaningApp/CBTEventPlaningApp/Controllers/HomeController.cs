using CBTEventPlaningApp.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CBTEventPlaningApp.Controllers
{
    public class HomeController : Controller
	{
		private IEFRepository repository;

		public HomeController(IEFRepository repo)
		{
			repository = repo;
		}
		public IActionResult Index() => View(repository.GetAllFullEvents());

		public IActionResult Detailes(string id) => View(repository.GetAllInfoEvent(id));

	}
}
