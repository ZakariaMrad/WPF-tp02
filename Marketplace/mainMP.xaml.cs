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
using System.Windows.Shapes;

namespace tp2.Marketplace
{
    /// <summary>
    /// Logique d'interaction pour mainMP.xaml
    /// </summary>
    public partial class mainMP : Window
    {
        
        public mainMP()
        {
            InitializeComponent();
            InitializeCars();
            InitializeComboBox();

        }

        private void InitializeComboBox()
        {
            foreach (var item in collection)
            {

            }
        }

        private void InitializeCars()
        {
            foreach (var item in App.cars.Values)
            {
                wrap.Children.Add(new UserControlMarketPlace(item)) ;

            }
        }
    }
}
