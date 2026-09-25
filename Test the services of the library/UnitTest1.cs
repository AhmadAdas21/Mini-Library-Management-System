using System;
using Xunit;
//using Mini_Library_Management_System.services;
using Mini_Library_Management_System;
using Mini_Library_Management_System.models;
//using Mini_Library_Management_System.models;

namespace Test_the_services_of_the_library
{
    public class UnitTest1
    {
        List<book> books = new List<book>();
        List<member> members = new List<member>();
        List<borrow_log> borrow_logs = new List<borrow_log>();
        [Fact]
        public void is_the_books_when_borrowed_be_avalivale_or_not()
        {
            services s = new services();

            book b = new book(1,"book1","author1",20,"category1",true);

            books.Add(b);

           
            Assert.True(b.avaliable);

            
            b.avaliable = false;

            var result = s.get_avalaible_books();

           
            
            Assert.False(b.avaliable);

           
            Assert.DoesNotContain(result, x => x.id == b.id);
        }
    }
}