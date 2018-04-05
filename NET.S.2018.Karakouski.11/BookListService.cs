using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NET.S._2018.Karakouski._11
{
    class BookListService
    {
        private IBookStorage bookStorage;
        private ILogger logger;

        public BookListService(IBookStorage bookStorage, ILogger logger)
        {
            this.bookStorage = bookStorage;
            this.logger = logger;
        }

        public void AddBook(Book book)
        {
            bookStorage.Create(book);
        }
        public void RemoveBook(Book book)
        {
            bookStorage.Delete(book);
        }
        public Book FindBookByTagBook(string isbn=null, string author=null, string name=null, string publisher=null, int year=-1, int nummberOfPages=-1, decimal price=-1)
        {
            return bookStorage.GetAll().FirstOrDefault();
        }

        public List<Book> SortBooksByTag()
        {
            return bookStorage.GetAll().OrderBy().ToList();
        }
    }
}
