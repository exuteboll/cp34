using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Textbook : Book
    {
        private string gradelevel;
        public string Gradelevel { get; set; }

        public Textbook(int price, string author, string title, int year, string gradelevel)
            :base(price,author,title,year)
        {
            Gradelevel = gradelevel;
        }
    }
}
