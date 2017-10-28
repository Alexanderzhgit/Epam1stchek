using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_sweets
{
    public abstract class Sweets
    {
        public string Typeof { get; private set; }
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public float Sugar { get; private set; }
        public static int sweetcount = 0;

        public Sweets ( string _type, string _name, int _weight, float _sugar) 
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
