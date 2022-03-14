using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WwwFinal.Classes
{
    public class Product : Entity
    {
        public int price { get; set; }
        
        public Product(int id, int price) : base(id)
        {
            this.price = price;
        }

    }
}
