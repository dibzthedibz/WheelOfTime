using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Models.ChapterMods;

namespace WheelOfTime.WebApp.Models.BookMods
{
    public class BookEdit
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public virtual List<ChapterListItem> Chapters { get; set; }
        public string Image { get; set; }
    }
}
