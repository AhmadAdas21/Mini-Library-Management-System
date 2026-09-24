using System;
using Xunit;
//using Mini_Library_Management_System.services;
using Mini_Library_Management_System.models;

namespace Test_the_services_of_the_library
{
    public class UnitTest1
    {
        [Fact]
        public void is_the_books_when_borrowed_be_avalivale_or_not()
        {
            book b = new book(1, "book1", "author1", "category1");
            services s = new services(); 
            s.add_books();
            s.add_member();
            s.borrow_book();
            Assert.False(s.show_avalaible_books());
        }
    }
}