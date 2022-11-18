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
    /// Logique d'interaction pour UserControlPost.xaml
    /// </summary>
    public partial class UserControlPost : UserControl
    {
        Post Post;
        public UserControlPost()
        {
            InitializeComponent();
        }
        public UserControlPost(Post post)
        {
            InitializeComponent();
            Post = post;
            NameUser.Text = post.User.FirstName + " " + post.User.LastName;
            TimeUser.Text = post.User.Time.ToString();
            reactions = new UserControlReaction(Post);
            contents = new UserControlcontent(Post.Content);
            //ImagePost.Source = post.Picture
        }
    }
}
