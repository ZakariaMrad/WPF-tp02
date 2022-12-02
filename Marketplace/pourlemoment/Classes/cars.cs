using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Marketplace.pourlemoment.Classes
{
    public class Cars : Offer
    {
        public string Image { get; set; }
        public string PublishDate { get; set; }
        public string CarFabricant { get; set; }
        public string CarName { get; set; }
        public int CarYear { get; set; }
        public int CarPrice { get; set; }
        public int Kilometer { get; set; }
    }
}
