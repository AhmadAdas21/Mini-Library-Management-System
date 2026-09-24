using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Library_Management_System.models
{
   public class borrow_log
    {
        public int id { get; set; }
        public member member { get; set; }
        public book book { get; set; }
        public DateTime borrow_date { get; set; }
        public DateTime return_time { get; set; }
        public bool is_returned { get; set; }

        public borrow_log(int id,member member,book book, DateTime borrow_date, DateTime return_time, bool is_returned)
        {
            this.id = id;
            this.member = member;
            this.book = book;
            this.borrow_date = borrow_date;
            this.return_time = return_time;
            this.is_returned = is_returned;
        }
    }
}
