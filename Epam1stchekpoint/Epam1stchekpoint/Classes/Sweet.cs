using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam1stchekpoint.Classes
{
    class Sweet
    {
        public string type { get; private set; }
        public int sugar { get; private set; }
        public int weight { get; private set; }

        public Sweet(string sweetType, int sweetSugar, int sweetWeight)
        {
            this.type = sweetType;
            this.sugar = sweetSugar;
            this.weight = sweetWeight;
        }
    }
}
