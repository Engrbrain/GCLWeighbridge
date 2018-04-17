using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class OpenDeliveries_DeliveryDeadline
    {
        public int ID { get; set; }
        [MaxLength(10)]
        public string DELIV_NUMB { get; set; }
        [MaxLength(10)]
        public string TIMETYPE { get; set; }
        [MaxLength(15)]
        public string TIMESTAMP_UTC { get; set; }
        [MaxLength(6)]
        public string TIMEZONE { get; set; }


    }
}