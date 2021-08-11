﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfTime.WebApp.Models.ChapterMods
{
    public class ChapterDetail
    {
        public int ChapterId { get; set; }
        public int ChapNum { get; set; }
        public string ChapTitle { get; set; }
        public int PageCount { get; set; }
        public virtual string BookIn { get; set; }
        public virtual string Narrator { get; set; }
        public virtual string Location { get; set; }
        public int BookId { get; set; }
    }
}
