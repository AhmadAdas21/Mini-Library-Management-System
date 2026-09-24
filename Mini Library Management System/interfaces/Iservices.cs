using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Library_Management_System.interfaces
{
   public interface Iservices
    {
         void add_books();
         void view_books();
         void show_books_by_id();
         void add_member();
         void view_members();
         void borrow_book();
         void return_book();
         void show_avalaible_books();
         void show_borrowed_books();
         void filter_books_by_category();
         void sort_books_desc();
         void show_library_statistics();
    }
}
