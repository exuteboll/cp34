using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    abstract class Book
    {
        private int price;
        private string author;
        private string title;
        private int year;

        public int Price
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }
        public string Author { get { return author; } set { author = value; } }
       
       public string Title { get { return title; } set { title = value; } }
     
        public int Year
        {
            get { return year; }
            set { if (value <= DateTime.Today.Year) year = value; }
        }

        public Book() { }
        public Book(int price, string author, string title, int year) 
        {
            Price = price;
            Author = author;
            Title = title;
            Year = year;

        }
    }
}
