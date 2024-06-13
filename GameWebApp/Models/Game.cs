using System;
using System.Collections.Generic;

namespace GameWebApp.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Rating { get; set; }
        public string Platforms { get; set; }
        public string Stores { get; set; }
        public IEnumerable<string> Screenshots { get; set; } // New property for screenshots
    }
}
