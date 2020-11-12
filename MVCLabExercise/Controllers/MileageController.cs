using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCLabExercise.Controllers
{
    public class MileageController : Controller
    {
        public IActionResult MileageForm()
        {
            return View();
        }

        public IActionResult MileageResult(double mpg, double gallons)
        {
            double range = mpg * gallons;

            return View("MileageResult", range);
        }


    }
}
