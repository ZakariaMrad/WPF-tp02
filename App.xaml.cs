using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace tp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current
        {
            get { return Application.Current as App; }
        }

        public Dictionary<int, Cars> Users = new Dictionary<int, Cars>();

        public class Cars
        {
            public int Id { get; set; }
            public string Image { get; set; }
            public DateTime PublishDate { get; set; }
            public string CarFabricant { get; set; }
            public int CarYear { get; set; }
            public int CarPrice { get; set; }
            public int Kilometer { get; set; }
        }
    }
}
