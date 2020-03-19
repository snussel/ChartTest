using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChartTest.Models
{
    public class StatsModel
    {
        [Display(Name = "Category")]
        public string xValue { get; set; }

        [Display(Name = "Quantity")]
        public int yValue { get; set; }
    }
}
