namespace MonsterHunterAPI.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elements",
                c => new
                    {
                        ElementId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ElementId);
            
            CreateTable(
                "dbo.EquipmentElements",
                c => new
                    {
                        EquipmentElementId = c.Int(nullable: false, identity: true),
                        WeaponId = c.Int(nullable: false),
                        ElementId = c.Int(nullable: false),
                        ElementDamange = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EquipmentElementId)
                .ForeignKey("dbo.Elements", t => t.ElementId, cascadeDelete: true)
                .Index(t => t.ElementId);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        WeaponId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Attack = c.Int(nullable: false),
                        Rarity = c.Int(nullable: false),
                        Sharpness = c.String(),
                        Slots = c.Int(nullable: false),
                        Affinity = c.Int(nullable: false),
                        Defense = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WeaponId);
            
            CreateTable(
                "dbo.WeaponEquipmentElements",
                c => new
                    {
                        Weapon_WeaponId = c.Int(nullable: false),
                        EquipmentElement_EquipmentElementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Weapon_WeaponId, t.EquipmentElement_EquipmentElementId })
                .ForeignKey("dbo.Weapons", t => t.Weapon_WeaponId, cascadeDelete: true)
                .ForeignKey("dbo.EquipmentElements", t => t.EquipmentElement_EquipmentElementId, cascadeDelete: true)
                .Index(t => t.Weapon_WeaponId)
                .Index(t => t.EquipmentElement_EquipmentElementId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeaponEquipmentElements", "EquipmentElement_EquipmentElementId", "dbo.EquipmentElements");
            DropForeignKey("dbo.WeaponEquipmentElements", "Weapon_WeaponId", "dbo.Weapons");
            DropForeignKey("dbo.EquipmentElements", "ElementId", "dbo.Elements");
            DropIndex("dbo.WeaponEquipmentElements", new[] { "EquipmentElement_EquipmentElementId" });
            DropIndex("dbo.WeaponEquipmentElements", new[] { "Weapon_WeaponId" });
            DropIndex("dbo.EquipmentElements", new[] { "ElementId" });
            DropTable("dbo.WeaponEquipmentElements");
            DropTable("dbo.Weapons");
            DropTable("dbo.EquipmentElements");
            DropTable("dbo.Elements");
        }
    }
}
