﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string RoleDescription { get; set; }
    }
}
