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


        public bool isAFriend(User user)
        {
            return user == User1 || user==User2;
        }

        public override string ToString()
        {
            return (User1 == App.Current.CurrentUser ? User2 : User1).ToString();
        }

        public Post[] getPosts()
        {
            return (User1 == App.Current.CurrentUser ? User2 : User1).getPosts();
        }
    }
}
