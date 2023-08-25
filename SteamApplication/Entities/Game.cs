using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Cost { get; set; }
        public int CategoryId { get; set; }
        public Int16? Rate { get; set; }

        public Category Category { get; set; }
    }
}
