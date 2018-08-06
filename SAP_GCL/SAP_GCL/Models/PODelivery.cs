using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class PODelivery
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string EBELN { get; set; }
        [MaxLength(5)]
        public string EBELP { get; set; }
        [MaxLength(4)]
        public string ETENR { get; set; }
        [MaxLength(1)]
        public string LPEIN { get; set; }
        [MaxLength(10)]
        public string EEIND { get; set; }
        [MaxLength(13)]
        public string ETMEN { get; set; }
        [MaxLength(6)]
        public string LZEIT { get; set; }
        [MaxLength(8)]
        public string SLFDT { get; set; }
        [MaxLength(10)]
        public string BANFN { get; set; }
        [MaxLength(5)]
        public string BNFPO { get; set; }
        [MaxLength(8)]
        public string ETBDT { get; set; }
        [MaxLength(10)]
        public string AULWE { get; set; }
        [MaxLength(8)]
        public string MBDAT { get; set; }
        [MaxLength(6)]
        public string MBUHR { get; set; }
        [MaxLength(8)]
        public string LDDAT { get; set; }
        [MaxLength(6)]
        public string LDUHR { get; set; }
        [MaxLength(8)]
        public string TDDAT_D { get; set; }
        [MaxLength(6)]
        public string TDUHR { get; set; }
        [MaxLength(8)]
        public string WADAT { get; set; }
        [MaxLength(6)]
        public string WAUHR { get; set; }
        [MaxLength(1)]
        public string ELOEK { get; set; }
        [MaxLength(1)]
        public string EBAKZ { get; set; }
        [MaxLength(8)]
        public string ELDAT { get; set; }
        [MaxLength(6)]
        public string ELUHR { get; set; }
        [MaxLength(13)]
        public string MNG06 { get; set; }
        [MaxLength(1)]
        public string DAT05 { get; set; }

    }
}