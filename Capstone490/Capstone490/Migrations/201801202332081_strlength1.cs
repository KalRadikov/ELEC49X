namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class strlength1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interests", "TempTag", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Surveys", "TempTag", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surveys", "TempTag");
            DropColumn("dbo.Interests", "TempTag");
        }
    }
}
