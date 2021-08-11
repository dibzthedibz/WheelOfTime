﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Data;
using WheelOfTime.WebApp.Models.ChapterMods;

namespace WheelOfTime.WebApp.Models.CharacterMods
{
    public class CharacterDetail
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }

        public string Ability { get; set; }
        public List<ChapterListItem> Chapters { get; set; }
        public virtual string Birthplace { get; set; }
        public virtual Nation Nation { get; set; }
        public int? NationId { get; set; }
    }
}
