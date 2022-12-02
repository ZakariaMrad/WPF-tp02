using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using tp2.Marketplace.pourlemoment.Classes;

namespace tp2.Marketplace
{
    /// <summary>
    /// Logique d'interaction pour UserControlMarketPlace.xaml
    /// </summary>
    public partial class UserControlMarketPlace : UserControl
    {
        Cars Car;
        public UserControlMarketPlace(Cars car)
        {
            Car = car;
            InitializeComponent();
            InitializeImages();
        }

        public UserControlMarketPlace()
        {
            InitializeComponent();
        }


        private void InitializeImages()
        {
            ProductImage.Source = new BitmapImage(App.GetUri2(Car.Image));
            price.Text = Car.CarPrice.ToString() + "$";
            ProductDate.Text = Car.PublishDate.ToString();
            string textYearMarque = Car.CarYear.ToString() + " " + Car.CarFabricant.ToString() +" "+ Car.CarName.ToString();
            ProductName.Text = textYearMarque;
            kilometer.Text = Car.Kilometer.ToString() + "k km";
        }
    }
}
