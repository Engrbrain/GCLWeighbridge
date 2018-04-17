namespace SAP_GCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OutboundDeliveries2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OutboundDeliveries", "SAP_Quantity", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OutboundDeliveries", "SAP_Quantity");
        }
    }
}
