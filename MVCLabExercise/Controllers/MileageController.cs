using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLabExercise.Models;

namespace MVCLabExercise.Controllers
{
    public class MileageController : Controller
    {
        public IActionResult MileageForm()
        {
            return View();
        }

        //public IActionResult MileageResult(double mpg, double gallons)
        //{
        //    double range = mpg * gallons;

        //    return View("MileageResult", range);
        //}

        public IActionResult MileageResult(Trip trip)
        {
            trip.Range = Math.Round((trip.MPG * trip.Gallons), 2);
            
            if (trip.Range>= trip.TripMiles)
            {
                trip.Message = "You're good to go. Looks like you have enough gas!";
                trip.Color = "Green";
            }    
            else
            {
                trip.Message = "Where do you think you're going? You don't have enough gas!";
                trip.Color = "Red";
            }
            return View("MileageResult", trip);
   
        }


    }
}
