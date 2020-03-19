using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChartTest.Pages
{
    public class DetailsModel : PageModel
    {
        public string Title { get; set; }
        public string QueryType { get; set; }
        public List<VehicleModel> TheItems { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {


            QueryType = id.Substring(0, 1);
            Title = id.Substring(2);

            TheItems = LoadData.GetList(QueryType, Title);

            return Page();
        }
    }
}