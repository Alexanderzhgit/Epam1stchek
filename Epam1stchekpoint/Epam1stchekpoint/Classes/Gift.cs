using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam1stchekpoint.Classes
{
    class Gift : IGift
    {
        public IEnumerable<Sweet> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Add(Sweet sweets)
        {
            Items.Add(sweets);
        }

        public IEnumerable<Sweet> Find(int min, int max)
        {
            throw new NotImplementedException();
        }

        public void FindThis(int min, int max)
        {
            return Items.Where(x => (x.sugar >= min) && (x.sugar <= max)).ToList();
        }                   

        public int GiftWeight()
        {
            return Items.Sum(x => x.weight);
        }

        public void ShowThis()
        {
           
        }

        public void Sorting()
        {
            throw new NotImplementedException();
        }
    }
}
