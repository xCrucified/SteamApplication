using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Followers { get; set; }
        public int CountryId { get; set; }

        public ICollection<Game> Game { get; set; }
        public Country Country { get; set; }
        public ICollection<Market> Market { get; set; }
    }
}
