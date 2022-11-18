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
    /// Logique d'interaction pour UserControlReaction.xaml
    /// </summary>
    public partial class UserControlReaction : UserControl
    {
        Post? Post;
        public UserControlReaction()
        {
            InitializeComponent();
        }
        public UserControlReaction(Post post)
        {
            InitializeComponent();
            Post = post;
            likes.Text = post.Reactions.Where(x=> x is Like).Count().ToString();
            loves.Text = post.Reactions.Where(x=> x is Love).Count().ToString();
            sad.Text = post.Reactions.Where(x=> x is Sad).Count().ToString();
            angry.Text = post.Reactions.Where(x=> x is Mad).Count().ToString();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            var Radiobutton = (RadioButton)sender;
            switch (ReactionWrap.Children.IndexOf(Radiobutton))
            {
                case 0:
                    Post.addReaction(new Like(Post.User));
                    break;
                case 1:
                    Post.addReaction(new Love(Post.User));
                    break;
                case 2:
                    Post.addReaction(new Sad(Post.User));
                    break;
                case 3:
                    Post.addReaction(new Mad(Post.User));
                    break;
            }
        }
    }
}
