namespace First_Responder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class states : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ranks", "RankAbb", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ranks", "RankAbb");
        }
    }
}
