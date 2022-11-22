using System;

namespace tp2.Wall.Assets.Classes
{
    public class Content
    {
        int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }
        public Content(int id, string title, DateTime dateTime, string text)
        {
            Id = id;
            Title = title;
            DateTime = dateTime;
            Text = text;
        }   
    }
}
