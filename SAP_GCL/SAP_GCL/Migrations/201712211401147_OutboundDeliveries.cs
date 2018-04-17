namespace SAP_GCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OutboundDeliveries : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OutboundDeliveries", "batch_no", c => c.String(maxLength: 20));
            AlterColumn("dbo.OutboundDeliveries", "document_numb", c => c.String(maxLength: 15));
            AlterColumn("dbo.OutboundDeliveries", "document_item", c => c.String(maxLength: 5));
            AlterColumn("dbo.OutboundDeliveries", "ship_to", c => c.String(maxLength: 15));
            AlterColumn("dbo.OutboundDeliveries", "sold_to", c => c.String(maxLength: 15));
            AlterColumn("dbo.OutboundDeliveries", "sales_organisation", c => c.String(maxLength: 8));
            AlterColumn("dbo.OutboundDeliveries", "distribution_channel", c => c.String(maxLength: 8));
            AlterColumn("dbo.OutboundDeliveries", "division", c => c.String(maxLength: 8));
            AlterColumn("dbo.OutboundDeliveries", "plant", c => c.String(maxLength: 8));
            AlterColumn("dbo.OutboundDeliveries", "sales_unit", c => c.String(maxLength: 20));
            AlterColumn("dbo.OutboundDeliveries", "base_uom", c => c.String(maxLength: 8));
            AlterColumn("dbo.OutboundDeliveries", "material", c => c.String(maxLength: 150));
            AlterColumn("dbo.OutboundDeliveries", "delivery_date", c => c.String(maxLength: 12));
            AlterColumn("dbo.OutboundDeliveries", "delivery_time", c => c.String(maxLength: 12));
            AlterColumn("dbo.OutboundDeliveries", "transp_plan_date", c => c.String(maxLength: 12));
            AlterColumn("dbo.OutboundDeliveries", "loading_date", c => c.String(maxLength: 12));
            AlterColumn("dbo.OutboundDeliveries", "goods_issue_date", c => c.String(maxLength: 12));
            AlterColumn("dbo.OutboundDeliveries", "extdelv_no", c => c.String(maxLength: 15));
            AlterColumn("dbo.OutboundDeliveries", "document_type", c => c.String(maxLength: 5));
            AlterColumn("dbo.OutboundDeliveries", "document_type_predecessor", c => c.String(maxLength: 5));
            AlterColumn("dbo.OutboundDeliveries", "document_type_delivery", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OutboundDeliveries", "document_type_delivery", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "document_type_predecessor", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "document_type", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "extdelv_no", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "goods_issue_date", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "loading_date", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "transp_plan_date", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "delivery_time", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "delivery_date", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "material", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "base_uom", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "sales_unit", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "plant", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "division", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "distribution_channel", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "sales_organisation", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "sold_to", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "ship_to", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "document_item", c => c.String());
            AlterColumn("dbo.OutboundDeliveries", "document_numb", c => c.String());
            DropColumn("dbo.OutboundDeliveries", "batch_no");
        }
    }
}
