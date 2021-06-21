using Domain.Aggregates.UserRoleAgg;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Aggregates.RoleAgg
{
    public class Role : IdentityRole
    {
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
