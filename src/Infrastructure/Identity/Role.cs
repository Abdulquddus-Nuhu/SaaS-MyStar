﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infrastructure.Identity
{
    public class Role : IdentityRole<string>
    {
        public bool IsDeleted { get; set; }
        public string? DeletedBy { get; protected set; } = string.Empty;
        public virtual DateTime? Deleted { get; protected set; }

        public Role()
        {
            Id = Guid.NewGuid().ToString();
        }

        public Role(string roleName)
        {
            Id = Guid.NewGuid().ToString();
            Name = roleName;
        }

    }
}
