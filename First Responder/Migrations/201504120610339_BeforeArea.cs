namespace First_Responder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BeforeArea : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Pages");
        }
        
        public override void Down()
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
            
        }
    }
}
