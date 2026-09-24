using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Library_Management_System.interfaces;
using Mini_Library_Management_System.models;

namespace Mini_Library_Management_System
{
    internal class services : Iservices
    {
        List<book> books = new List<book>();
        List<member>members = new List<member>();
        List<borrow_log> borrow_logs = new List<borrow_log>();
        List<person>persons= new List<person>();
        public void add_books()
        {
            Console.WriteLine("you are in adding books feature");
            int idd;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out idd))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter a valid number");
                }
                if(books.Any(x=>x.id==idd))
                {
                    Console.WriteLine("this id is already taken please enter another one");
                    return;
                }
                string name;
                Console.WriteLine("please enter the name of the book");
                name=Console.ReadLine();
                string author;
                Console.WriteLine("please enter the author of the book");
                author = Console.ReadLine();
                float price;
                while (true)
                {
                    if (float.TryParse(Console.ReadLine(), out price))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid number");
                    }
                }
                string category;
                Console.WriteLine("please enter the catageory of the book");
                category = Console.ReadLine();
                bool avaliable;
                Console.WriteLine("select 1 if available ");
                Console.WriteLine("select 2 if not available ");
                int choice;
                while (true)
                {
                    if(int.TryParse(Console.ReadLine(), out choice))
                    {
                        if (choice == 1)
                        {
                            avaliable = true;
                            break;
                        }
                        else if (choice == 2)
                        {
                            avaliable = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("please enter a valid number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid number");
                    }
                }

                book b = new book(idd, name, author, price, category, avaliable);
                books.Add(b);


            }
        }
        public void view_books()
        {
            Console.WriteLine("you are in view books feature");
            books.ForEach(books => Console.WriteLine($"id: {books.id} name: {books.name} author: {books.author} price: {books.price} category: {books.category} avaliable: {books.avaliable}"));

        }
        public void show_books_by_id()
        {
            Console.WriteLine("you are in show books by id feature");
            int iddd;
            while (true)
            {
                if ((int.TryParse(Console.ReadLine(), out iddd)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter a valid number");
                }
            }
            if (books.Any(x => x.id == iddd))
            {
                books.Where(x => x.id == iddd).ToList().ForEach(x =>
                {
                    Console.WriteLine($"id: {x.id} name: {x.name} author: {x.author} price: {x.price} category: {x.category} avaliable: {x.avaliable}");
                });
            }
            else
            {
                Console.WriteLine("the book for this id is not avalvable");
            }
        }
        public void add_member()
        {
            Console.WriteLine("you are in add member feature");
            int idd;
            Console.WriteLine("enter the id of the member");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out idd))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter a valid number");
                }
            }
            Console.WriteLine("write the name of the member");
            string name = Console.ReadLine();
            Console.WriteLine("write the eamil for the member");
            string email;
            email = Console.ReadLine();
            if (email != null && name!=null &&idd!=null)
            {
                member m = new member(idd, name, email);
                members.Add(m);
            }
            else
            {
                Console.WriteLine("enter valid values");
            }


        }
        public void view_members()
        {
            Console.WriteLine("you are in vieww all members feature");
            members.ForEach(x => Console.WriteLine($"id: {x.id} name: {x.name} email: {x.email}"));
        }
        public void borrow_book()
        {
            Console.WriteLine("you are in the borrow books farute");
            Console.WriteLine("enter th id of the log");
            int idd;
            while (true)
            {
               if(int.TryParse(Console.ReadLine(), out idd))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter a valid number");
                }
            }
            if (borrow_logs.Any(x => x.id == idd))
            {
                Console.WriteLine("this id is already taken please enter another one");
                return;
            }
            Console.WriteLine("enter the id of the member");
            int member_id;
            while (true)
            {
                if ((int.TryParse(Console.ReadLine(), out member_id)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("enter valid value");
                }
            }
            if(!members.Any(x => x.id == member_id))
            {
                Console.WriteLine("this member is not avalvable");
                return;
            }
           
            if (members.Any(x => x.id == member_id))
            {
                var m= members.Where(x => x.id == member_id).FirstOrDefault();
                DateTime borrow_date = DateTime.Now;
                DateTime return_time = borrow_date.AddDays(20);
                bool returned = false;
                Console.WriteLine("enter the id of the book");
                int bo;
                while (true)
                {
                    if(int.TryParse(Console.ReadLine(), out bo))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter a valid number");
                    }
                }
                if (books.Any(x => x.id == bo))
                {
                    var boo=books.Where(x => x.id == bo).FirstOrDefault();
                    borrow_log b = new borrow_log(idd, m, boo, borrow_date, return_time, returned);
                    borrow_logs.Add(b);
                }
                else
                {
                    Console.WriteLine("this book is not avalvable");
                }



            }
            else
            {
                Console.WriteLine("this member isnt avaliable");

            }
        }
        public void return_book()
        {
            Console.WriteLine("you are in the return books feature");
            Console.WriteLine("enter the id of the log");
            int idd;
            while ((true))
            {
                if(int.TryParse(Console.ReadLine(), out idd))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter a valid number");
                }
            }

            if (borrow_logs.Any(x => x.id == idd))
            {
                var c=borrow_logs.Where(x => x.id == idd).FirstOrDefault();
                c.is_returned = true;
               // borrow_logs.Add(c);
            }
            else
            {
                Console.WriteLine("the id enterd is not correct");
            }


        }
        public void show_avalaible_books()
        {
            Console.WriteLine("you are in show avaliable books feature");
            var avi= books.Where(x => x.avaliable == true).ToList();
            if (avi.Count > 0)
            {
                avi.ForEach(x => Console.WriteLine($"id: {x.id} name: {x.name} author: {x.author} price: {x.price} category: {x.category} avaliable: {x.avaliable}"));
            }
            else
            {
                Console.WriteLine("there is no avaliable books");
            }
            Console.WriteLine("thanks for using this feature");

        }
        public void show_borrowed_books()
        {
            Console.WriteLine("ypu are in borrowed books feature");
            var bo = borrow_logs.Where(x => x.is_returned == false).ToList();
            if (bo.Count > 0)
            {
                bo.ForEach (x => Console.WriteLine($"id: {x.id} member: {x.member.name} book: {x.book.name} borrow date: {x.borrow_date} return time: {x.return_time} is returned: {x.is_returned}")) ;
            }
            else
            {
                Console.WriteLine("thers no borrowed books");
            }

        }
        public void filter_books_by_category()
        {
            Console.WriteLine("you are in filter books by category");
            Console.WriteLine("please enter the categorey you want to filter by");
            string c = Console.ReadLine();
            var filtered = books.Where(x => x.category == c).ToList();
            if (filtered.Count() != 0) { 
            filtered.ForEach(x => Console.WriteLine($"id: {x.id} name: {x.name} author: {x.author} price: {x.price} category: {x.category} avaliable: {x.avaliable}"));
            }
            else
            {
                Console.WriteLine("theres no books in this category");
            }
        }
        public void sort_books_desc()
        {
            Console.WriteLine("you are in sort books byy price desc feature");
            var c = books.OrderByDescending(x => x.price).ToList();
            c.ForEach(x => Console.WriteLine($"id: {x.id} name: {x.name} author: {x.author} price: {x.price} category: {x.category} avaliable: {x.avaliable}"));
            /*
             * foreach(var i in c){
             * console.writeline($"id:{i.id} name:{i.name}price:{i.price});
             * }
             * 
             * 
             * 
             * */
        }
        public void show_library_statistics()
        {
            Console.WriteLine("you are in library stetics view");
            Console.WriteLine("the books in the libraty:");
            Console.WriteLine(books.Count);
            Console.WriteLine("the count of subscribed members in the library");
            Console.WriteLine(members.Count);
            Console.WriteLine("the number of books that borrowed are");
            Console.WriteLine(borrow_logs.Count);

        }
    }
}
