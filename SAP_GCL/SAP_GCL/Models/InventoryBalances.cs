using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class InventoryBalances
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string pstng_date { get; set; }
        [MaxLength(12)]
        public string doc_date { get; set; }
        [MaxLength(12)]
        public string pr_uname { get; set; }
        [MaxLength(50)]
        public string ref_doc_no { get; set; }
        [MaxLength(50)]
        public string material { get; set; }
        [MaxLength(5)]
        public string plant { get; set; }
        [MaxLength(6)]
        public string stge_loc { get; set; }
        [MaxLength(4)]
        public string move_type { get; set; }
        [MaxLength(15)]
        public string po_number { get; set; }
        [MaxLength(5)]
        public string po_item { get; set; }
        [MaxLength(10)]
        public string entry_qnt { get; set; }
        [MaxLength(10)]
        public string entry_uom { get; set; }
        [MaxLength(15)]
        public string ref_doc { get; set; }
        [MaxLength(12)]
        public string prod_date { get; set; }
        [MaxLength(5)]
        public string mvt_ind { get; set; }
        [MaxLength(5)]
        public string gm_code { get; set; }
        [MaxLength(15)]
        public string SAP_quantity { get; set; }

        [MaxLength(15)]
        public string move_reas { get; set; }

    }
}