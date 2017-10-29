using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using epam_sweets.Classes;
using epam_sweets.Interfaces;

namespace epam_sweets
{
    public abstract class Sweet:ISweetItem
    {
        public abstract string Name { get; set; }
        public abstract float Sugar { get; set; }
        public abstract int Weight { get; set; }
        public static int sweetcount = 0;

        public Sweet(string _type, string _name, int _weight, float _sugar)
        {
            Name = _name;
            Weight = _weight;
            Sugar = _sugar;
        }

        public abstract void Print();

        public static implicit operator Sweet(LollipopSweet v)
        {
            throw new NotImplementedException();
        }
    }
}
