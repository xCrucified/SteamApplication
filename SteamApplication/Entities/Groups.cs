using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Entities
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Followers { get; set; }
        public Int16 Rate { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
