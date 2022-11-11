using System;
using System.Collections.Generic;

namespace tp2.Wall.Assets.Classes
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri ProfilPic { get; set; }
        public List<User> Friends { get; set; }

    }
}
