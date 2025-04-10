using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Library
    {
        public List<FictionBook> fictionbook = new List<FictionBook>();
        public List<NonFictionBook> nonFictionBooks = new List<NonFictionBook>();
        public List<Textbook> textbooks = new List<Textbook>();

        public void AddFictionBook()
        {
            int price = 0, year = 0;
            string title = "";
            string author = "";
            string genre = "";
            Console.Write("Введите цену: ");
            try
            {
                price = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Введите название книги:");
            try
            {
                title = Convert.ToString(Console.ReadLine());
            }
            catch { }
            Console.Write("Введите автора:");
            try
            {
                author = Console.ReadLine();
            }
            catch { }
            Console.Write("Введите жанр:");
            try
            {
                genre = Console.ReadLine();
            }
            catch { }
            fictionbook.Add(new FictionBook(price, author, title, year, genre));
        
        }
        public void AddNonFictionBook()
        {
            int price = 0, year = 0;
            string title = "";
            string author = "";
            string subject = "";
            Console.Write("Введите цену: ");
            try
            {
                price = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Введите название книги:");
            try
            {
                title = Convert.ToString(Console.ReadLine());
            }
            catch { }
            Console.Write("Введите автора:");
            try
            {
                author = Console.ReadLine();
            }
            catch { }
            Console.Write("Введите Предмет на который книга ориентирована:");
            try
            {
                subject = Console.ReadLine();
            }
            catch { }
            nonFictionBooks.Add(new NonFictionBook(price, author, title, year, subject));
        }
        public void TextBook()
        {
            int price = 0, year = 0;
            string title = "";
            string author = "";
            string gradelevel = "";
            Console.Write("Введите цену: ");
            try
            {
                price = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.Write("Введите название книги:");
            try
            {
                title = Convert.ToString(Console.ReadLine());
            }
            catch { }
            Console.Write("Введите автора:");
            try
            {
                author = Console.ReadLine();
            }
            catch { }
            Console.Write("Введите Предмет на который книга ориентирована:");
            try
            {
                gradelevel = Console.ReadLine();
            }
            catch { }
            textbooks.Add(new Textbook(price, author, title, year, gradelevel));
        }
        public void GetFictionBook()
        {
            foreach( FictionBook fictionBook in fictionbook)
            {
                Console.WriteLine($"Цена: {fictionBook.Price}\tАвтор{");
            }
            
        }
    }
}
