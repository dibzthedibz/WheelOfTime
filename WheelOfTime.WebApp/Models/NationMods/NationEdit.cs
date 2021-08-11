using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfTime.WebApp.Models.NationMods
{
    public class NationEdit
    {
        public int NationId { get; set; }
        [Display(Name = "Name Of Nation")]
        public string NationName { get; set; }
        public string Terrain { get; set; }
        public string Trades { get; set; }
    }
}
