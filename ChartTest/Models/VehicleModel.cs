using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChartTest.Models
{
    public partial class VehicleModel
    {
        [Key]
        public int VID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        [Display(Name = "Type")]
        public string vType { get; set; }

        [Display(Name = "Class")]
        public string vClass { get; set; }

        [Display(Name = "Modified?")]
        public bool isMod { get; set; } = false;

        [Display(Name = "Insured?")]
        public bool isInsured { get; set; } = true;


        public string CLURL { get; set; }
        public string CVURL { get; set; }
    }
}
