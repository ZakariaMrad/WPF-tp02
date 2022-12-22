using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Tp_Synthèse_B;

namespace tp2.Zakaria
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static List<Clothes> products = new List<Clothes>() { App.Products[0], App.Products[1] };
        public Window1()
        {
            InitializeComponent();



            foreach (var item in products)
            {
                UserControl1 element = new UserControl1(item);
                items.Children.Add(element);
                element.DeleteButton.Click += DeleteButton_Click;
                element.DeleteButton.CommandParameter = item.Id;
            }


        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string val = button.CommandParameter.ToString();
            Trace.WriteLine(val);
            products.RemoveAll(x => x.Id.ToString() == val);
        }
    }
}
