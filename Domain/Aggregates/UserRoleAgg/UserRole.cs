using Domain.Aggregates.RoleAgg;
using Domain.Aggregates.UserAgg;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Aggregates.UserRoleAgg
{
    public class UserRole : IdentityUserRole<string>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
