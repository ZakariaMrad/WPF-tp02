using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Wall.Assets.Classes
{
    public class Event
    {
        public static int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime Duree { get; set; }
        public string Adresse { get; set; }
        public string Image { get; set; }

        public List<string> EventType {get; set; }

        public bool IsPublic { get; set; }


        public IEnumerable<User> posts = new List<User>().Where(x=>x.Id == Id);
    }

    
}
