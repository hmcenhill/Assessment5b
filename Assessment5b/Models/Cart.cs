using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5b.Models
{
    public class Cart
    {
        public int Item1 { get; set; }
        public int Item2 { get; set; }
        public int Item3 { get; set; }
        public Cart()
        {
            Item1 = 0; Item2 = 0; Item3 = 0;
        }

    }
}
