using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? Cost { get; set; }
        public int? CompanyId { get; set; }
        public int? CategoryId { get; set; }
        public int? PlatformId { get; set; }
        public int? Rate { get; set; }

        public Platform Platform { get; set; }
        public Category Category { get; set; }
        public Company Company { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
