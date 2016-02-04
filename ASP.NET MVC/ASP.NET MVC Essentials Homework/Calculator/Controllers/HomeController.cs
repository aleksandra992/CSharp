using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Calculator(int quantity = 1, string type = "Bit", int kilo = 1024)
        {
            var baseValue = this.BaseValue(kilo, type);
            var inputCalculatorModel = new InputCalculatorModel();

            var types = new List<MeasuringType>
            {
                 new MeasuringType(){ Name = "Bit", Value = quantity / (Math.Pow(kilo, 0)/baseValue) * 8},
                new MeasuringType(){ Name = "Byte", Value = quantity / (Math.Pow(kilo, 0)/baseValue)},
                new MeasuringType(){ Name = "Kilobit", Value = quantity / (Math.Pow(kilo, 1)/baseValue) * 8},
                new MeasuringType(){ Name = "Kilobyte", Value = quantity / (Math.Pow(kilo, 1)/baseValue)},
                new MeasuringType(){ Name = "Megabit", Value = quantity / (Math.Pow(kilo, 2)/baseValue) * 8},
                new MeasuringType(){ Name = "Megabyte", Value = quantity / (Math.Pow(kilo, 2)/baseValue)},
                new MeasuringType(){ Name = "Gigabit", Value = quantity / (Math.Pow(kilo, 3)/baseValue) * 8},
                new MeasuringType(){ Name = "Gigabyte", Value = quantity / (Math.Pow(kilo, 3)/baseValue)},
                new MeasuringType(){ Name = "Terabit", Value = quantity / (Math.Pow(kilo, 4)/baseValue) * 8},
                new MeasuringType(){ Name = "Terabyte", Value = quantity / (Math.Pow(kilo, 4)/baseValue)},
                new MeasuringType(){ Name = "Petabit", Value =  quantity / (Math.Pow(kilo, 5)/baseValue) * 8},
                new MeasuringType(){ Name = "Petabyte", Value = quantity / (Math.Pow(kilo, 5)/baseValue)},
                new MeasuringType(){ Name = "Exabit", Value = quantity / (Math.Pow(kilo, 6)/baseValue) * 8},
                new MeasuringType(){ Name = "Exabyte", Value = quantity / (Math.Pow(kilo, 6)/baseValue)},
                new MeasuringType(){ Name = "Zettabit", Value = quantity / (Math.Pow(kilo, 7)/baseValue) * 8},
                new MeasuringType(){ Name = "Zettabyte", Value = quantity / (Math.Pow(kilo, 7)/baseValue)},
                new MeasuringType(){ Name = "Yottabit", Value = quantity / (Math.Pow(kilo, 8)/baseValue) * 8},
                new MeasuringType(){ Name = "Yottabyte", Value = quantity / (Math.Pow(kilo, 8)/baseValue)},
            };
            inputCalculatorModel.Types = types;
            inputCalculatorModel.Kilos = new List<int>
            {
                1024,
                1000
            };
            inputCalculatorModel.Quantity = quantity;
            inputCalculatorModel.Type = type;
            inputCalculatorModel.Kilo = kilo;
            return View(inputCalculatorModel);
        }

        [NonAction]
        private double BaseValue(int baseValue, string typeOfUnit)
        {
            var listOfEntities = new List<MeasuringType>()
            {
                new MeasuringType(){ Name = "Bit", Value = (Math.Pow(baseValue, 0)/8)},
                new MeasuringType(){ Name = "Byte", Value =  (Math.Pow(baseValue, 0))},
                new MeasuringType(){ Name = "Kilobit", Value =  (Math.Pow(baseValue, 1)/8)},
                new MeasuringType(){ Name = "Kilobyte", Value = (Math.Pow(baseValue, 1))},
                new MeasuringType(){ Name = "Megabit", Value = (Math.Pow(baseValue, 2)/8)},
                new MeasuringType(){ Name = "Megabyte", Value = (Math.Pow(baseValue, 2))},
                new MeasuringType(){ Name = "Gigabit", Value = (Math.Pow(baseValue, 3)/8)},
                new MeasuringType(){ Name = "Gigabyte", Value = (Math.Pow(baseValue, 3))},
                new MeasuringType(){ Name = "Terabit", Value = (Math.Pow(baseValue, 4)/8)},
                new MeasuringType(){ Name = "Terabyte", Value = (Math.Pow(baseValue, 4))},
                new MeasuringType(){ Name = "Petabit", Value =  (Math.Pow(baseValue, 5)/8)},
                new MeasuringType(){ Name = "Petabyte", Value = (Math.Pow(baseValue, 5))},
                new MeasuringType(){ Name = "Exabit", Value = (Math.Pow(baseValue, 6)/8)},
                new MeasuringType(){ Name = "Exabyte", Value = (Math.Pow(baseValue, 6))},
                new MeasuringType(){ Name = "Zettabit", Value = (Math.Pow(baseValue, 7)/8)},
                new MeasuringType(){ Name = "Zettabyte", Value = (Math.Pow(baseValue, 7))},
                new MeasuringType(){ Name = "Yottabit", Value = (Math.Pow(baseValue, 8)/8)},
                new MeasuringType(){ Name = "Yottabyte", Value = (Math.Pow(baseValue, 8))},
            };

            double value = listOfEntities.FirstOrDefault(u => u.Name == typeOfUnit).Value;
            return value;
        }
    }
}