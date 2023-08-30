using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; } //Date of registration
        public bool IsVerifiedAccount { get; set; } = false;
        public int PositionId { get; set; }
        public int GroupId { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public Position Position { get; set; }
        public Groups Group { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
