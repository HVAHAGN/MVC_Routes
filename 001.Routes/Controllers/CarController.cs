using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _001.Routes.Models;

namespace _001.Routes.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Companies()
        {
            List<PlainModel> models = new List<PlainModel>()
            {
                new PlainModel() {Company = "Toyota", Employees = 50000, Salary = 20000},
                new PlainModel() {Company = "Audi", Employees = 55000, Salary = 30000},
                new PlainModel() {Company = "Volvo", Employees = 10000, Salary = 8000}
            };

            return View(models);
        }
    }
}
