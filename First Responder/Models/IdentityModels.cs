﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace First_Responder.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<First_Responder.Areas.Admin.Models.Page> Pages { get; set; }

        public System.Data.Entity.DbSet<First_Responder.Areas.Admin.Models.Station> Stations { get; set; }

        public System.Data.Entity.DbSet<First_Responder.Areas.Admin.Models.Rank> Ranks { get; set; }

        public System.Data.Entity.DbSet<First_Responder.Areas.Admin.Models.RoleType> RoleTypes { get; set; }

        public System.Data.Entity.DbSet<First_Responder.Areas.Admin.Models.State> States { get; set; }

        public System.Data.Entity.DbSet<First_Responder.Areas.Admin.Models.DriverType> DriverTypes { get; set; }

        //public System.Data.Entity.DbSet<First_Responder.Models.Page> Pages { get; set; }
    }
}