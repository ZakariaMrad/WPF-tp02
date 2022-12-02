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
            InitializeComboBoxMaker();
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

        private void InitializeComboBoxMaker()
        {

            List<string> disctintBrands = new List<string>();
            Maker.Items.Clear();
            string lastEntered = "";
            foreach (var dictionnary in App.cars.Values)
            {
                if (lastEntered != dictionnary.CarFabricant)
                {
                    disctintBrands.Add(dictionnary.CarFabricant);
                    lastEntered = dictionnary.CarFabricant;
                }
            }

         
           
            disctintBrands = disctintBrands.Distinct().ToList();

            foreach (var item in disctintBrands)
            {
                Maker.Items.Add(item);
            }
           

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
            wrap.Children.Clear();
            if (radioButtonDate.IsChecked == true)
            SortDate();
            if (radioButtonPrice.IsChecked == true)
            SortAllByPrice();
            if (priceStart.Text != "" || priceEnd.Text != "")
            SortByPrice();

            
        }

        private void SortByPrice()
        {
            if(priceEnd.Text != "")
            {
                string PrixFin = priceEnd.Text;

                if (priceStart.Text != "")
                {
                    string PrixDebut = priceStart.Text;
                }



            }

            if (priceStart.Text != "")
            {
                string PrixDebut = priceStart.Text;

                if (priceEnd.Text != "")
                {
                    string PrixFin = priceStart.Text;
                }


            }


        }

        private void SortAllByPrice()
        {
            var cars = App.cars.Values.OrderBy(x => x.CarPrice);
            foreach (var item in cars)
            {
                wrap.Children.Add(new UserControlMarketPlace(item));
            }
        }

        private void SortDate()
        {
            var cars = App.cars.Values.OrderByDescending(x => x.CarYear);
            foreach (var item in cars)
            {
                wrap.Children.Add(new UserControlMarketPlace(item));
            }
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
