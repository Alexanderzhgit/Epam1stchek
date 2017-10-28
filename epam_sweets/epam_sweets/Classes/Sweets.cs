using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_sweets
{
    public class Sweets
    {
        public string Name;
        public int Weight;
        public float Sugar;
        public static int sweetcount = 0;

        public Sweets () 
            {
                Name = "Lolipop";
                Weight = 5;
                Sugar = 0.2f;
                sweetcount++; 
            }


    }
}
