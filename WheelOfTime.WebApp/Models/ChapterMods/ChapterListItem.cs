using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WheelOfTime.WebApp.Models.ChapterMods
{
    public class ChapterListItem
    {
        public int ChapterId { get; set; }

        [Display(Name = "Chapter Number")]
        public int ChapNum { get; set; }

        [Display(Name = "Title of Chapter")]
        public string ChapTitle { get; set; }
        public int PageCount { get; set; }
    }
}
