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
            if (bookStorage.IsBookExists(book))
                throw new InvalidOperationException("This book is already exists in the database.");
            bookStorage.Create(book);
        }
        public void RemoveBook(Book book)
        {
            if (!bookStorage.IsBookExists(book))
                throw new InvalidOperationException("This book hasn't been found in the database.");
            bookStorage.Delete(book);
        }
        public Book FindBookByTagBook(string isbn=null, string author=null, string name=null, string publisher=null, int year=-1, int numberOfPages=-1, decimal price=-1)
        {
            return bookStorage.GetAll().FirstOrDefault(b=> (isbn==null || b.ISBN==isbn) && (author == null || b.Author == author) && (name == null || b.Name == name) && (publisher == null || b.Publisher == publisher) && (year == - 1 || b.Year == year) && (numberOfPages == -1 || b.NumberOfPages == numberOfPages) && (price == -1 || b.Price == price));
        }

        public List<Book> SortBooksByTag(string tag)
        {
            throw new NotImplementedException();
        }
    }
}
