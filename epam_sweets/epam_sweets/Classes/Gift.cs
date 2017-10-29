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
        public Gift() { }
        public Gift(List<Sweet> listSweet)
        {
            foreach (Sweet sweet in listSweet)
            {
                gift.Add(sweet);
            }
        }
        private List<Sweet> gift = new List<Sweet>();
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
                double weight = 0;
                foreach (Sweet sweet in gift)
                {
                    weight += sweet.Weight;
                }
                return AllWeight;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void AddSweet(Sweet sweet)
        {
            gift.Add(sweet);
        }

        public void FindSweetBySugar(double minimalSugar, double maximalSugar)
        {
            List<Sweet> FindSweetBySugar = gift.FindAll(
                     delegate (Sweet sweet)
                        { return ((sweet.Sugar >= minimalSugar) && (sweet.Sugar <= maximalSugar)); });

            foreach (Sweet sweet in FindSweetBySugar)
            {
                Console.WriteLine(sweet.Name + " (weight: " + sweet.Weight + ", sugar: " + sweet.Sugar +")");
            }
            return FindSweetBySugar;
        }

        public void Make(List<Sweet> listSweet)
        {
            foreach (Sweet sweet in listSweet)
            {
                gift.Add(sweet);
            }
        }

        public void SortByName()
        {
            gift.Sort(delegate (Sweet sweet1, Sweet sweet2) { return sweet1.Name.CompareTo(sweet2.Name); });
        }
    }
}
