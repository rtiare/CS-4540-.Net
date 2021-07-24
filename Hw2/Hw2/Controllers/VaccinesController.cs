using Hw2.Models;
using Hw2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw2.Controllers
{
    public class VaccinesController : Controller
    {
        public readonly IVaccineService _vaccineService;

        public VaccinesController(IVaccineService vaccineService) {
            _vaccineService = vaccineService;
        }
        public IActionResult Index()
        {
            return View(_vaccineService.GetVaccines());
        }

        //Display the Add form
        [HttpGet]
        public IActionResult Edit(int id) {
            return View(_vaccineService.GetVaccine(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, Vaccine change) {
            //search by id
            var vaccineFound = _vaccineService.GetVaccine(id);
            //update
            vaccineFound.VaccineName = change.VaccineName;
            vaccineFound.DoseRequired = change.DoseRequired;
            vaccineFound.DaysBtwDose = change.DaysBtwDose;
            vaccineFound.TotalDose = change.TotalDose;
            vaccineFound.DoseLeft = change.DoseLeft;
            //save in backend
            _vaccineService.SaveChanges();

            return RedirectToAction("Index");
        }

        //Display the Add form
        [HttpGet]
        public IActionResult AddVaccine() {
            return View();
        }

        //process adding form
        [HttpPost]
        public IActionResult AddVaccine(Vaccine vaccine) {
            _vaccineService.AddVaccine(vaccine);
            return RedirectToAction("Index");
        }

        //Display the Add dose form
        [HttpGet]
        public IActionResult AddDose()
        {
            return View(_vaccineService.GetVaccines());
        }

        //process adding dose form
        [HttpPost]
        public IActionResult AddDose(int id)
        {
            //_vaccineService.AddVaccine(vaccine);
            return RedirectToAction("Index");
        }
    }
}
