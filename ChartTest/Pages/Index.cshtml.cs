using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ChartTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<VehicleModel> MasterList { get; set; }
        public void OnGet()
        {
            MasterList = LoadData.GetList();
        }
    }
}
