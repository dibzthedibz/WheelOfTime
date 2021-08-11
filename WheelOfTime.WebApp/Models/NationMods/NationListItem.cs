using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfTime.WebApp.Models.NationMods
{
    public class NationListItem
    {
        public int NationId { get; set; }
        [Display(Name = "Nation")]
        public string NationName { get; set; }
    }
}
