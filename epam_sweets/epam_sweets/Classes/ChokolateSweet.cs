using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using epam_sweets.Classes;

namespace epam_sweets.Classes
{
    public class ChokolateSweet:Sweet
    {
        private string v1;
        private double v2;
        private double v3;

        public ChokolateSweet(string v1, double v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public ChocolateSweet(string name, double weight, double sugar);


        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
