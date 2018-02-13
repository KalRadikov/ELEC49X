namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clubs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        ClubID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category1 = c.String(),
                        Category2 = c.String(),
                        Category3 = c.String(),
                        Openness = c.Double(nullable: false),
                        Conscientiousness = c.Double(nullable: false),
                        Extraversion = c.Double(nullable: false),
                        Agreeableness = c.Double(nullable: false),
                        Neuroticism = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ClubID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clubs");
        }
    }
}
