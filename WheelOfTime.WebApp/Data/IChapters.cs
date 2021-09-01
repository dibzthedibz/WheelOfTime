using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Models.ChapterMods;

namespace WheelOfTime.WebApp.Data
{
    public interface IChapters
    {
        public bool ChapterCreate(ChapterCreate model);
        public IEnumerable<ChapterListItem> GetChaps();
        public ChapterDetail GetChapterById(int id);
        public bool UpdateChapter(ChapterEdit chapter);
        public bool DeleteChapter(int chapterId);

    }
}
