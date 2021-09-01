using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Models.BookMods;
using WheelOfTime.WebApp.Models.ChapterMods;

namespace WheelOfTime.WebApp.Data
{
    public interface IBooks
    {
        public IEnumerable<BookListItem> GetBooks();
        public BookDetail GetBookById(int id);
        public bool UpdateBook(BookEdit book);
        public bool DeleteBook(int bookId);
    }
    
}

