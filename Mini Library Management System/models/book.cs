using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Library_Management_System.models
{
    public class book
    {
        public int id
        {
            get;set;
        }
        public string name
        {
            get;set;
        }
        public string author
        {
            get; set;
        }
        public float price
        {
            get;set;
        }
        public string category
        {
            get; set;
        }
        public bool avaliable
        {
            get; set;
        }

        public  book(int id, string name, string author, float price, string category, bool avaliable)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.price = price;
            this.category = category;
            this.avaliable = avaliable;
        }
    }
}
