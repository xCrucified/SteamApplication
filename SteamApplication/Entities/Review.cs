using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }

        public Game Game { get; set; }
        public User User { get; set; }
    }
}
