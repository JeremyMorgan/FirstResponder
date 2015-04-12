namespace First_Responder.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using First_Responder.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using First_Responder.Areas.Admin.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<First_Responder.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

      

        protected override void Seed(First_Responder.Models.ApplicationDbContext context)
        {
            //TODO: Create a "if rank you can see" section for an index, on login
            // create default ranks
            context.Ranks.AddOrUpdate(
                a => a.RankName,
                new Rank { RankName = "Support", RankAbb = "SUP" },
                new Rank { RankName = "Cadet Firefighter", RankAbb = "CFF" },
                new Rank { RankName = "Probationary Firefighter", RankAbb = "PFF" },
                new Rank { RankName = "FireFighter", RankAbb = "FF" },
                new Rank { RankName = "Lieutenant", RankAbb = "LT" },
                new Rank { RankName = "Battalion Chief", RankAbb = "BC" },
                new Rank { RankName = "Assistant Chief", RankAbb = "AC" },
                new Rank { RankName = "Fire Chief", RankAbb = "FC" }
                );

            context.RoleTypes.AddOrUpdate(

                a => a.RoleTypeName,
                new RoleType { RoleTypeName = "Support Firefighter" },
                new RoleType { RoleTypeName = "EMS Only Firefighter" },
                new RoleType { RoleTypeName = "Full Combat Firefighter" }
                );

            context.DriverTypes.AddOrUpdate(
                a => a.DriverTypeName,
                new DriverType { DriverTypeName = "None" },
                new DriverType { DriverTypeName = "RSQ" },
                new DriverType { DriverTypeName = "ENG" },
                new DriverType { DriverTypeName = "ENG/TDR" }
                );

            // A list of all 50 states
            context.States.AddOrUpdate(
                a => a.StateName,
                new State { StateName = "AL" },
                   new State { StateName = "AK" },
                   new State { StateName = "AZ" },
                   new State { StateName = "AR" },
                   new State { StateName = "CA" },
                   new State { StateName = "CO" },
                   new State { StateName = "CT" },
                   new State { StateName = "DE" },
                   new State { StateName = "DC" },
                   new State { StateName = "FL" },
                   new State { StateName = "GA" },
                   new State { StateName = "HI" },
                   new State { StateName = "ID" },
                   new State { StateName = "IL" },
                   new State { StateName = "IN" },
                   new State { StateName = "IA" },
                   new State { StateName = "KS" },
                   new State { StateName = "KY" },
                   new State { StateName = "LA" },
                   new State { StateName = "ME" },
                   new State { StateName = "MT" },
                   new State { StateName = "NE" },
                   new State { StateName = "NV" },
                   new State { StateName = "NH" },
                   new State { StateName = "NJ" },
                   new State { StateName = "NM" },
                   new State { StateName = "NY" },
                   new State { StateName = "NC" },
                   new State { StateName = "ND" },
                   new State { StateName = "OH" },
                   new State { StateName = "OK" },
                   new State { StateName = "OR" },
                   new State { StateName = "MD" },
                   new State { StateName = "MA" },
                   new State { StateName = "MI" },
                   new State { StateName = "MN" },
                   new State { StateName = "MS" },
                   new State { StateName = "MO" },
                   new State { StateName = "PA" },
                   new State { StateName = "RI" },
                   new State { StateName = "SC" },
                   new State { StateName = "SD" },
                   new State { StateName = "TN" },
                   new State { StateName = "TX" },
                   new State { StateName = "UT" },
                   new State { StateName = "VT" },
                   new State { StateName = "VA" },
                   new State { StateName = "WA" },
                   new State { StateName = "WV" },
                   new State { StateName = "WI" },
                   new State { StateName = "WY" }
                   );



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


           // AddUserAndRole(context);

           
        }

        /*
        bool AddUserAndRole(First_Responder.Models.ApplicationDbContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "jeremymorgan@gmail.com",
            };
            ir = um.Create(user, "[PASSWORD]");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }
        */
    }
}
