namespace SAP_GCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataManager : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataManagers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PackageName = c.String(maxLength: 25),
                        PackageType = c.Int(nullable: false),
                        LoadingDate = c.DateTime(nullable: false),
                        Extracted_Count = c.Int(nullable: false),
                        Loaded_Count = c.Int(nullable: false),
                        Error_Count = c.Int(nullable: false),
                        Load_Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DataManagers");
        }
    }
}
