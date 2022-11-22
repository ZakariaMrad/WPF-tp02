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
            TimeUser.Text = Math.Floor(DateTime.Now.Subtract(Post.Date).TotalDays).ToString()+" Days ago";
            ProfPic.Source = post.User.ProfilPic;


            //Content
            ImagePost.Source = post.Picture;
            ContentTitle.Text = Post.Content.Title;
            ContentText.Text = Post.Content.Text;
            ContentDate.Text = Post.Date.ToString("MMMM dd")+ " at "+ Post.Date.ToString("HH:MM");
            updateReactions();
        }
        //Reaction
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            var Radiobutton = (RadioButton)sender;
            switch (ReactionWrap.Children.IndexOf(Radiobutton))
            {
                case 0:
                    Post.AddReaction(new Like(App.Current.CurrentUser));
                    break;
                case 1:
                    Post.AddReaction(new Love(App.Current.CurrentUser));
                    break;
                case 2:
                    Post.AddReaction(new Sad(App.Current.CurrentUser));
                    break;
                case 3:
                    Post.AddReaction(new Mad(App.Current.CurrentUser));
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
