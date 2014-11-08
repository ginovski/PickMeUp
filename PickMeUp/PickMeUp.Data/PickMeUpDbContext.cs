namespace PickMeUp.Data
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;

    using PickMeUp.Data.Migrations;
    using PickMeUp.Models;

    public class PickMeUpDbContext : IdentityDbContext<ApplicationUser>
    {
        public PickMeUpDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PickMeUpDbContext, Configuration>());
        }

        public static PickMeUpDbContext Create()
        {
            return new PickMeUpDbContext();
        }

        public IDbSet<City> Cities { get; set; }
    }
}
