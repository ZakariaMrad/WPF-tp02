using System;
using System.Collections.Generic;

namespace Tp_Synthèse_B
{
    public class Basket 
    {
        public int Id { get; set; }
        public List<KeyValuePair<int, Product>> Products { get; set; } //int will be the product quantity
        public Double TotalPrice { get; set; }

        static double taxes = 0.0015;
    }
}
