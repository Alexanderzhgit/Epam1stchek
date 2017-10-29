using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using epam_sweets.Interfaces;

namespace epam_sweets.Classes
{
    class Gift : IGiftItem
    {
        public int AllSugar
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int AllWeight
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void AddSweet(Sweet sweet)
        {
            throw new NotImplementedException();
        }

        public void FindSweetBySugar(double minimalSugar, double maximalSugar)
        {
            throw new NotImplementedException();
        }

        public void Make(List<Sweet> listSweet)
        {
            throw new NotImplementedException();
        }

        public void SortByName()
        {
            throw new NotImplementedException();
        }
    }
}
