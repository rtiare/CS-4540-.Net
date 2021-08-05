using Hw2.Models;
using Hw2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hw2.Controllers
{
    public class PatientController : Controller
    {
        public readonly IPatientService _patientService;

        public PatientController(IPatientService patientService) {
            _patientService = patientService;
        }

        //list all patients in view
        public IActionResult Index()
        {
            return View(_patientService.GetPatients());
        }

        //Display the Add form
        [HttpGet]
        public IActionResult AddPatient()
        {
            return View();
        }

        //process adding form
        [HttpPost]
        public IActionResult AddVaccine(Patient patient)
        {
            _patientService.AddPatient(patient);
            return RedirectToAction("Index");
        }

    }
}
