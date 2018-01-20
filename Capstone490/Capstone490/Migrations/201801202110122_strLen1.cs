namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class strLen1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Surveys", "Tag", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Surveys", "Tag", c => c.String(nullable: false));
        }
    }
}
