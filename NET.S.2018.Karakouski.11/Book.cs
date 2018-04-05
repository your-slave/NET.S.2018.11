using System;
using System.Text.RegularExpressions;

namespace NET.S._2018.Karakouski._11
{
    /// <summary>
    /// Book class
    /// </summary>
    public class Book : IComparable
    {
        private string isbn;
        private int year;
        private int numberOfpages;
        private decimal price;

        public string Author { get; private set; }
        public string Name { get; private set; }
        public string Publisher { get; private set; }

        private const string isbnFormat = @"^(?:ISBN(?:-13)?:? )?(?=[0-9]{13}$|(?=(?:[0-9]+[- ]){4})[- 0-9]{17}$)97[89][- ]?[0-9]{1,5}[- ]?[0-9]+[- ]?[0-9]+[- ]?[0-9]$";
        public string ISBN
        {
            private set
            {
                if (Regex.IsMatch(value, isbnFormat))
                    isbn = value;
                else
                    throw new ArgumentException(nameof(value) + ": Incorect isbn format");
            }
            get
            {
                return isbn;
            }
        }

        public int Year
        {
            private set
            {
                if (value < 2001 || value > DateTime.Today.Year)
                    throw new ArgumentException(nameof(value) + ": Incorrect year");
                year = value;

            }
            get
            {
                return year;
            }
        }

        public int NumberOfPages
        {
            private set
            {
                if (value < 0)
                    throw new ArgumentException(nameof(value) + " Incorrect number of pages");
                numberOfpages = value;

            }
            get
            {
                return numberOfpages;
            }
        }

        public decimal Price
        {
            private set
            {
                if (value < 0)
                    throw new ArgumentException(nameof(value) + " Incorrect number of pages");
                price = value;

            }
            get
            {
                return price;
            }
        }

        public Book(string isbn, string author, string name, string publisher, int year, int nummberOfPages, decimal price)
        {
            ISBN = isbn;
            Author = author;
            Name = name;
            Publisher = publisher;
            Year = year;
            NumberOfPages = numberOfpages;
            Price = price;
            
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Book otherBook = obj as Book;
            if (otherBook != null)
                return isbn.CompareTo(otherBook.isbn);
            else
                throw new ArgumentException("Object is not a Book");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Book otherBook = obj as Book;
            if (otherBook == null)
                return false;

            return isbn == otherBook.isbn;
        }

        public override int GetHashCode()
        {
            return isbn.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Book a, Book b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if ((object)a == null || (object)b == null)
                return false;

            return a.isbn == b.isbn;
        }

        public static bool operator !=(Book a, Book b)
        {
            return !(a == b);
        }


        public static bool operator >(Book a, Book b)
        {
            if (ReferenceEquals(a, b))
                return false;

            if ((object)a == null || (object)b == null)
                return false;

            if (String.Compare(a.isbn, b.isbn) > 0)
                return true;

            return false;
        }

        public static bool operator <(Book a, Book b)
        {
            if (ReferenceEquals(a, b))
                return false;

            if ((object)a == null || (object)b == null)
                return false;

            if (String.Compare(a.isbn, b.isbn) < 0)
                return true;

            return false;
        }

        public string ToString(String format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}
