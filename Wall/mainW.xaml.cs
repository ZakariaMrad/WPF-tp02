using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using tp2.Wall.Assets.Classes;

namespace tp2.Wall
{
    /// <summary>
    /// Logique d'interaction pour mainW.xaml
    /// </summary>
    public partial class mainW : Window
    {
        bool byDate2 = true;

        public mainW()
        {
            InitializeComponent();
            App.initMain();

            InitRadioBoxes();
            initProfile();
            initAllPosts();

            AddEvents();
        }

        private void initAllPosts()
        {
            PostsStack.Children.Clear();
            foreach (var post in byDate2 ? App.Posts.Values.OrderByDescending(x => x.Date) : App.Posts.Values.OrderByDescending(x => x.Reactions.Count)) 
            { //C'est pas beau mais ça marche lol
                PostsStack.Children.Add(new UserControlPost(post));
            }
        }
        private void initFriendsPosts()
        {
            PostsStack.Children.Clear();
            foreach (var friend in App.Friends.Values)
            {
                if (friend.isAFriend(App.Current.CurrentUser))
                {
                    Post[] posts = friend.getPosts();
                    foreach (var item in posts)
                        PostsStack.Children.Add(new UserControlPost(item));
                }
            }
        }
        private void initUserPosts(User user)
        {
            PostsStack.Children.Clear();
            foreach (var post in App.Posts.Values)
            {
                if (post.User ==user)
                    PostsStack.Children.Add(new UserControlPost(post));
            }
        }

        private void initProfile()
        {
            userName.Text = App.Current.CurrentUser.ToString();
            profilPic.Source = App.Current.CurrentUser.ProfilPic;

            FriendList.Items.Clear();
            foreach (var item in App.Friends.Values)
            {
                if (item.isAFriend(App.Current.CurrentUser))
                    FriendList.Items.Add(item);
            }
        }

        private void InitRadioBoxes()
        {
            foreach (var user in App.Users.Values)
            {
                comboUsers.Items.Add(user);
                comboPosts.Items.Add(user);
            }
            comboUsers.SelectedIndex = 0;
        }

        private void comboUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //var selectedUser = (ComboBoxItem)sender;
            App.Current.CurrentUser = App.Users[comboUsers.SelectedIndex+1001];
            initProfile();

        }
        private void comboPosts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            initPost();
        }

        private void initPost()
        {
            switch (comboPosts.SelectedIndex)
            {
                case 0:
                    initAllPosts();
                    break;
                case 1:
                    initFriendsPosts();
                    break;
                default:
                    initUserPosts(App.Users[comboPosts.SelectedIndex + 999]);
                    break;
            }
        }

        private void RemoveEvents()
        {
            comboUsers.SelectionChanged -= comboUsers_SelectionChanged;
            comboPosts.SelectionChanged -= comboPosts_SelectionChanged;
            byDate.Checked -= RadioButton_Checked;
            byPop.Checked -= RadioButton_Checked;

        }

        private void AddEvents()
        {
            comboUsers.SelectionChanged += comboUsers_SelectionChanged;
            comboPosts.SelectionChanged += comboPosts_SelectionChanged;
            byDate.Checked += RadioButton_Checked;
            byPop.Checked += RadioButton_Checked;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            byDate2 = byDate.IsChecked==true;
            initPost();
        }
    }
}
