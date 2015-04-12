namespace First_Responder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Members : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DriverTypes",
                c => new
                    {
                        DriverTypeID = c.Int(nullable: false, identity: true),
                        DriverTypeName = c.String(),
                    })
                .PrimaryKey(t => t.DriverTypeID);
            
            CreateTable(
                "dbo.Ranks",
                c => new
                    {
                        RankID = c.Int(nullable: false, identity: true),
                        RankName = c.String(),
                    })
                .PrimaryKey(t => t.RankID);
            
            CreateTable(
                "dbo.RoleTypes",
                c => new
                    {
                        RoleTypeID = c.Int(nullable: false, identity: true),
                        RoleTypeName = c.String(),
                    })
                .PrimaryKey(t => t.RoleTypeID);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateID = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.StateID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.States");
            DropTable("dbo.RoleTypes");
            DropTable("dbo.Ranks");
            DropTable("dbo.DriverTypes");
        }
    }
}
