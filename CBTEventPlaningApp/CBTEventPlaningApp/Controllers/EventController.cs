using CBTEventPlaningApp.Services.Interface;
using CBTEventPlaningApp.Services.Models;
using CBTEventPlaningApp.Services.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp.Controllers
{
    public class EventController : Controller
    {
        private IEFRepository repository;

        public EventController(IEFRepository repo)
        {
            repository = repo;
        }
        public IActionResult Detailes(string id) => View(repository.GetAllInfoEvent(id));
        public IActionResult Create() => View(new CreateEvent());

        [HttpPost]
        public IActionResult Create(CreateEvent newevent)
        {

            if (ModelState.IsValid)
            {
                int id = repository.SaveEvent(newevent);
                TempData["message"] = $"Создано событие.";
                return RedirectToAction(actionName: "Detailes", controllerName: "Event", routeValues: new { id = id.ToString() });
            }
            else
            {
                return View();
            }
        }
        public IActionResult AddTitle(string Id) => View(new CBTDetailes() { EventId = int.Parse(Id), Title = "название", SubTitle = "описание" });
        [HttpPost]
        public IActionResult AddTitle(CBTDetailes detail)
        {

            if (ModelState.IsValid)
            {
                repository.SaveTitle(detail);
                TempData["message"] = $"Добавлено.";
                return RedirectToAction(actionName: "Detailes", controllerName: "Event", routeValues: new { id = detail.EventId.ToString() });
            }
            else
            {
                return View();
            }
        }
        public IActionResult EditTitle(string Id) => View(repository.GetDetaileById(Id));
        [HttpPost]
        public IActionResult EditTitle(CBTDetailes detail)
        {

            if (ModelState.IsValid)
            {
                repository.EditTitle(detail);

                TempData["message"] = $"Обновлено.";
                return RedirectToAction(actionName: "Detailes", controllerName: "Event", routeValues: new { id = detail.EventId.ToString() });
            }
            else
            {
                return View();
            }
        }
    }
}
