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
            AddEvents();
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
                    Visible();
                    visibilityCars.Visibility = Visibility.Visible;
                    userControlVisibility.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Visible();
                    visibilityRentals.Visibility = Visibility.Visible;
                    userControlVisibility.Visibility = Visibility.Hidden;
                    break;

                case 0:
                    Visible();
                    visibilityAppliances.Visibility = Visibility.Visible;
                    userControlVisibility.Visibility = Visibility.Hidden;
                break;
            }
        }

        private void AddEvents()
        {
            comboCategory.SelectionChanged += ComboCategory_SelectionChanged;
            buttonSearch.Click += ButtonSearch_Click;
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCategory();
        }

        private void Visible()
        {
            visibilityAppliances.Visibility = Visibility.Collapsed;
            visibilityCars.Visibility = Visibility.Collapsed;
            visibilityRentals.Visibility = Visibility.Collapsed;
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
