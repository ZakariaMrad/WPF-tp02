using System;
using System.Collections.Generic;

namespace tp2.Wall.Assets.Classes
{
    class Post
    {
        public int Id { get; set; }
        public User User { get; set; }
        List<Reaction> Reactions { get; set; }
        Uri Picture { get; set; }
        Content content { get; set; }

    }
}
