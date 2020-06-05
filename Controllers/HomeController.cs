using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("")]
        public RedirectToActionResult HandleFormSubmission(string Name, string Location, string Language, string Comment)
        {
            return RedirectToAction("Result", new{name = Name, location = Location, language = Language, comment = Comment});
        } 


        [HttpGet("result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
            Survey survey = new Survey(name, location, language, comment);
            return View("Result", survey);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
