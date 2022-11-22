using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace tp2.Wall.Assets.Classes
{
    public class Post
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Reaction> Reactions { get; set; }
        public BitmapImage Picture { get; set; }
        public Content Content { get; set; }

        public Post(int id, User user, string picture, Content content)
        {
            Id = id;
            User = user;
            Picture = new BitmapImage(App.GetUri(picture));
            Content = content;
            Reactions = new List<Reaction>();
        } 

        public string Likes { get => Reactions.Count(x=>x is Like).ToString(); }
        public string Loves{ get => Reactions.Count(x=>x is Love).ToString(); }
        public string Sad { get => Reactions.Count(x=>x is Sad).ToString(); }
        public string Angry { get => Reactions.Count(x=>x is Mad).ToString(); }
        public void AddReaction(Reaction reaction)
        {
            if (Reactions.Any(x => x.GetType() == reaction.GetType() && x.Id == App.Current.CurrentUser.Id))
                Reactions.RemoveAll(x => x.GetType() == reaction.GetType() && x.Id == App.Current.CurrentUser.Id);
            else
            {
                Reactions.RemoveAll(x => x.Id == App.Current.CurrentUser.Id);
                Reactions.Add(reaction);
            }

        }
    }
}
