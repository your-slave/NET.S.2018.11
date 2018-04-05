using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2018.Karakouski._11
{
    interface IBookStorage
    {
        bool Create(Book book);
        bool Update(Book book);
        bool Delete(Book book);
        List<Book> GetAll();
    }
}
