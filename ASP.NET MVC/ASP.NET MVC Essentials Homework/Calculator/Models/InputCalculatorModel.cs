using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class InputCalculatorModel
    {
        [Required]
        [Range(1, 10000)]
        public int Quantity { get; set; }

        public string Type { get; set; }

        public IEnumerable<MeasuringType> Types { get; set; }

        public int Kilo { get; set; }

        public IEnumerable<int> Kilos { get; set; }

    }
}