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

namespace tp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openMarketplace(object sender, RoutedEventArgs e)
        {
            Window window = new tp2.Marketplace.mainMP();
            window.Show();
            Close();
        }
        private void openWall(object sender, RoutedEventArgs e)
        {
            Window window = new tp2.Wall.mainW();
            window.Show();
            Close();
        }

        private void openZakaria(object sender, RoutedEventArgs e)
        {
            Window window = new Zakaria.Window1();
            window.Show();
            Close();
        }

        private void openJeremy(object sender, RoutedEventArgs e)
        {
            Window window = new partieB___jeremy.Cinema();
            window.Show();
            Close();
        }
    }
}
