﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using tp2.Marketplace.pourlemoment.Classes;
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

        public static readonly string ApplicationBaseUri = "pack://application:,,,/tp2;component/Wall/Assets";

        public static Uri GetUri(string path)
        {
            return new Uri(ApplicationBaseUri + path);
        }
        public static readonly string ApplicationBaseUri2 = "pack://application:,,,/tp2;component/Marketplace/Assets";

        public static Uri GetUri2(string path)
        {
            return new Uri(ApplicationBaseUri2 + path);
        }


        public static Dictionary<int, Cars> cars = new Dictionary<int, Cars>()
        {
           {1, new Cars("/Offers/Cars/car1.jpg", "2021-11-19", 6000 , "Honda   ", "Accord  ", 2014, 170)},
           {2, new Cars( "/Offers/Cars/car2.jpg", "2021-11-19", 5000 , "Toyota  ", "Camry   ", 2015, 200)},
           {3, new Cars( "/Offers/Cars/car3.jpg", "2021-11-21", 8000 , "Nissan  ", "Leaf    ", 2013, 210)},
           {4, new Cars( "/Offers/Cars/car4.jpg", "2021-11-21", 10000, "Toyota  ", "Yaris   ", 2021, 20) },
           {5, new Cars( "/Offers/Cars/car5.jpg", "2021-11-23", 1000 , "Honda   ", "Civic   ", 2001, 350)},
           {6, new Cars( "/Offers/Cars/car6.jpg", "2021-11-23", 6000 , "Honda   ", "Civic   ", 2011, 140)},
           {7, new Cars( "/Offers/Cars/car7.jpg", "2021-11-25", 20000, "Toyota  ", "Camry   ", 2021, 10)},
           {8, new Cars( "/Offers/Cars/car8.jpg", "2021-11-25", 7000 , "Nissan  ", "Infiniti    ", 2015,150)},
           {9, new Cars( "/Offers/Cars/car9.jpg", "2021-11-27", 9000 , "Nissan  ", "Infiniti    ", 2016,170)},
           {10, new Cars( "/Offers/Cars/car10.jpg", "2021-11-27", 12000, "Honda   ", "Accord  ", 2018, 90)},
           {11, new Cars( "/Offers/Cars/car11.jpg", "2021-11-29", 5000 , "Toyota  ", "Yaris   ", 2013, 210)},
           {12, new Cars( "/Offers/Cars/car12.jpg", "2021-11-29", 2000, "Nissan  ", "Altima  ", 2003, 320)},

        };

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
            { 101,new Post(101,Users[1001],"/Posts/post1.jpg",new Content(1,"content1","udsfidsf"),new DateTime(2022,11,19,12,7,0) )},
            { 102,new Post(102,Users[1001],"/Posts/post2.jpg",new Content(2,"content2","udsfidsf"),new DateTime(2022,11,18,13,45,0)) },
            { 103,new Post(103,Users[1002],"/Posts/post3.jpg",new Content(3,"content3","udsfidsf"),new DateTime(2022,11,17,22,12,0) )},
            { 104,new Post(104,Users[1002],"/Posts/post4.jpg",new Content(4,"content4","udsfidsf"),new DateTime(2022,11,17,13,28,0)) },
            { 105,new Post(105,Users[1003],"/Posts/post5.jpg",new Content(5,"content5","udsfidsf"),new DateTime(2022,11,18,23,21,0)) },
            { 106,new Post(106,Users[1003],"/Posts/post6.jpg",new Content(6,"content6","udsfidsf"),new DateTime(2022,11,19,21,56,0)) },
            { 107,new Post(107,Users[1004],"/Posts/post7.jpg",new Content(7,"content7","udsfidsf"),new DateTime(2022,11,21,18,12,0)) },
            { 108,new Post(108,Users[1004],"/Posts/post8.jpg",new Content(8,"content8","udsfidsf"),new DateTime(2022,11,19,23,18,0)) },
            { 109,new Post(109,Users[1005],"/Posts/post9.jpg",new Content(8,"content8","udsfidsf"),new DateTime(2022,11,12,21,7,0)) },
            { 110,new Post(110,Users[1005],"/Posts/post10.jpg",new Content(8,"content8","udsfidsf"),new DateTime(2022,11,16,11,49,0) ) },
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
