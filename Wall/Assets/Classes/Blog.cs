using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Wall.Assets.Classes
{
    public class Blog
    {
        public int Id { get; set; }
        public string Texte { get; set; }
        public User User { get; set; }
    }
}
