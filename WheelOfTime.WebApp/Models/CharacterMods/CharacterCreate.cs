using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Models.ChapterMods;

namespace WheelOfTime.WebApp.Models.CharacterMods
{
    public class CharacterCreate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ability { get; set; }
        public int NationId { get; set; }
        public List<ChapterListItem> Chapters { get; set; }
        public string Image { get; set; }
    }
}
