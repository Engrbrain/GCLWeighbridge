namespace SAP_GCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludeLoadingTables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GoodMovements", "ref_doc");
            DropColumn("dbo.GoodMovements", "prod_date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GoodMovements", "prod_date", c => c.String(maxLength: 12));
            AddColumn("dbo.GoodMovements", "ref_doc", c => c.String(maxLength: 15));
        }
    }
}
