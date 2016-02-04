using SimpleInformationalSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleInformationalSystem.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult All()
        {
            var dbContext = new NorthwindEntities();
            var allOrders = dbContext.Orders.Select(x => new OrderViewModel
            {
                OrderDate = x.OrderDate,
                ShippingAddress = x.ShipAddress
            }).ToList();

            return View(allOrders);
        }
    }
}