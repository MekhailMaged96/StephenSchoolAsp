using Domain.Aggregates.RoleAgg;
using Domain.Aggregates.UserAgg;
using Domain.Aggregates.UserRoleAgg;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Context
{
    public class DataContext : IdentityDbContext<User, Role, string,
         IdentityUserClaim<string>, UserRole, IdentityUserLogin<string>,
         IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public DataContext(DbContextOptions options) :base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>()
             .HasKey(k => new { k.UserId, k.RoleId });

            builder.Entity<UserRole>()
                   .HasOne(e => e.User)
                   .WithMany(e => e.UserRoles)
                   .HasForeignKey(ur => ur.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserRole>()
                   .HasOne(e => e.Role)
                   .WithMany(e => e.UserRoles)
                   .HasForeignKey(ur => ur.RoleId)
                   .OnDelete(DeleteBehavior.Cascade);

        
 
        }
    }
}
