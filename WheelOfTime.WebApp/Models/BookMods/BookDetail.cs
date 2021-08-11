using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Data;
using WheelOfTime.WebApp.Models.ChapterMods;

namespace WheelOfTime.WebApp.Models.BookMods
{
    public class BookDetail
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public virtual List<ChapterListItem> Chapters { get; set; }
        //public virtual List<NationListItem> Nations { get; set; }
        //    public virtual List<CharacterListItem> Characters { get; set; }
        public string Image { get; set; }

        public virtual Chapter Chapter { get; set; }
    }
}
