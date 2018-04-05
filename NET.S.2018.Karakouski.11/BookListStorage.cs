using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NET.S._2018.Karakouski._11
{
    class BookListStorage : IBookStorage
    {

        public void Create(Book book)
        {
            string serializedBook = JsonConvert.SerializeObject(book);

            using (FileStream fileStream = File.Open("books.data", FileMode.Append))
            {
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(serializedBook);
            }

        }

        public void Delete(Book book)
        {
            List<Book> books = new List<Book>();
            books = GetAll();
            var results = books.Where(b => b != book).ToList();
            foreach (Book b in results)
            {
                Create(book);
            }
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            Book tempBook;
            string serializedBook;

            using (FileStream fileStream = File.Open("books.data", FileMode.Open))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);

                try
                {
                    while (true)
                    {
                        serializedBook = binaryReader.ReadString();
                        tempBook = JsonConvert.DeserializeObject<Book>(serializedBook);
                        books.Add(tempBook);
                    }
                }
                catch (EndOfStreamException)
                {
                    return books;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Update(Book book)
        {
            List<Book> books = new List<Book>();
            books = GetAll();
            int index = books.FindIndex(b => b == book);
            if (index > 0)
                books[index] = book;
            foreach (Book b in books)
            {
                Create(book);
            }
        }

        public bool IsBookExists(Book desiredBook)
        {
            string serializedBook;
            Book tempBook;

            using (FileStream fileStream = File.Open("books.data", FileMode.Open))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);

                try
                {
                    while (true)
                    {
                        serializedBook = binaryReader.ReadString();
                        tempBook = JsonConvert.DeserializeObject<Book>(serializedBook);
                        if (tempBook == desiredBook)
                            return true;
                    }
                }
                catch(EndOfStreamException)
                {
                    return false;
                }
                catch(Exception)
                {
                    throw;
                }

            }
        }
    }
}
