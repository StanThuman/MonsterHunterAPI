namespace MonsterHunterAPI.Dal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MonsterHunterAPI.Dal.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MonsterHunterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MonsterHunterAPI.Dal.Models.MonsterHunterContext context)
        {
            //  This method will be called after migrating to the latest version.
            //Data.InputData(context);
            
            //context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
