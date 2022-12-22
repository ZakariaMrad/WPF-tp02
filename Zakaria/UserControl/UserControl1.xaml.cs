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
using Tp_Synthèse_B;

namespace tp2.Zakaria
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        Clothes Clothe;
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(Clothes product)
        {
            Clothe = product;

            InitializeComponent();

            updateProduct();
            addEvents();
        }

        private void updateProduct()
        {
            price.Text = Clothe.GetPrice;
            desc.Text = Clothe.Description;

            color.Items.Clear();
            foreach (var item in Clothe.ColorsImages.Keys)
                color.Items.Add(item);

            size.Items.Clear();
            foreach (var item in Clothe.Sizes)
                size.Items.Add(item);
            imageShirt.Source = Clothe.ColorsImages.Values.First();
            for (int i = 1; i < Clothe.Quantities; i++)
                qte.Items.Add(i);
            qte.SelectedIndex = 0;

        }

        private void qte_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Clothe.Quantity = qte.SelectedIndex + 1;
            price.Text = Clothe.GetPrice;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addEvents()
        {
            color.SelectionChanged += Color_SelectionChanged;
        }

        private void Color_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            imageShirt.Source = Clothe.ColorsImages[color.SelectedItem.ToString()];
        }
    }
}

