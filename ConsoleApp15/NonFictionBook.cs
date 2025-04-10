using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class NonFictionBook : Book
    {
        private string subject;

        public string Subject { get; set; }

        public NonFictionBook(int price, string author, string title, int year, string subject)
            :base(price ,author,title,year)
        {
            Subject = subject;
        }
    }
}
