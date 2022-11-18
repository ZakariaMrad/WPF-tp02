using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace tp2.Wall.Assets.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public BitmapImage? ProfilPic { get; set; }
        public BitmapImage? BackgroundPic { get; set; }
        public int Time { get; set; }


        public List<Friend> Friends { get; set; }

        public User (int id, string firstName, string lastName, string profilPic, int time)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            //ProfilPic = new BitmapImage(App.GetUri(profilPic));
            Time = time;
            Password = "";
            Email = "";
            Friends= new List<Friend> ();
        }
    }
}
