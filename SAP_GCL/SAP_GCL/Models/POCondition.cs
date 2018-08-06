using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class POCondition
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string EBELN { get; set; }
        [MaxLength(10)]
        public string KNUMV { get; set; }
        [MaxLength(6)]
        public string ITM_NUMBER { get; set; }
        [MaxLength(3)]
        public string BPRME { get; set; }
        [MaxLength(5)]
        public string PEINH { get; set; }
        [MaxLength(8)]
        public string NETPR { get; set; }

    }
}