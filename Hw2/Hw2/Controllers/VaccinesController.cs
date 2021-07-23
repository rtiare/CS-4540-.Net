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

        public IActionResult Edit(int id) {
            return View(_vaccineService.GetVaccine(id));
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
            return View();
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
