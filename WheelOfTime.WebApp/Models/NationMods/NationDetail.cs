using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Data;
using WheelOfTime.WebApp.Models.CharacterMods;

namespace WheelOfTime.WebApp.Models.NationMods
{
    public class NationDetail
    {
        public int NationId { get; set; }
        [Display(Name = "Name Of Nation")]
        public string NationName { get; set; }
        public string Terrain { get; set; }
        public string Trades { get; set; }
        public virtual List<Chapter> Chapters { get; set; }
        public virtual List<CharacterListItem> Characters { get; set; }
    }
}
