using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class InventoryBalances_Header
    {
        public int ID { get; set; }
        [MaxLength(6)]
        public string BWART { get; set; }
        [MaxLength(6)]
        public string WERKS { get; set; }
        [MaxLength(6)]
        public string BUDAT { get; set; }
        [MaxLength(6)]
        public string BLDAT { get; set; }
        [MaxLength(6)]
        public string XBLNR { get; set; }
        [MaxLength(6)]
        public string FRBNR { get; set; }
        [MaxLength(6)]
        public string XABLN { get; set; }
        [MaxLength(6)]
        public string USNAM { get; set; }
        [MaxLength(6)]
        public string BKTXT { get; set; }
        [MaxLength(6)]
        public string WEVER { get; set; }
        [MaxLength(6)]
        public string BFWMS { get; set; }


    }
}