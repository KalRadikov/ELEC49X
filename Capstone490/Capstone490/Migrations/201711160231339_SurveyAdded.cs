namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SurveyAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyID = c.Int(nullable: false, identity: true),
                        Q1 = c.Int(nullable: false),
                        Q2 = c.Int(nullable: false),
                        Q3 = c.Int(nullable: false),
                        Q4 = c.Int(nullable: false),
                        Q5 = c.Int(nullable: false),
                        Q6 = c.Int(nullable: false),
                        Q7 = c.Int(nullable: false),
                        Q8 = c.Int(nullable: false),
                        Q9 = c.Int(nullable: false),
                        Q10 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SurveyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Surveys");
        }
    }
}
