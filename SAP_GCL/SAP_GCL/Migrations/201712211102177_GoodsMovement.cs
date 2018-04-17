namespace SAP_GCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GoodsMovement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GoodMovements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        pstng_date = c.String(maxLength: 50),
                        doc_date = c.String(maxLength: 12),
                        pr_uname = c.String(maxLength: 12),
                        ref_doc_no = c.String(maxLength: 50),
                        material = c.String(maxLength: 50),
                        plant = c.String(maxLength: 5),
                        stge_loc = c.String(maxLength: 6),
                        move_type = c.String(maxLength: 4),
                        po_number = c.String(maxLength: 15),
                        po_item = c.String(maxLength: 5),
                        entry_qnt = c.String(maxLength: 10),
                        entry_uom = c.String(maxLength: 10),
                        ref_doc = c.String(maxLength: 15),
                        prod_date = c.String(maxLength: 12),
                        mvt_ind = c.String(maxLength: 5),
                        gm_code = c.String(maxLength: 5),
                        SAP_quantity = c.String(maxLength: 15),
                        move_reas = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GoodMovements");
        }
    }
}
