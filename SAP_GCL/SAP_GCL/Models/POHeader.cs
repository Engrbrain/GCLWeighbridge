using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class POHeader
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string EBELN { get; set; }
        [MaxLength(4)]
        public string BUKRS { get; set; }
        [MaxLength(4)]
        public string BSART { get; set; }
        [MaxLength(5)]
        public string PINCR { get; set; }
        [MaxLength(10)]
        public string LIFNR { get; set; }
        [MaxLength(2)]
        public string SPRAS { get; set; }
        [MaxLength(4)]
        public string ZTERM { get; set; }
        [MaxLength(4)]
        public string EKORG { get; set; }
        [MaxLength(3)]
        public string EKGRP { get; set; }
        [MaxLength(5)]
        public string WAERS { get; set; }
        [MaxLength(34)]
        public string BEDAT { get; set; }
        [MaxLength(30)]
        public string VERKF { get; set; }
        [MaxLength(10)]
        public string LLIEF { get; set; }
        [MaxLength(3)]
        public string INCO1 { get; set; }
        [MaxLength(28)]
        public string INCO2 { get; set; }
        [MaxLength(5)]
        public string UPINC { get; set; }
        [MaxLength(3)]
        public string STCEG_L { get; set; }

    }
}