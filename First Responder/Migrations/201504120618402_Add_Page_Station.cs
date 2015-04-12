namespace First_Responder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Page_Station : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageId = c.Int(nullable: false, identity: true),
                        AuthorId = c.Int(nullable: false),
                        Slug = c.String(),
                        Title = c.String(),
                        Excerpt = c.String(),
                        OgImage = c.String(),
                        Body = c.String(),
                        Keywords = c.String(),
                        Published = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsNewsItem = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PageId);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        StationId = c.Int(nullable: false, identity: true),
                        StationName = c.String(),
                        Administrator = c.String(),
                        PhoneNumber = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.Int(nullable: false),
                        Zip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stations");
            DropTable("dbo.Pages");
        }
    }
}
