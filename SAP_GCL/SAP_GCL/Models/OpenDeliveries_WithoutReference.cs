using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class OpenDeliveries_WithoutReference
    {
        public int ID { get; set; }
        [MaxLength(6)]
        public string REF_ITEM { get; set; }
        [MaxLength(18)]
        public string MATERIAL { get; set; }
        [MaxLength(4)]
        public string ITEM_CATEG { get; set; }
        [MaxLength(13)]
        public string DLV_QTY { get; set; }
        [MaxLength(3)]
        public string SALES_UNIT { get; set; }
        [MaxLength(3)]
        public string SALES_UNIT_ISO { get; set; }
        [MaxLength(4)]
        public string PLANT { get; set; }
        [MaxLength(4)]
        public string STGE_LOC { get; set; }
        [MaxLength(40)]
        public string SHORT_TEXT { get; set; }
        [MaxLength(10)]
        public string DELIV_NUMB { get; set; }
        [MaxLength(40)]
        public string MATERIAL_EXTERNAL { get; set; }
        [MaxLength(32)]
        public string MATERIAL_GUID { get; set; }
        [MaxLength(10)]
        public string MATERIAL_VERSION { get; set; }

    }
}