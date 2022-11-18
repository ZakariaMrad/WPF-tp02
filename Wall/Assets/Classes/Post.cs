using System;
using System.Linq;
using System.Collections.Generic;

namespace tp2.Wall.Assets.Classes
{
    public class Post
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Reaction> Reactions { get; set; }
        public string Picture { get; set; }
        public Content Content { get; set; }

        public Post(int id, User user, string picture, Content content)
        {
            Id = id;
            User = user;
            Picture = picture;
            Content = content;
            Reactions = new List<Reaction>();
        } 


        public void addReaction(Reaction reaction)
        {
            Reactions.RemoveAll(x => x.Id == reaction.Id);
            Reactions.Add(reaction);
        }
    }
}
