using epam_sweets.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_sweets
{
   public class Program
    {
        static void Main(string[] args)
        {
            Gift Gift = new Gift();

            Sweet sweet1 = new LollipopSweet("Flash", 0.50, 0.044);
            Sweet sweet2 = new LollipopSweet("ReverseFlash", 0.60, 0.080);

            Sweet sweet3 = new ChokolateSweet("Iris", 0.300, 0.050);
            Sweet sweet4 = new ChokolateSweet("Ronny", 0.700, 0.100);



            Console.ReadKey();
        }
    }
}
