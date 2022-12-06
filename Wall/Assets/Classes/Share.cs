using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Wall.Assets.Classes
{
    public class Share
    {
        public static int Id { get; set; }
        public User Currentuser { get; set; }
        public User OriginalUser { get; set; }

        public IEnumerable<Post> OriginalPost = new List<Post>().Where(x => x.Id == Id);


    }

   
}
