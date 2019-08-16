using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGame.Models
{
    public class BoardGameVM
    {
        public string Title { get; set; }
        public string PublishingCompany { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
    }
}
