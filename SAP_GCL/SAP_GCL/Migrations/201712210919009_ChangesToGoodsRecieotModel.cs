namespace SAP_GCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesToGoodsRecieotModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GoodRecieptNotes", "pstng_date", c => c.String(maxLength: 50));
            AlterColumn("dbo.GoodRecieptNotes", "doc_date", c => c.String(maxLength: 12));
            AlterColumn("dbo.GoodRecieptNotes", "pr_uname", c => c.String(maxLength: 12));
            AlterColumn("dbo.GoodRecieptNotes", "ref_doc_no", c => c.String(maxLength: 50));
            AlterColumn("dbo.GoodRecieptNotes", "material", c => c.String(maxLength: 50));
            AlterColumn("dbo.GoodRecieptNotes", "plant", c => c.String(maxLength: 5));
            AlterColumn("dbo.GoodRecieptNotes", "stge_loc", c => c.String(maxLength: 6));
            AlterColumn("dbo.GoodRecieptNotes", "move_type", c => c.String(maxLength: 4));
            AlterColumn("dbo.GoodRecieptNotes", "po_number", c => c.String(maxLength: 15));
            AlterColumn("dbo.GoodRecieptNotes", "po_item", c => c.String(maxLength: 5));
            AlterColumn("dbo.GoodRecieptNotes", "entry_qnt", c => c.String(maxLength: 10));
            AlterColumn("dbo.GoodRecieptNotes", "entry_uom", c => c.String(maxLength: 10));
            AlterColumn("dbo.GoodRecieptNotes", "ref_doc", c => c.String(maxLength: 15));
            AlterColumn("dbo.GoodRecieptNotes", "prod_date", c => c.String(maxLength: 12));
            AlterColumn("dbo.GoodRecieptNotes", "mvt_ind", c => c.String(maxLength: 5));
            AlterColumn("dbo.GoodRecieptNotes", "gm_code", c => c.String(maxLength: 5));
            AlterColumn("dbo.GoodRecieptNotes", "SAP_quantity", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GoodRecieptNotes", "SAP_quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.GoodRecieptNotes", "gm_code", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "mvt_ind", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "prod_date", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "ref_doc", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "entry_uom", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "entry_qnt", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "po_item", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "po_number", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "move_type", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "stge_loc", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "plant", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "material", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "ref_doc_no", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "pr_uname", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "doc_date", c => c.String());
            AlterColumn("dbo.GoodRecieptNotes", "pstng_date", c => c.String());
        }
    }
}
