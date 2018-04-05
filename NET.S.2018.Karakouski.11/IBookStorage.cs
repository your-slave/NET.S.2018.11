using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2018.Karakouski._11
{
    interface IBookStorage
    {
        void Create(Book book);
        void Update(Book book);
        void Delete(Book book);
        bool IsBookExists(Book desiredBook);
        List<Book> GetAll();
    }
}
