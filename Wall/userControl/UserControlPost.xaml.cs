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
            ProfPic.Source = post.User.ProfilPic;


            //Content
            ImagePost.Source = post.Picture;
            ContentTitle.Text = Post.Content.Title;
            ContentDate.Text = Post.Content.DateTime.ToString(); ;
            ContentText.Text = Post.Content.Text;
        }
        //Reaction
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            var Radiobutton = (RadioButton)sender;
            switch (ReactionWrap.Children.IndexOf(Radiobutton))
            {
                case 0:
                    Post.AddReaction(new Like(Post.User));
                    break;
                case 1:
                    Post.AddReaction(new Love(Post.User));
                    break;
                case 2:
                    Post.AddReaction(new Sad(Post.User));
                    break;
                case 3:
                    Post.AddReaction(new Mad(Post.User));
                    break;
            }
            updateReactions();
        }

        private void updateReactions()
        {
            likes.Text = Post.Likes;
            loves.Text = Post.Loves;
            sad.Text = Post.Sad;
            angry.Text = Post.Angry;
        }
    }
}
