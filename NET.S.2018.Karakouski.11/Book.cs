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

        private const string isbnFormat = @"ISBN(-1(?:(0)|3))?:?\x20+(?(1)(?(2)(?:(?=.{13}$)\d{1,5}([ -])\d{1,7}\3\d{1,6}\3(?:\d|x)$)|(?:(?=.{17}$)97(?:8|9)([ -])\d{1,5}\4\d{1,7}\4\d{1,6}\4\d$))|(?(.{13}$)(?:\d{1,5}([ -])\d{1,7}\5\d{1,6}\5(?:\d|x)$)|(?:(?=.{17}$)97(?:8|9)([ -])\d{1,5}\6\d{1,7}\6\d{1,6}\6\d$)))";

        public string ISBN
        {
            private set
            {
                if (Regex.IsMatch(value, isbnFormat))
                    isbn = value;
                else
                    throw new ArgumentException(nameof(value) + " :Incorect isbn format");
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
                    throw new ArgumentException(nameof(value) + " Incorrect year");
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
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return isbn.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
