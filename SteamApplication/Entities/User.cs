﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public Boolean IsVerifiedAccount { get; set; } = false;
        public int PositionId { get; set; }
        public Position Position { get; set; }

    }
}
