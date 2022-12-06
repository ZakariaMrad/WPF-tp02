using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Wall.Assets.Classes
{
    public class PhotoVideo
    {
        public string Id { get; set; }
        public List<string> Tags { get; set; }
        public User user { get; set; }

        public List<link> photoSlashVideo { get; set; }

    }
}
