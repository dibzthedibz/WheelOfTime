using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Models.ChapterMods;

namespace WheelOfTime.WebApp.Data
{
    public class ChaptersRepository : IChapters
    {
        private readonly Guid _userId;
        public ChaptersRepository(Guid userId)
        {
            _userId = userId;
        }
        public bool ChapterCreate(ChapterCreate model)
        {
            var entity = new Chapter()
            {
                OwnerId = _userId,
                ChapNum = model.ChapNum,
                ChapTitle = model.ChapTitle,
                PageCount = model.PageCount,
                BookId = model.BookId,
                NationId = model.NationId,
                CharacterId = model.CharacterId
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Chapters.Add(entity);
                return ctx.SaveChanges() == 1;
            };
        }


        public IEnumerable<ChapterListItem> GetChaps()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Chapters.Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new ChapterListItem
                        {
                            ChapterId = e.ChapterId,
                            ChapNum = e.ChapNum,
                            ChapTitle = e.ChapTitle,
                            PageCount = e.PageCount
                        }
                    );
                return query.ToArray();
            }
        }
        public ChapterDetail GetChapterById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Chapters.Single(e => e.ChapterId == id && e.OwnerId == _userId);
                return new ChapterDetail
                {
                    ChapterId = entity.ChapterId,
                    ChapNum = entity.ChapNum,
                    ChapTitle = entity.ChapTitle,
                    PageCount = entity.PageCount,
                    BookIn = entity.Book.Title,
                    Narrator = entity.Character.FirstName,
                    Location = entity.Nation.NationName
                };
            }
        }
        public bool UpdateChapter(ChapterEdit chapter)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Chapters
                        .Single(e => e.ChapterId == chapter.ChapterId && e.OwnerId == _userId);
                entity.ChapNum = chapter.ChapNum;
                entity.ChapTitle = chapter.ChapTitle;
                entity.PageCount = chapter.PageCount;
                entity.BookId = chapter.BookId;
                entity.CharacterId = chapter.CharacterId;
                entity.NationId = chapter.NationId;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteChapter(int chapterId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Chapters
                        .Single(e => e.ChapterId == chapterId && e.OwnerId == _userId);

                ctx.Chapters.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
