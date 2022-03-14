using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WwwFinal.Classes
{
    public class Entity
    {
        public int ID { get; set; }


        public Entity(int id)
        {
            ID = id;
        }

        public int getID()
        {
            return ID;
        }
    }
}
