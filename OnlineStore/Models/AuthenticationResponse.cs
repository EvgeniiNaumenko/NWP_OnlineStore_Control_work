﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class AuthenticationResponse
    {
        public bool Authenticated { get; set; }
        public int? UserId { get; set; }
    }
}
