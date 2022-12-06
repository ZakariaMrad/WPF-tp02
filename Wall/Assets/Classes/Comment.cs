using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Wall.Assets.Classes
{
    public class Comment
    {

        public static int Id { get; set; }

        public User User { get; set; }
        public string Texte { get; set; }
        public string Image { get; set; }

        public IEnumerable<Post> OriginalPost = new List<Post>().Where(x => x.Id == Id);

    }
}
