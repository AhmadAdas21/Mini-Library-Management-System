using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Library_Management_System.models
{
    public class member:person
    {
        public string email { get; set; }
        public member(int id, string name, string email) : base(id, name)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
    }
}
