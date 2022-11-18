using System.Collections.Generic;

namespace tp2.Wall.Assets.Classes
{
    public class Reaction
    {
        public int Id { get; set; }
        public Reaction(User user)
        {
            Id = user.Id;
        }   
    }
}
