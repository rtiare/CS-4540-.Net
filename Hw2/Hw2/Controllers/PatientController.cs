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
        public IActionResult Index()
        {
            return View();
        }
    }
}
