using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Entities
{
    public class Market
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int CompanyId { get; set; }


        public Game Game { get; set; }
        public Company Company { get; set; }
    }
}