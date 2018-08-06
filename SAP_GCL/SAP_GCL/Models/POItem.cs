using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class POItem
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string EBELN { get; set; }
        [MaxLength(5)]
        public string EBELP { get; set; }
        [MaxLength(40)]
        public string TXZ0 { get; set; }
        [MaxLength(18)]
        public string MATNR { get; set; }
        [MaxLength(4)]
        public string WERKS { get; set; }
        [MaxLength(4)]
        public string LGORT { get; set; }
        [MaxLength(10)]
        public string BEDNR { get; set; }
        [MaxLength(9)]
        public string MATKL { get; set; }
        [MaxLength(48)]
        public string MENGE { get; set; }
        [MaxLength(3)]
        public string MEINS { get; set; }
        [MaxLength(3)]
        public string BPRME { get; set; }
        [MaxLength(5)]
        public string BPUMZ { get; set; }
        [MaxLength(5)]
        public string BPUMN { get; set; }
        [MaxLength(28)]
        public string NET_PRICE { get; set; }
        [MaxLength(5)]
        public string PEINH { get; set; }
        [MaxLength(2)]
        public string MWSKZ { get; set; }
        [MaxLength(1)]
        public string SPINF { get; set; }
        [MaxLength(1)]
        public string PRSDR { get; set; }
        [MaxLength(3)]
        public string MAHN1 { get; set; }
        [MaxLength(3)]
        public string MAHN2 { get; set; }
        [MaxLength(3)]
        public string MAHN3 { get; set; }
        [MaxLength(1)]
        public string KNTTP { get; set; }
        [MaxLength(1)]
        public string WEPOS { get; set; }
        [MaxLength(1)]
        public string REPOS { get; set; }
        [MaxLength(1)]
        public string WEBRE { get; set; }
        [MaxLength(1)]
        public string KZABS { get; set; }
        [MaxLength(3)]
        public string PLIFZ { get; set; }
        [MaxLength(48)]
        public string NTGEW { get; set; }
        [MaxLength(3)]
        public string GEWEI { get; set; }
        [MaxLength(15)]
        public string TXJCD { get; set; }
        [MaxLength(4)]
        public string BSTAE { get; set; }
        [MaxLength(24)]
        public string PRDAT { get; set; }
        [MaxLength(48)]
        public string BRGEW { get; set; }
        [MaxLength(3)]
        public string INCO1 { get; set; }
        [MaxLength(28)]
        public string INCO2 { get; set; }

    }
}