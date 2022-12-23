using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for UserControlFilmCinema.xaml
    /// </summary>
    public partial class UserControlFilmCinema : UserControl
    {
        Film films;
        int Compteur;
        public UserControlFilmCinema(Film film)
        {
            films = film;    
            InitializeComponent();
            InitializeImage();
            ActivateButton();
            representationsFilm.IsEnabled = false;
        }


        private void ActivateButton()
        {
            toggleButton.Click += ToggleButton_Click;
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
         {

            cinema cinema = new cinema();
            cinema.compteur = Compteur;

            if(cinema.buttonAchat1.IsChecked == true)
            {
                App.Current.vente.Add(Compteur,films);
                Compteur++;
            }
            if (cinema.buttonAchat2.IsChecked == true)
            {
                App.Current.vente.Add(Compteur, films);
                Compteur++;
            }
            if (cinema.buttonAchat3.IsChecked == true)
            {
                App.Current.vente.Add(Compteur, films);
                Compteur++;
            }
            if (cinema.buttonAchat4.IsChecked == true)
            {
                App.Current.vente.Add(Compteur, films);
                Compteur++;
            }

            foreach (var item in App.Current.vente.Values)
            {
                cinema.userControlCart.Children.Add(new UserControlCart(item));
            }
        }


        private void InitializeImage()
        {
            string troisD = "";
            string ESV = "";

            ImageFilm.Source = new BitmapImage(App.GetUri3(films.Image));
            if(films.Is3D)
            {
                troisD = "3D";
            }
            if(films.IsESV)
            {
                ESV = "ESV";
            }
            

            Titre.Text = films.Representation.Name + " " + troisD + " " + ESV;
            langue.Text = films.Version;
            tempsFilm.Text = films.Representation.Duree;
            classementMPA.Text = films.Classement;


            foreach (var item in films.Temps)
            {
                representationsFilm.Text += item;
                representationsFilm.Text += "\n";
            }

        }
    }
}
