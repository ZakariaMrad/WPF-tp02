using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using tp2.Wall.Assets;
using tp2.Wall.Assets.Classes;

namespace tp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new App Current
        {
            get { return Application.Current as App; }
        }


        public class Cars
        {
            public int Id { get; set; }
            public string Image { get; set; }
            public DateTime PublishDate { get; set; }
            public string CarFabricant { get; set; }
            public int CarYear { get; set; }
            public int CarPrice { get; set; }
            public int Kilometer { get; set; }
        }
        public static readonly string ApplicationBaseUri = "pack://application:,,,/tp2;component/Wall/Assets";

        public static Uri GetUri(string path)
        {
            return new Uri(ApplicationBaseUri + path);
        }

        public User CurrentUser { get; set; }

        public static Dictionary<int, User> Users = new Dictionary<int, User>()
        {
            { 1001, new User(1001,"Tom","Richards","/Users/user1.jpg",350) },
            { 1002, new User(1002,"Elliot","Hart","/Users/user2.jpg",350) },
            { 1003, new User(1003,"Rachel","Chapman","/Users/user3.jpg",350) },
            { 1004, new User(1004,"Myriam","Leblanc","/Users/user4.jpg",350) },
            { 1005, new User(1005,"Paul","Burnham","/Users/user5.jpg",350) },
        };

        public static Dictionary<int, Post> Posts = new Dictionary<int, Post>()
        {
            { 101,new Post(101,Users[1001],"/Posts/post1.jpg",new Content(1,"content1",DateTime.Now,"udsfidsf") ) },
            { 102,new Post(102,Users[1001],"/Posts/post2.jpg",new Content(2,"content2",DateTime.Now,"udsfidsf") ) },
            { 103,new Post(103,Users[1002],"/Posts/post3.jpg",new Content(3,"content3",DateTime.Now,"udsfidsf") ) },
            { 104,new Post(104,Users[1002],"/Posts/post4.jpg",new Content(4,"content4",DateTime.Now,"udsfidsf") ) },
            { 105,new Post(105,Users[1003],"/Posts/post5.jpg",new Content(5,"content5",DateTime.Now,"udsfidsf") ) },
            { 106,new Post(106,Users[1003],"/Posts/post6.jpg",new Content(6,"content6",DateTime.Now,"udsfidsf") ) },
            { 107,new Post(107,Users[1004],"/Posts/post7.jpg",new Content(7,"content7",DateTime.Now,"udsfidsf") ) },
            { 108,new Post(108,Users[1004],"/Posts/post8.jpg",new Content(8,"content8",DateTime.Now,"udsfidsf") ) },
            { 109,new Post(109,Users[1005],"/Posts/post9.jpg",new Content(8,"content8",DateTime.Now,"udsfidsf") ) },
            { 110,new Post(110,Users[1005],"/Posts/post10.jpg",new Content(8,"content8",DateTime.Now,"udsfidsf") ) },
        };

        public static Dictionary<int, Friend> Friends = new Dictionary<int, Friend>()
        {
            { 11, new Friend(Users[1001],Users[1002]) },
            { 12, new Friend(Users[1001],Users[1003]) },
            { 13, new Friend(Users[1001],Users[1004]) },
            { 14, new Friend(Users[1002],Users[1003]) },
            { 15, new Friend(Users[1003],Users[1004]) },
        };

        public static Group mainGroup = new Group(1, "Main Group", "this is the main group", "", Users[1001]);
        public static void initMain()
        {
            App.Current.CurrentUser = Users[1001];
            //Add Users
            mainGroup.addUser(Users[1001],Users[1002]);
            mainGroup.addUser(Users[1001],Users[1003]);
            mainGroup.addUser(Users[1001],Users[1004]);
            mainGroup.addUser(Users[1001],Users[1005]);

            //Add Posts
            mainGroup.addPost(Posts[101]);
            mainGroup.addPost(Posts[102]);
            mainGroup.addPost(Posts[103]);
            mainGroup.addPost(Posts[104]);
            mainGroup.addPost(Posts[105]);
            mainGroup.addPost(Posts[106]);
            mainGroup.addPost(Posts[107]);
            mainGroup.addPost(Posts[108]);
            mainGroup.addPost(Posts[109]);
            mainGroup.addPost(Posts[110]);
        }



    }
}
