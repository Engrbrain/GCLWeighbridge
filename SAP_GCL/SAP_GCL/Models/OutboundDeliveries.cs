using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class OutboundDeliveries
    {
        public int ID { get; set; }
        [MaxLength(15)]
        public string document_numb { get; set; }
        [MaxLength(5)]
        public string document_item { get; set; }
        [MaxLength(15)]
        public string ship_to { get; set; }
        [MaxLength(15)]
        public string sold_to { get; set; }
        [MaxLength(8)]
        public string sales_organisation { get; set; }
        [MaxLength(8)]
        public string distribution_channel { get; set; }
        [MaxLength(8)]
        public string division { get; set; }
        [MaxLength(8)]
        public string plant { get; set; }
        [MaxLength(20)]
        public string sales_unit { get; set; }
        [MaxLength(8)]
        public string base_uom { get; set; }
        [MaxLength(150)]
        public string material { get; set; }
        [MaxLength(12)]
        public string delivery_date { get; set; }
        [MaxLength(12)]
        public string delivery_time { get; set; }
        [MaxLength(12)]
        public string transp_plan_date { get; set; }
        [MaxLength(12)]
        public string loading_date { get; set; }
        [MaxLength(12)]
        public string goods_issue_date { get; set; }
        [MaxLength(15)]
        public string extdelv_no { get; set; }
        [MaxLength(5)]
        public string document_type { get; set; }
        [MaxLength(5)]
        public string document_type_predecessor { get; set; }
        [MaxLength(12)]
        public string document_type_delivery { get; set; }
        [MaxLength(20)]
        public string batch_no { get; set; }

        [MaxLength(20)]
        public string SAP_Quantity { get; set; }
    }
}