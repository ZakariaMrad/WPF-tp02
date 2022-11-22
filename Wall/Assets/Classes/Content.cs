using System;

namespace tp2.Wall.Assets.Classes
{
    public class Content
    {
        int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Content(int id, string title, string text)
        {
            Id = id;
            Title = title;
            Text = text;
        }   
    }
}
