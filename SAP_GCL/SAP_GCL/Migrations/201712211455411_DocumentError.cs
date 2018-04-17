namespace SAP_GCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentError : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentErrors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TicketNumber = c.String(maxLength: 15),
                        SlipCode = c.String(maxLength: 15),
                        Vehicle_No = c.String(maxLength: 15),
                        Item_Code = c.String(maxLength: 15),
                        Netwt = c.String(maxLength: 15),
                        GrossDate = c.String(maxLength: 15),
                        SAPReference = c.String(maxLength: 15),
                        TransactionType = c.Int(nullable: false),
                        ErrorType = c.Int(nullable: false),
                        ErrorDescription = c.String(maxLength: 1000),
                        Recommendation = c.String(maxLength: 1000),
                        LoadingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DocumentErrors");
        }
    }
}
