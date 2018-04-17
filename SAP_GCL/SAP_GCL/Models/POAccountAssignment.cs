using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class OpenDeliveries_Header
    {
        public int ID { get; set; }
        [MaxLength(10)]
        public string DELIV_NUMB { get; set; }
        [MaxLength(4)]
        public string SHIP_POINT { get; set; }
        [MaxLength(4)]
        public string DLV_TYPE { get; set; }
        [MaxLength(4)]
        public string SALESORG { get; set; }
        [MaxLength(2)]
        public string DISTR_CHAN { get; set; }
        [MaxLength(2)]
        public string DIVISION { get; set; }
        [MaxLength(10)]
        public string SHIP_TO { get; set; }
        [MaxLength(1)]
        public string DATE_USAGE { get; set; }
        [MaxLength(1)]
        public string DEBUG_FLG { get; set; }

    }
}