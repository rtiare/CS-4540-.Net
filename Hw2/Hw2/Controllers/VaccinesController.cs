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
    }
}
