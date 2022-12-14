using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Tp_Synthèse_B;
using tp2.Marketplace.pourlemoment.Classes;
using tp2.partieB___jeremy.Assets.Classe;
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
            get { return (App)Application.Current; }
        }

        private const string Text = "udsfidsf";
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

        public static readonly string ApplicationBaseUri3 = "pack://application:,,,/tp2;component/Zakaria/Assets/TShirts/";
        public static Uri getURIZ(string path)
        {
            return new Uri(ApplicationBaseUri3 + path);
        }



        public static readonly string ApplicationBaseUri4 = "pack://application:,,,/tp2;component/partieB - jeremy/Assets";

        public static Uri GetUri3(string path)
        {
            return new Uri(ApplicationBaseUri4 + path);
        }


        static string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?";
        
        public static Dictionary<int, Clothes> Products = new Dictionary<int, Clothes>()
        {
            {0,new Clothes(0,"chandail","C'est le meilleur chandail sur terre!",24.99,
                new Dictionary<string, string>()
                {
                    {"black","a-black.jpg" },
                    {"green","a-green.jpg" },
                    {"red","a-red.jpg" },
                }, 
                new List<string>(){"xs","s","m","xl"},5) 
            },
            {1,new Clothes(1,"chandail","Chandail pas cher!!",20.99,
                new Dictionary<string, string>()
                {
                    {"encanto","b-encanto.jpg" },
                    {"gray","b-gray.jpg" },
                }, 
                new List<string>(){"xs","s","m","xl"},5) 
            },
        };

        public Dictionary<int, Cars> cars = new Dictionary<int, Cars>()
        {

           {1, new Cars(){Image ="/Offers/Cars/car1.jpg", PublishDate="2021-11-19",CarPrice=6000 ,CarFabricant="Honda", CarName="Accord",   CarYear=2014,Kilometer=170}},
           {2, new Cars(){Image ="/Offers/Cars/car2.jpg", PublishDate="2021-11-19",CarPrice=5000 ,CarFabricant="Toyota",CarName="Camry",    CarYear=2015,Kilometer=200}},
           {3, new Cars(){Image ="/Offers/Cars/car3.jpg", PublishDate="2021-11-21",CarPrice=8000 ,CarFabricant="Nissan",CarName="Leaf",     CarYear=2013,Kilometer=210}},
           {4, new Cars(){Image ="/Offers/Cars/car4.jpg", PublishDate="2021-11-21",CarPrice=10000,CarFabricant="Toyota",CarName="Yaris",    CarYear=2021,Kilometer=20 }},
           {5, new Cars(){Image ="/Offers/Cars/car5.jpg", PublishDate="2021-11-23",CarPrice=1000 ,CarFabricant="Honda", CarName="Civic",    CarYear=2001,Kilometer=350}},
           {6, new Cars(){Image ="/Offers/Cars/car6.jpg", PublishDate="2021-11-23",CarPrice=6000 ,CarFabricant="Honda", CarName="Civic",    CarYear=2011,Kilometer=140}},
           {7, new Cars(){Image ="/Offers/Cars/car7.jpg", PublishDate="2021-11-25",CarPrice=20000,CarFabricant="Toyota",CarName="Camry",    CarYear=2021,Kilometer=10}},
           {8, new Cars(){Image ="/Offers/Cars/car8.jpg", PublishDate="2021-11-25",CarPrice=7000 ,CarFabricant="Nissan",CarName="Infiniti", CarYear=2015,Kilometer=150}},
           {9, new Cars(){Image ="/Offers/Cars/car9.jpg", PublishDate="2021-11-27",CarPrice=9000 ,CarFabricant="Nissan",CarName="Infiniti", CarYear=2016,Kilometer=170}},
           {10, new Cars(){Image ="/Offers/Cars/car10.jpg",PublishDate="2021-11-27",CarPrice=12000,CarFabricant="Honda", CarName="Accord",   CarYear=2018,Kilometer=90}},
           {11, new Cars(){Image ="/Offers/Cars/car11.jpg",PublishDate="2021-11-29",CarPrice=5000 ,CarFabricant="Toyota",CarName="Yaris",    CarYear=2013,Kilometer=210}},
           {12, new Cars(){Image ="/Offers/Cars/car12.jpg",PublishDate="2021-11-29",CarPrice=2000, CarFabricant="Nissan",CarName="Altima",   CarYear=2003,Kilometer=320} },

        };

        public static Dictionary<int, string> Category = new Dictionary<int, string>
        {
            {100,"Appliances" },
            {101,"Cars" },
            {102,"Property Rentals" },
        };

        public static Dictionary<int, string> FilterFilm = new Dictionary<int, string>
        {
            {100,"prochaine" },
            {101,"titres de film" },
        };

        //public static Dictionary<int, string> Maker = new Dictionary<int, string>
        //{
        //    {200,"Honda" },
        //    {201,"Toyota" },
        //    {202,"Nisan" },
        //};





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
            { 101,new Post(101,Users[1001],"/Posts/post1.jpg",new Content(1,"Is this you?",lorem),new DateTime(2022,11,19,12,7,0) )},
            { 102,new Post(102,Users[1001],"/Posts/post2.jpg",new Content(2,"How to get rich 100% no scam",lorem),new DateTime(2022,11,18,13,45,0)) },
            { 103,new Post(103,Users[1002],"/Posts/post3.jpg",new Content(3,"How to get back with your ex",lorem),new DateTime(2022,11,17,22,12,0) )},
            { 104,new Post(104,Users[1002],"/Posts/post4.jpg",new Content(4,"This is the way to get into a mr.Beast video",lorem),new DateTime(2022,11,17,13,28,0)) },
            { 105,new Post(105,Users[1003],"/Posts/post5.jpg",new Content(5,"How to get your hustle going",lorem),new DateTime(2022,11,18,23,21,0)) },
            { 106,new Post(106,Users[1003],"/Posts/post6.jpg",new Content(6,"La réalité sur les probiotique",lorem),new DateTime(2022,11,19,21,56,0)) },
            { 107,new Post(107,Users[1004],"/Posts/post7.jpg",new Content(7,"Become a twitter employee in two weeks",lorem),new DateTime(2022,11,21,18,12,0)) },
            { 108,new Post(108,Users[1004],"/Posts/post8.jpg",new Content(8,"Find milf near you",lorem),new DateTime(2022,11,19,23,18,0)) },
            { 109,new Post(109,Users[1005],"/Posts/post9.jpg",new Content(8,"This is the only way to get this ${itemm}",lorem),new DateTime(2022,11,12,21,7,0)) },
            { 110,new Post(110,Users[1005],"/Posts/post10.jpg",new Content(9,"How to get 10000$ from the government",lorem),new DateTime(2022,11,16,11,49,0) ) },
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
            mainGroup.addUser(Users[1001], Users[1002]);
            mainGroup.addUser(Users[1001], Users[1003]);
            mainGroup.addUser(Users[1001], Users[1004]);
            mainGroup.addUser(Users[1001], Users[1005]);

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


        // partie B - cinema

        public Dictionary<int, Synopsis> Synopsises = new Dictionary<int, Synopsis>()
        {
            {10,new Synopsis(){ Id=11, Resume="tu te souvendras de moi"} },
            {20,new Synopsis(){ Id=12, Resume="Au Nord d'Albany"} },
            {30,new Synopsis(){ Id=13, Resume="23 décembre"} },
            {40,new Synopsis(){ Id=15, Resume="Black Panther: longue vie au wakanda"} },
            {50,new Synopsis(){ Id=16, Resume="o violente nuit"} },
        };

        public Dictionary<int, Film> vente = new Dictionary<int, Film>() { };


        public Dictionary<int, Film> Films = new Dictionary<int, Film>()
        {
            { 1, new Film(){Id=11,Representation=new Representation(110,"Tu te souvendras de moi","1:50",15), Classement="G",Version="V.F.",IsESV= false,Is3D=false,Image="/Images/Films/souviendrasDeMoi.jpg", Temps=new List<string>{"12:40","3:30","6:30","9:30"} } },
            { 2, new Film(){Id=12,Representation=new Representation(111,"Au Nord d'Albany","1:47",15),      Classement= "G",Version="V.F.",                    IsESV=false,Is3D=false,Image="/Images/Films/aunorddalbany.jpg",Temps=new List<string>{"12:30","3:30","6:30","9:30"} } },
            { 3, new Film(){Id=13,Representation=new Representation(112,"23 décembre","1:41",15), Classement="G",Version="V.F.",                               IsESV=false,Is3D=false,Image="/Images/Films/23Decembre.jpg",Temps=new List<string>{"12:35","3:30","6:30","9:30"} } },
            { 4, new Film(){Id=15,Representation=new Representation(113,"Black Panther: longue vie au wakanda","2:41",10), Classement= "GDJE",Version="V.F.",  IsESV=false,Is3D=true, Image="/Images/Films/Wakanda.jpg",Temps=new List<string>{"12:50","3:30","6:30","9:30"} } },
            { 5, new Film(){Id=15,Representation=new Representation(114,"Black Panther: longue vie au wakanda","2:41",10), Classement= "GDJE", Version="V.F.", IsESV=true, Is3D=true, Image="/Images/Films/Wakanda.jpg",Temps=new List<string>{"12:45","3:30","6:30","9:30"} } },
            { 6, new Film(){Id=16,Representation=new Representation(115,"o violente nuit ","1:41",15), Classement="13+", Version="V.F.",                       IsESV=false,Is3D=false,Image="/Images/Films/violentnight.jpeg",Temps=new List<string>{"12:30","3:30","6:30","9:30"} } },
        };








    }
}
