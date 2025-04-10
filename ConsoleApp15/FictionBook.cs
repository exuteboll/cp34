using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class FictionBook : Book
    {
        private string genre;

        public string Genre { get; set; }

        public FictionBook(int price, string author, string title, int year, string genre)
            :base(price, author,title,year)
        {
            Genre = genre;
        }
    }
}
