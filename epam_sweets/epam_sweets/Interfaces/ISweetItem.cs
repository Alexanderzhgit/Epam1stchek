using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_sweets.Interfaces
{
   public interface ISweetItem
    {
        string Typeof { get; set; }
        string Name { get; set; }
        int Weight { get; set; }
        float Sugar { get; set; }
    }
}
