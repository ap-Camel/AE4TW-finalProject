using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WwwFinal.Classes
{
    public class User : Entity
    {
        public string name { get; set; }

        public User(int id, string name) : base(id)
        {
            this.name = name;
        }
    }
}
