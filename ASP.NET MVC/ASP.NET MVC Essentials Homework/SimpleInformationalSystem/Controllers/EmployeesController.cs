using SimpleInformationalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleInformationalSystem.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult All()
        {
            var dbContext = new NorthwindEntities();
            var allEmployees = dbContext.Employees.Select(x => new EmployeeViewModel()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Title = x.Title
            });
            return View(allEmployees);
        }
    }
}