using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Library_Management_System.models;

namespace Mini_Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;
            while (ok)
            {
                Console.WriteLine("Welcome to the Mini Library Management System");
                Console.WriteLine("1. add Books");
                Console.WriteLine("2. view books");
                Console.WriteLine("3. search book by id or title");
                Console.WriteLine("4. add member");
                Console.WriteLine("5. view all members");
                Console.WriteLine("6. borrow book");
                Console.WriteLine("7. return book");
                Console.WriteLine("8. show avalable books");
                Console.WriteLine("9. show borrowed books");
                Console.WriteLine("10 filter books by category");
                Console.WriteLine("11 sort book by most expensive");
                Console.WriteLine("12 show libray statics ");
                Console.WriteLine("13. exit");
                Console.WriteLine("Enter your choice: ");
                int c;
                services s= new services();
                
                if (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("invalid input. please enter a number.");
                    continue;
                }
                switch (c)
                {
                    case 1:s.add_books();break;
                    case 2:s.view_books(); break;
                    case 3: s.show_books_by_id(); break;
                    case 4: s.add_member(); break;
                    case 5: s.view_members(); break;
                    case 6: s.borrow_book(); break;
                    case 7: s.return_book(); break;
                    case 8: s.show_avalaible_books(); break;
                    case 9: s.show_borrowed_books(); break;
                    case 10: s.filter_books_by_category(); break;
                    case 11: s.sort_books_desc(); break;
                    case 12: s.show_library_statistics(); break;
                    case 13:Console.WriteLine("thanks to use our system"); ok = false; break;
                }
            }
        }
    }
}
