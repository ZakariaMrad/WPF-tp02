using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace tp2.Wall.Assets.Classes
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BitmapImage Image { get; set; }
        public List<User> Admins { get; set; }
        public List<User> Users { get; set; }
        public List<Post> Posts { get; set; }

        public Group(int id, string name, string description, string image, User admin)
        {
            Id = id;
            Name = name;
            Description = description;
            //Image = image;
            Admins = new List<User>();
            Admins.Add(admin);
            Users = new List<User>();
            Users.Add(admin);
            Posts = new List<Post>();
        }

        public void addUser(User admin, User user)
        {
            if (Admins.Exists(x => x.Id == admin.Id))
                Users.Add(user);
        }
        public void addAdmin(User admin, User user)
        {
            if (Admins.Exists(x => x.Id == admin.Id))
                Admins.Add(user);
        }
        public void addPost(Post post)
        {
            if (Users.Exists(x => x.Id == post.User.Id))
                Posts.Add(post);
        }
    }

    
}
