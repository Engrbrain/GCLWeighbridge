using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class SelectGoodMovementEditorViewModel
    {
        public bool Selected { get; set; }
        public int ID { get; set; }
        [MaxLength(50), Display(Name = "Posting Date")]
        public string pstng_date { get; set; }
        [MaxLength(12), Display(Name = "Document Date")]
        public string doc_date { get; set; }
        [MaxLength(12), Display(Name = "Username")]
        public string pr_uname { get; set; }
        [MaxLength(50), Display(Name = "Reference Document")]
        public string ref_doc_no { get; set; }
        [MaxLength(50), Display(Name = "Material")]
        public string material { get; set; }
        [MaxLength(5), Display(Name = "Plant")]
        public string plant { get; set; }
        [MaxLength(6), Display(Name = "Storage Location")]
        public string stge_loc { get; set; }
        [MaxLength(4), Display(Name = "Movement Type")]
        public string move_type { get; set; }
        [MaxLength(15), Display(Name = "Purchase Order Number")]
        public string po_number { get; set; }
        [MaxLength(5), Display(Name = "Purchase Order Item")]
        public string po_item { get; set; }
        [MaxLength(10), Display(Name = "Quantity")]
        public double entry_qnt { get; set; }
        [MaxLength(10), Display(Name = "Unit of Measure")]
        public string entry_uom { get; set; }
        [MaxLength(5), Display(Name = "Movement Indicator")]
        public string mvt_ind { get; set; }
        [MaxLength(5)]
        public string gm_code { get; set; }
        [MaxLength(15)]
        public double SAP_quantity { get; set; }

        [MaxLength(15)]
        public string move_reas { get; set; }
        public int Changed_Quantity { get; set; }
        public double Changed_Weight { get; set; }
        public string ReasonForChange { get; set; }
        public string ChangedBy { get; set; }

    }
}