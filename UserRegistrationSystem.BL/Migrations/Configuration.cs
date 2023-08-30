namespace UserRegistrationSystem.BL.Migrations
{
    using System.Data.Entity.Migrations;
    using UserRegistrationSystem.BL.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<UserRegistrationSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(UserRegistrationSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}