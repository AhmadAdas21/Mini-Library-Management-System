using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Library_Management_System.models
{
    public class person
    {
        public int id { get; set;
        }
        public string name { get; set; }
        public person(int id,string name)
        {
            this.name = name;
            this.id = id;
        }
    }
}
