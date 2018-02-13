namespace Capstone490.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clubSP : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Club_Insert",
                p => new
                    {
                        Name = p.String(),
                        Category1 = p.String(),
                        Category2 = p.String(),
                        Category3 = p.String(),
                        O_Max = p.Double(),
                        O_Min = p.Double(),
                        C_Max = p.Double(),
                        C_Min = p.Double(),
                        E_Max = p.Double(),
                        E_Min = p.Double(),
                        A_Max = p.Double(),
                        A_Min = p.Double(),
                        N_Max = p.Double(),
                        N_Min = p.Double(),
                        Error = p.Double(),
                    },
                body:
                    @"INSERT [dbo].[Clubs]([Name], [Category1], [Category2], [Category3], [O_Max], [O_Min], [C_Max], [C_Min], [E_Max], [E_Min], [A_Max], [A_Min], [N_Max], [N_Min], [Error])
                      VALUES (@Name, @Category1, @Category2, @Category3, @O_Max, @O_Min, @C_Max, @C_Min, @E_Max, @E_Min, @A_Max, @A_Min, @N_Max, @N_Min, @Error)
                      
                      DECLARE @ClubID int
                      SELECT @ClubID = [ClubID]
                      FROM [dbo].[Clubs]
                      WHERE @@ROWCOUNT > 0 AND [ClubID] = scope_identity()
                      
                      SELECT t0.[ClubID]
                      FROM [dbo].[Clubs] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[ClubID] = @ClubID"
            );
            
            CreateStoredProcedure(
                "dbo.Club_Update",
                p => new
                    {
                        ClubID = p.Int(),
                        Name = p.String(),
                        Category1 = p.String(),
                        Category2 = p.String(),
                        Category3 = p.String(),
                        O_Max = p.Double(),
                        O_Min = p.Double(),
                        C_Max = p.Double(),
                        C_Min = p.Double(),
                        E_Max = p.Double(),
                        E_Min = p.Double(),
                        A_Max = p.Double(),
                        A_Min = p.Double(),
                        N_Max = p.Double(),
                        N_Min = p.Double(),
                        Error = p.Double(),
                    },
                body:
                    @"UPDATE [dbo].[Clubs]
                      SET [Name] = @Name, [Category1] = @Category1, [Category2] = @Category2, [Category3] = @Category3, [O_Max] = @O_Max, [O_Min] = @O_Min, [C_Max] = @C_Max, [C_Min] = @C_Min, [E_Max] = @E_Max, [E_Min] = @E_Min, [A_Max] = @A_Max, [A_Min] = @A_Min, [N_Max] = @N_Max, [N_Min] = @N_Min, [Error] = @Error
                      WHERE ([ClubID] = @ClubID)"
            );
            
            CreateStoredProcedure(
                "dbo.Club_Delete",
                p => new
                    {
                        ClubID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Clubs]
                      WHERE ([ClubID] = @ClubID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Club_Delete");
            DropStoredProcedure("dbo.Club_Update");
            DropStoredProcedure("dbo.Club_Insert");
        }
    }
}
