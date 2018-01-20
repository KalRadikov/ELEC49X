namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tagAdded3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interests", "Tag", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Interests", "Tag");
        }
    }
}
