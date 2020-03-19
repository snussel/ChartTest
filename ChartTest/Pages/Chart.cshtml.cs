using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChartTest.Pages
{
    public class ChartModel : PageModel
    {
        public List<StatsModel> TheStats { get; set; }
        public string Title { get; set; }
        public string QueryType { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            switch (id)
            {
                case "M":
                    QueryType = "M";
                    Title = "Manufacturer";
                    TheStats = LoadData.GetStats("M");
                    break;
                case "C":
                    QueryType = "C";
                    Title = "Class";
                    TheStats = LoadData.GetStats("C");
                    break;
                case "L":
                    QueryType = "L";
                    Title = "Location";
                    TheStats = LoadData.GetStats("L");
                    break;
                case "T":
                    QueryType = "T";
                    Title = "Type";
                    TheStats = LoadData.GetStats("T");
                    break;
                default:
                    break;
            }

            return Page();
        }
    }
}