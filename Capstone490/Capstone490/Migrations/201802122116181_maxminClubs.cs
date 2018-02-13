namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maxminClubs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clubs", "O_Max", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "O_Min", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "C_Max", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "C_Min", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "E_Max", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "E_Min", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "A_Max", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "A_Min", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "N_Max", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "N_Min", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "Error", c => c.Double(nullable: false));
            DropColumn("dbo.Clubs", "Openness");
            DropColumn("dbo.Clubs", "Conscientiousness");
            DropColumn("dbo.Clubs", "Extraversion");
            DropColumn("dbo.Clubs", "Agreeableness");
            DropColumn("dbo.Clubs", "Neuroticism");
            DropColumn("dbo.Clubs", "Weight");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clubs", "Weight", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "Neuroticism", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "Agreeableness", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "Extraversion", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "Conscientiousness", c => c.Double(nullable: false));
            AddColumn("dbo.Clubs", "Openness", c => c.Double(nullable: false));
            DropColumn("dbo.Clubs", "Error");
            DropColumn("dbo.Clubs", "N_Min");
            DropColumn("dbo.Clubs", "N_Max");
            DropColumn("dbo.Clubs", "A_Min");
            DropColumn("dbo.Clubs", "A_Max");
            DropColumn("dbo.Clubs", "E_Min");
            DropColumn("dbo.Clubs", "E_Max");
            DropColumn("dbo.Clubs", "C_Min");
            DropColumn("dbo.Clubs", "C_Max");
            DropColumn("dbo.Clubs", "O_Min");
            DropColumn("dbo.Clubs", "O_Max");
        }
    }
}
