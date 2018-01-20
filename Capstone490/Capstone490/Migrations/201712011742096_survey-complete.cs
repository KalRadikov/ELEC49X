namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class surveycomplete : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Interests",
                c => new
                    {
                        InterestsID = c.Int(nullable: false, identity: true),
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
                        Q11 = c.Int(nullable: false),
                        Q12 = c.Int(nullable: false),
                        Q13 = c.Int(nullable: false),
                        Q14 = c.Int(nullable: false),
                        Q15 = c.Int(nullable: false),
                        Q16 = c.Int(nullable: false),
                        Q17 = c.Int(nullable: false),
                        Q18 = c.Int(nullable: false),
                        Q19 = c.Int(nullable: false),
                        Q20 = c.Int(nullable: false),
                        Q21 = c.Int(nullable: false),
                        Q22 = c.Int(nullable: false),
                        Q23 = c.Int(nullable: false),
                        Q24 = c.Int(nullable: false),
                        Q25 = c.Int(nullable: false),
                        Q26 = c.Int(nullable: false),
                        Q27 = c.Int(nullable: false),
                        Q28 = c.Int(nullable: false),
                        Q29 = c.Int(nullable: false),
                        Q30 = c.Int(nullable: false),
                        Q31 = c.Int(nullable: false),
                        Q32 = c.Int(nullable: false),
                        Q33 = c.Int(nullable: false),
                        Q34 = c.Int(nullable: false),
                        Q35 = c.Int(nullable: false),
                        Q36 = c.Int(nullable: false),
                        Q37 = c.Int(nullable: false),
                        Q38 = c.Int(nullable: false),
                        Q39 = c.Int(nullable: false),
                        Q40 = c.Int(nullable: false),
                        Q41 = c.Int(nullable: false),
                        Q42 = c.Int(nullable: false),
                        Q43 = c.Int(nullable: false),
                        Q44 = c.Int(nullable: false),
                        Q45 = c.Int(nullable: false),
                        Q46 = c.Int(nullable: false),
                        Q47 = c.Int(nullable: false),
                        Q48 = c.Int(nullable: false),
                        Q49 = c.Int(nullable: false),
                        Q50 = c.Int(nullable: false),
                        Q51 = c.Int(nullable: false),
                        Q52 = c.Int(nullable: false),
                        Q53 = c.Int(nullable: false),
                        Q54 = c.Int(nullable: false),
                        Q55 = c.Int(nullable: false),
                        Q56 = c.Int(nullable: false),
                        Q57 = c.Int(nullable: false),
                        Q58 = c.Int(nullable: false),
                        Q59 = c.Int(nullable: false),
                        Q60 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InterestsID);
            
            AddColumn("dbo.Surveys", "Q11", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q12", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q13", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q14", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q15", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q16", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q17", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q18", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q19", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q20", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q21", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q22", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q23", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q24", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q25", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q26", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q27", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q28", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q29", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q30", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q31", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q32", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q33", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q34", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q35", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q36", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q37", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q38", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q39", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q40", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q41", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q42", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q43", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "Q44", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surveys", "Q44");
            DropColumn("dbo.Surveys", "Q43");
            DropColumn("dbo.Surveys", "Q42");
            DropColumn("dbo.Surveys", "Q41");
            DropColumn("dbo.Surveys", "Q40");
            DropColumn("dbo.Surveys", "Q39");
            DropColumn("dbo.Surveys", "Q38");
            DropColumn("dbo.Surveys", "Q37");
            DropColumn("dbo.Surveys", "Q36");
            DropColumn("dbo.Surveys", "Q35");
            DropColumn("dbo.Surveys", "Q34");
            DropColumn("dbo.Surveys", "Q33");
            DropColumn("dbo.Surveys", "Q32");
            DropColumn("dbo.Surveys", "Q31");
            DropColumn("dbo.Surveys", "Q30");
            DropColumn("dbo.Surveys", "Q29");
            DropColumn("dbo.Surveys", "Q28");
            DropColumn("dbo.Surveys", "Q27");
            DropColumn("dbo.Surveys", "Q26");
            DropColumn("dbo.Surveys", "Q25");
            DropColumn("dbo.Surveys", "Q24");
            DropColumn("dbo.Surveys", "Q23");
            DropColumn("dbo.Surveys", "Q22");
            DropColumn("dbo.Surveys", "Q21");
            DropColumn("dbo.Surveys", "Q20");
            DropColumn("dbo.Surveys", "Q19");
            DropColumn("dbo.Surveys", "Q18");
            DropColumn("dbo.Surveys", "Q17");
            DropColumn("dbo.Surveys", "Q16");
            DropColumn("dbo.Surveys", "Q15");
            DropColumn("dbo.Surveys", "Q14");
            DropColumn("dbo.Surveys", "Q13");
            DropColumn("dbo.Surveys", "Q12");
            DropColumn("dbo.Surveys", "Q11");
            DropTable("dbo.Interests");
        }
    }
}
