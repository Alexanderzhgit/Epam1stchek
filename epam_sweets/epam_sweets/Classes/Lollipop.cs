using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using epam_sweets.Interfaces;

namespace epam_sweets
{
    public abstract class Lollipop:ISweetItem
    {
        public abstract string Name { get; set; }
        public abstract float Sugar { get; set; }
        public abstract string Typeof { get; set; }
        public abstract int Weight { get; set; }
        public static int sweetcount = 0;

        public Lollipop ( string _type, string _name, int _weight, float _sugar) 
            {
            Typeof = _type;
            Name = _name;
            Weight = _weight;
            Sugar = _sugar;

                sweetcount++;
                Print();
            }

      

        public void Print ()
        {
            Console.WriteLine("Type of Sweet: " + Typeof);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Sugar amount: " + Sugar);
        }

    }
}
