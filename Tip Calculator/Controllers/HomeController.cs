using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tip_Calculator.Models;

namespace Tip_Calculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.A = 0;
            ViewBag.B = 0;
            ViewBag.C = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.A = model.CalculateFifteen();
                ViewBag.B = model.CalculateTwenty();
                ViewBag.C = model.CalculateTwentyFive();
            }
            else
            {
                ViewBag.A = 0;
                ViewBag.B = 0;
                ViewBag.C = 0;
            }
            return View(model);
        }
    }
}