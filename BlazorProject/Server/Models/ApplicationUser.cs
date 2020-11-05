﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BlazorProject.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; }

        public List<Wallet> Wallets { get; set; }
    }
}
