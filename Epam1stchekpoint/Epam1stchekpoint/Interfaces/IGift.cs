using Epam1stchekpoint.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam1stchekpoint
{
    interface IGift
    {
        IEnumerable<Sweet> Items { get; }
        int GiftWeight();
        void Sorting();
        void ShowThis();
        IEnumerable<Sweet> Find(int min, int max);
        void FindThis(int min, int max);
        void Add(Sweet sweets);

    }
}
