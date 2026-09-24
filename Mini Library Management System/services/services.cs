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

            Console.WriteLine("enter the id of the member");
            int member_id;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out member_id))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter a valid number");
                }
            }
            if(!members.Any(x => x.id == member_id))
            {
                Console.WriteLine("this member is not avalvable");
                return;
            }


        }
        public void show_avalaible_books()
        {

        }
        public void show_borrowed_books()
        {

        }
        public void filter_books_by_category()
        {

        }
        public void sort_books_desc()
        {

        }
        public void show_library_statistics()
        {

        }
    }
}
