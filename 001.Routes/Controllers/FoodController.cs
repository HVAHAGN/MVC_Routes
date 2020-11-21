using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _001.Routes.Models;

namespace _001.Routes.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Companies()
        {
            List<PlainModel> models = new List<PlainModel>()
            {
                new PlainModel() {Company = "Nestle", Employees = 10000, Salary = 3000},
                new PlainModel() {Company = "Sobeys", Employees = 55000, Salary = 30000},
                new PlainModel() {Company = "Chocolove", Employees = 8000, Salary = 5000}
            };

            return View(models);
        }
    }
}
