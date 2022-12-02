using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp2.Wall.Assets.Classes;

namespace tp2.Marketplace.pourlemoment.Classes
{
    public class Offer
    {
        public User friend { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
