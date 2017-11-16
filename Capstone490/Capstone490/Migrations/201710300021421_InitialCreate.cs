namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questions");
        }
    }
}
