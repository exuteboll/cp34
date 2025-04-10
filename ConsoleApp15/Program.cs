using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                int i = 0;
                Console.WriteLine(@"Выберите нужное вам действиe:
                1. Добавить Худ.Книгу
                2. Добавить не Худ.Книгу
                3. Добавить учебник
                4. Показать Худ.Книги
                5. Показать не Худ.Книги
                6. Показать учебники
                7. Выход");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                switch (i)
                {
                    case 1: library.AddFictionBook(); break;
                    case 2: library.AddNonFictionBook(); break;
                    case 3: library.AddTextBook(); break;
                    case 4: Console.WriteLine("Художественные кники:"); library.GetFictionBook(); break;
                    case 5: Console.WriteLine("Не худ книги:"); library.GetNonFictionBook(); break;
                    case 6: Console.WriteLine("Учебники:"); library.GetTextBook(); break;
                    case 7: return;
                    default: Console.WriteLine(""); break;
                }
            }
            Console.Read();
        }
    }
}
