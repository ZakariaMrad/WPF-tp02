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
            comboCategory.Items.Clear();
            foreach (var item in App.Category)
            {
                comboCategory.Items.Add(item.Value);
            }
            comboCategory.SelectedIndex = 1;

            selectedCategory();
        }

        private void selectedCategory()
        {
            switch (comboCategory.SelectedIndex)
            {
                case 1:

                break;

                case 2:

                break;

                case 0:

                break;
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
