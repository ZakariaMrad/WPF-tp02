using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using tp2.partieB___jeremy.userControl;

namespace tp2.partieB___jeremy
{
    /// <summary>
    /// Interaction logic for cinema.xaml
    /// </summary>
    public partial class Cinema : Window
    {
        Film FilmChoisi;
        public int compteur { get; set; }
        public Cinema()
        {
            
            InitializeComponent();
            InitializeImages();
            InitializeComboBox();
            trierFilm.SelectionChanged += TrierFilm_SelectionChanged;
            buttonAchat1.Click += ButtonAchat1_Click;
            buttonAchat2.Click += ButtonAchat2_Click;
            buttonAchat3.Click += ButtonAchat3_Click;
            buttonAchat4.Click += ButtonAchat4_Click;

        }

        private void ButtonAchat4_Click(object sender, RoutedEventArgs e)
        {
            declickButton();
            buttonAchat4.IsChecked = true;
        }
        private void ButtonAchat3_Click(object sender, RoutedEventArgs e)
        {
            declickButton();
            buttonAchat3.IsChecked = true;
        }
        private void ButtonAchat2_Click(object sender, RoutedEventArgs e)
        {
            declickButton();
            buttonAchat2.IsChecked = true;
        }
        private void ButtonAchat1_Click(object sender, RoutedEventArgs e)
        {
            declickButton();
            buttonAchat1.IsChecked = true;
        }

        private void declickButton()
        {
            buttonAchat1.IsChecked = false;
            buttonAchat2.IsChecked = false;
            buttonAchat3.IsChecked = false;
            buttonAchat4.IsChecked = false;
        }

        private void TrierFilm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            userControl.Children.Clear();
            if (trierFilm.SelectedIndex == 0)
            {
                foreach (Film item in App.Current.Films.Values.OrderBy(Film => Film.Temps[0]))
                {
                    userControl.Children.Add(new UserControlFilmCinema(item));
                }
            }
            if (trierFilm.SelectedIndex == 1)
            {
                foreach (Film item in App.Current.Films.Values.OrderBy(Film => Film.Representation.Name))
                {
                    userControl.Children.Add(new UserControlFilmCinema(item));
                }
            }
            if (trierFilm.SelectedIndex == 2)
            {
                foreach (Film item in App.Current.Films.Values)
                {
                    userControl.Children.Add(new UserControlFilmCinema(item));
                }
            }
        }

        private void InitializeComboBox()
        {
            foreach (var item in App.FilterFilm.Values)
            {
                trierFilm.Items.Add("Trier selon les " + item);
            }
            trierFilm.Items.Add("Annuler");
        }

        public void InitializeImages()
        {
            userControl.Children.Clear();
            foreach (Film item in App.Current.Films.Values)
            {
                userControl.Children.Add(new UserControlFilmCinema(item));
            }
        }
 
        public void InitializeButtonAchat(Film film)
        {
            FilmChoisi = film;

        }
    }
}
