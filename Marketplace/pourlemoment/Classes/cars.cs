using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Marketplace.pourlemoment.Classes
{
    public class Cars
    {
        public string Image { get; set; }
        public string PublishDate { get; set; }
        public string CarFabricant { get; set; }
        public string Brand { get; set; }
        public int CarYear { get; set; }
        public int CarPrice { get; set; }
        public int Kilometer { get; set; }

        public Cars(string image, string publishDate, int carPrice, string carFabricant,string brand, int carYear, int kilometer)
        {
            Image = image;
            PublishDate = publishDate;
            CarFabricant = carFabricant;
            CarYear = carYear;
            CarPrice = carPrice;
            Brand = brand;
            Kilometer = kilometer;
        }
    }
}
