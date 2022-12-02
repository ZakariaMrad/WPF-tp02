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
            InitializeComboBoxBrand();
            AddEvents();
        }

        private void InitializeComboBoxBrand()
        {
            brand.Items.Clear();
            brand.Items.Add("All");

            foreach (var item in App.Current.cars.Values.Select(a => a.CarName).Distinct())
            {
                brand.Items.Add(item);
            }
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
            Maker.Items.Clear();
            Maker.Items.Add("All");

            foreach (var item in App.Current.cars.Values.Select(a => a.CarFabricant).Distinct())
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
            if (Maker.SelectedIndex != -1)
            SortByMaker();
            if (brand.SelectedIndex != -1)
            SortByBrand();
            if (yearEnd.Text != "" || yearStart.Text != "")
                SortByYear();
            if (kiloStart.Text != "" || kiloEnd.Text != "")
                SortByKilometer();

            clearAllEvents();

            
        }

        private void SortByKilometer()
        {
            int KiloDebut = int.MinValue;
            int KiloFin = int.MaxValue;

            if (kiloStart.Text != "")
            {
                int.TryParse(kiloStart.Text, out KiloDebut);
            }

            if (kiloEnd.Text != "")
            {
                int.TryParse(kiloEnd.Text, out KiloFin);
            }


            var priceInMiddle = App.Current.cars.Values.Where(a => a.Kilometer >= KiloDebut && a.Kilometer <= KiloFin);

            foreach (var item in priceInMiddle)
            {
                wrap.Children.Add(new UserControlMarketPlace(item));
            }
        }

        private void SortByYear()
        {
            int anneeDebut = int.MinValue;
            int anneeFin = int.MaxValue;

            if (yearStart.Text != "")
            {
                int.TryParse(yearStart.Text, out anneeDebut);
            }

            if (yearEnd.Text != "")
            {
                int.TryParse(yearEnd.Text, out anneeFin);
            }


            var priceInMiddle = App.Current.cars.Values.Where(a => a.CarYear >= anneeDebut && a.CarYear <= anneeFin);

            foreach (var item in priceInMiddle)
            {
                wrap.Children.Add(new UserControlMarketPlace(item));
            }
        }

        private void SortByBrand()
        {
            string selectionBrand = brand.Text;

            if (selectionBrand == "All")
            {
                foreach (var item in App.Current.cars.Values)
                {
                    wrap.Children.Add(new UserControlMarketPlace(item));
                }
            }
            else
            {
                var cars = App.Current.cars.Values.Where(a => a.CarName == selectionBrand);
                foreach (var item in cars)
                {
                    wrap.Children.Add(new UserControlMarketPlace(item));
                }
            }
        }

        private void SortByMaker()
        {
            string selectionFabricant = Maker.Text;

            if (selectionFabricant == "All")
            {
                foreach (var item in App.Current.cars.Values)
                {
                    wrap.Children.Add(new UserControlMarketPlace(item));
                }
            }
            else
            {
                var cars = App.Current.cars.Values.Where(a => a.CarFabricant == selectionFabricant);
                foreach (var item in cars)
                {
                    wrap.Children.Add(new UserControlMarketPlace(item));
                }
            }
        }

        private void clearAllEvents()
        {
            radioButtonDate.IsChecked = false;
            radioButtonPrice.IsChecked = false;
            priceEnd.Text = "";
            priceStart.Text = "";
            Maker.SelectedIndex = -1;
            brand.SelectedIndex = -1;
            yearStart.Text = "";
            yearEnd.Text = "";
            kiloEnd.Text = "";
            kiloStart.Text = "";
        }

        private void SortByPrice()
        {
                int prixFin =  int.MaxValue;
                int prixDebut = int.MinValue;

                if (priceStart.Text != "")
                {
                    int.TryParse(priceStart.Text,out prixDebut);
                }

                if (priceEnd.Text != "")
                {
                    int.TryParse(priceEnd.Text,out prixFin);
                }


            var priceInMiddle = App.Current.cars.Values.Where(a => a.CarPrice >= prixDebut && a.CarPrice <= prixFin);

            foreach (var item in priceInMiddle)
            {
                wrap.Children.Add(new UserControlMarketPlace(item));
            }


        }

        private void SortAllByPrice()
        {
            var cars = App.Current.cars.Values.OrderBy(x => x.CarPrice);
            foreach (var item in cars)
            {
                wrap.Children.Add(new UserControlMarketPlace(item));
            }
        }

        private void SortDate()
        {
            var cars = App.Current.cars.Values.OrderByDescending(x => x.CarYear);
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
            foreach (var item in App.Current.cars.Values)
            {
                wrap.Children.Add(new UserControlMarketPlace(item)) ;
            }
        }
    }
}
