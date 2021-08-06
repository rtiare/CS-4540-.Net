using Hw2.Models;
using Hw2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw2.Controllers
{
    public class PatientsController : Controller
    {
        public readonly IPatientService _patientService;
        private readonly IVaccineService _vaccineService;

        public PatientsController(IPatientService patientService, IVaccineService vaccineService)
        {
            _patientService = patientService;
            _vaccineService = vaccineService;
        }

        public IActionResult Index()
        {
            return View(_patientService.GetPatients());
        }

        //Display the Add form
        [HttpGet]
        public IActionResult AddPatient()
        {
            //make dropdown list with DoseRequired values (text, value)
            ViewBag.VaccineList = _vaccineService.GetVaccines()
                .Select(e => new SelectListItem(e.VaccineName, e.Id.ToString()))
                .ToList();
            return View();
        }

        //process adding form
        [HttpPost]
        public IActionResult AddPatient(Patient patient)
        {
            //Decrement the stock of the selected vaccine by 1.

            //get the vaccine with patient vaccine id
            Vaccine selected = _vaccineService.GetVaccine(patient.Vaccineid);
            //decrease it and save changes
            int stock = selected.TotalDose - 1;
            selected.TotalDose = stock;
            _vaccineService.SaveChanges();

            //Set the date of the first dose for the patient to the current date.
            DateTime currentTIme = DateTime.Now.Date;
            patient.FirstDose = currentTIme;

            if (selected.DoseRequired == 1) {
                patient.SecondDose = "-";
            }

            //save the changes to database
            _patientService.AddPatient(patient);
            return RedirectToAction("Index");
        }

    }
}
