namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clubSP3 : DbMigration
    {
        public override void Up()
        {
            DropStoredProcedure("dbo.Club_Insert");
            DropStoredProcedure("dbo.Club_Update");
            DropStoredProcedure("dbo.Club_Delete");
        }
        
        public override void Down()
        {
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
