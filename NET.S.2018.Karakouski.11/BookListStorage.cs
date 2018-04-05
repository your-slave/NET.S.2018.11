using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace NET.S._2018.Karakouski._11
{
    class BookListStorage : IBookStorage
    {

        public bool Create(Book book)
        {
            string serializedBook = JsonConvert.SerializeObject(book);

            throw new NotImplementedException();
        }

        public bool Delete(Book book)
        {
            string serializedBook = JsonConvert.SerializeObject(book);

            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            var r = new BinaryReader(s);
            Name
            = r.ReadString();
            Age
            = r.ReadInt32();
            Height = r.ReadDouble();


            throw new NotImplementedException();
        }

        public bool Update(Book book)
        {
            string serializedBook = JsonConvert.SerializeObject(book);

            throw new NotImplementedException();
        }
    }
}
