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
using tp2.Wall.Assets.Classes;

namespace tp2.Wall
{
    /// <summary>
    /// Logique d'interaction pour UserControlcontent.xaml
    /// </summary>
    public partial class UserControlcontent : UserControl
    {
        public UserControlcontent()
        {
            InitializeComponent();
        }
        public UserControlcontent(Content content)
        {
            InitializeComponent();
            Title.Text = "test";
            Date.Text = content.DateTime.ToString();
            Content.Text = content.Text;
        }
    }
}
