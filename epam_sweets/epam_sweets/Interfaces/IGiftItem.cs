using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_sweets.Interfaces
{
    interface IGiftItem
    {
        int AllWeight { get; set; }
        int AllSugar{ get; set; }
        void SortByName();
        void AddSweet(Sweet sweet);
        void Make(List<Sweet> listSweet);
        void FindSweetBySugar(double minimalSugar, double maximalSugar);
    }
}
