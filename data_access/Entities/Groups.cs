using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Followers { get; set; }
        public int Rate { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
