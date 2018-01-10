namespace MonsterHunterAPI.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Elements", "name", "Name");
        }
        
        public override void Down()
        {
        }
    }
}
