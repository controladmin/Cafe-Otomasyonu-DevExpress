namespace CafeOtomasyonuEntities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CafeOtomasyonuEntities.Models.CafeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // False olarak geldi true yaptık
            AutomaticMigrationDataLossAllowed = true;
            // ContextKey = "NameConnection";
        }

        protected override void Seed(CafeOtomasyonuEntities.Models.CafeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
