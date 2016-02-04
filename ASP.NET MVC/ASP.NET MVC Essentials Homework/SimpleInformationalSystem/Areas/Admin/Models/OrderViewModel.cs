using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleInformationalSystem.Areas.Admin.Models
{
    public class OrderViewModel
    {
        public DateTime? OrderDate { get; set; }
        public string ShippingAddress { get; set; }
    }
}