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
using tp2.Wall.Assets.Classes;

namespace tp2.Wall
{
    /// <summary>
    /// Logique d'interaction pour mainW.xaml
    /// </summary>
    public partial class mainW : Window
    {

        public mainW()
        {
            InitializeComponent();
            App.initMain();


            displayByGroup();
        }

        private void displayByGroup()
        {
            PostsStack.Children.Clear();
            foreach (var item in App.mainGroup.Posts)
            {
                PostsStack.Children.Add(new UserControlPost(item));
            }
        }
    }
}
