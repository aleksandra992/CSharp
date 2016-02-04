using SimpleInformationalSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleInformationalSystem.Areas.Admin.Controllers
{
    public class AdminCustomersController : Controller
    {
        [HttpGet]
        public ActionResult All()
        {
            var dbContext = new NorthwindEntities();
            var allCustomers = dbContext.Customers.Select(x => new CustomerViewModel()
            {
                CompanyName = x.CompanyName,
                ContactName = x.ContactName
            }).ToList();
            return View(allCustomers);
        }
    }
}