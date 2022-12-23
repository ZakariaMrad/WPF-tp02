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
using tp2.partieB___jeremy.Assets.Classe;

namespace tp2.partieB___jeremy.userControl
{
    /// <summary>
    /// Interaction logic for UserControlCart.xaml
    /// </summary>
    public partial class UserControlCart : UserControl
    {
        public UserControlCart(Film film)
        {
            InitializeComponent();

            double prix = 9.00;

            if(film.IsESV)
            {
                prix += 2;
            }
            if(film.Is3D)
            {
                prix += 2.50;
            }

            prixBillet.Text = prix.ToString();
            Titre.Text = film.Representation.Name;
            TypeBillet.Text = "Adulte";
            

        }
    }
}
