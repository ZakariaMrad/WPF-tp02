using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Linq;
using tp2;

namespace Tp_Synthèse_B
{
    public class Clothes : Product
    {
        public Dictionary<string, BitmapImage> ColorsImages { get; set; }
        public List<string> Sizes { get; set; }
        public Clothes(int id, string name, string description, double price, Dictionary<string, string> colorsImages, List<string> sizes, int quantities) : base(id, name, description, price, quantities)
        {
            Sizes = sizes;
            ColorsImages = new Dictionary<string, BitmapImage>();
            foreach (var color in colorsImages)
                ColorsImages.Add(color.Key, new BitmapImage(App.getURIZ(color.Value)));
        }
    }
}