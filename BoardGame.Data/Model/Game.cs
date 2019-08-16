using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame.Data.Model
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
    }
}
