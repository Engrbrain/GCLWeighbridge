namespace SAP_GCL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GoodRecieptNotes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        pstng_date = c.String(),
                        doc_date = c.String(),
                        pr_uname = c.String(),
                        ref_doc_no = c.String(),
                        material = c.String(),
                        plant = c.String(),
                        stge_loc = c.String(),
                        move_type = c.String(),
                        po_number = c.String(),
                        po_item = c.String(),
                        entry_qnt = c.String(),
                        entry_uom = c.String(),
                        ref_doc = c.String(),
                        prod_date = c.String(),
                        mvt_ind = c.String(),
                        gm_code = c.String(),
                        SAP_quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item_Name = c.String(),
                        Item_Code_No = c.String(),
                        Item_Unit = c.String(),
                        Item_Type = c.String(),
                        Item_Prise = c.Int(nullable: false),
                        Item_Max_Qty = c.Int(nullable: false),
                        Item_Min_Qty = c.Int(nullable: false),
                        Item_Code = c.Int(nullable: false),
                        CoCode = c.Int(nullable: false),
                        YearID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        EntryDate = c.Int(nullable: false),
                        UpdateDate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OutboundDeliveries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        document_numb = c.String(),
                        document_item = c.String(),
                        ship_to = c.String(),
                        sold_to = c.String(),
                        sales_organisation = c.String(),
                        distribution_channel = c.String(),
                        division = c.String(),
                        plant = c.String(),
                        sales_unit = c.String(),
                        base_uom = c.String(),
                        material = c.String(),
                        delivery_date = c.String(),
                        delivery_time = c.String(),
                        transp_plan_date = c.String(),
                        loading_date = c.String(),
                        goods_issue_date = c.String(),
                        extdelv_no = c.String(),
                        document_type = c.String(),
                        document_type_predecessor = c.String(),
                        document_type_delivery = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.OutboundDeliveries");
            DropTable("dbo.Materials");
            DropTable("dbo.GoodRecieptNotes");
        }
    }
}
