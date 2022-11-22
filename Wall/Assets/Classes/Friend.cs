using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Wall.Assets.Classes
{
    public class Friend
    {
        public User User1 { get; set; }
        public User User2 { get; set; }

        public Friend(User user1,User user2)
        {
            User1 = user1;
            User2 = user2;
        }
    }
}
