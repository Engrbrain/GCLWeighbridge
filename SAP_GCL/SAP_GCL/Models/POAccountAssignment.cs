using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class POAccountAssignment
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string EBELN { get; set; }
        [MaxLength(5)]
        public string EBELP { get; set; }
        [MaxLength(2)]
        public string ZEKKN { get; set; }
        [MaxLength(48)]
        public string MENGE { get; set; }
        [MaxLength(28)]
        public string NET_VALUE { get; set; }
        [MaxLength(10)]
        public string SAKTO { get; set; }
        [MaxLength(10)]
        public string KOSTL { get; set; }
        [MaxLength(4)]
        public string KOKRS { get; set; }
        [MaxLength(4)]
        public string FKBER { get; set; }

    }
}