using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_sweets
{
    public class Sweets
    {
        public string Type;
        public string Name;
        public int Weight;
        public float Sugar;
        public static int sweetcount = 0;

        public Sweets () 
            {
                Type = "Lolipop";
                Name = "FlashSweet";
                Weight = 5;
                Sugar = 0.2f;
                sweetcount++;
                Print();
            }
        public void Print ()
        {
            Console.WriteLine("Type of Sweet: " + Type);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Sugar amount: " + Sugar);
        }

    }
}
