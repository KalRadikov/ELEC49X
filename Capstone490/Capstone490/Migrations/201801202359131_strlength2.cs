namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class strlength2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Interests", "TempTag");
            DropColumn("dbo.Surveys", "TempTag");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "TempTag", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Interests", "TempTag", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
