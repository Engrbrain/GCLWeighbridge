using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public class InventoryBalances_LineItem
    {
        public int ID { get; set; }
        [MaxLength(3)]
        public string BWART { get; set; }
        [MaxLength(4)]
        public string WERKS { get; set; }
        [MaxLength(18)]
        public string MATNR { get; set; }
        [MaxLength(4)]
        public string LGORT { get; set; }
        [MaxLength(10)]
        public string CHARG { get; set; }
        [MaxLength(1)]
        public string INSMK { get; set; }
        [MaxLength(1)]
        public string SOBKZ { get; set; }
        [MaxLength(10)]
        public string LIFNR { get; set; }
        [MaxLength(10)]
        public string KUNNR { get; set; }
        [MaxLength(10)]
        public string KDAUF { get; set; }
        [MaxLength(6)]
        public string KDPOS { get; set; }
        [MaxLength(4)]
        public string KDEIN { get; set; }
        [MaxLength(10)]
        public string BWTAR { get; set; }
        [MaxLength(48)]
        public string ERFMG { get; set; }
        [MaxLength(3)]
        public string ERFME { get; set; }
        [MaxLength(48)]
        public string BPMNG { get; set; }
        [MaxLength(3)]
        public string BPRME { get; set; }
        [MaxLength(10)]
        public string EBELN { get; set; }
        [MaxLength(5)]
        public string EBELP { get; set; }
        [MaxLength(2)]
        public string EVERS { get; set; }
        [MaxLength(2)]
        public string EVERE { get; set; }
        [MaxLength(1)]
        public string ELIKZ { get; set; }
        [MaxLength(50)]
        public string SGTXT { get; set; }
        [MaxLength(12)]
        public string WEMPF { get; set; }
        [MaxLength(25)]
        public string ABLAD { get; set; }
        [MaxLength(10)]
        public string KOSTL { get; set; }
        [MaxLength(12)]
        public string AUFNR { get; set; }
        [MaxLength(4)]
        public string AUFPS { get; set; }
        [MaxLength(2)]
        public string BEMOT { get; set; }
        [MaxLength(12)]
        public string ANLN1 { get; set; }
        [MaxLength(4)]
        public string ANLN2 { get; set; }
        [MaxLength(10)]
        public string RSNUM { get; set; }
        [MaxLength(4)]
        public string RSPOS { get; set; }
        [MaxLength(1)]
        public string RSART { get; set; }
        [MaxLength(1)]
        public string KZEAR { get; set; }
        [MaxLength(18)]
        public string UMMAT { get; set; }
        [MaxLength(4)]
        public string UMWRK { get; set; }
        [MaxLength(4)]
        public string UMLGO { get; set; }
        [MaxLength(10)]
        public string UMCHA { get; set; }
        [MaxLength(10)]
        public string UMBAR { get; set; }
        [MaxLength(1)]
        public string KZBEW { get; set; }
        [MaxLength(4)]
        public string GRUND { get; set; }
        [MaxLength(8)]
        public string IMKEY { get; set; }
        [MaxLength(24)]
        public string DABRBZ { get; set; }
        [MaxLength(12)]
        public string KSTRG { get; set; }
        [MaxLength(10)]
        public string PAOBJNR { get; set; }
        [MaxLength(10)]
        public string PRCTR { get; set; }
        [MaxLength(24)]
        public string PS_PSP_PNR { get; set; }
        [MaxLength(12)]
        public string NPLNR { get; set; }
        [MaxLength(10)]
        public string VPTNR { get; set; }
        [MaxLength(23)]
        public string EXBWR { get; set; }
        [MaxLength(23)]
        public string EXVKW { get; set; }
        [MaxLength(4)]
        public string LFBJA { get; set; }
        [MaxLength(10)]
        public string LFBNR { get; set; }
        [MaxLength(4)]
        public string LFPOS { get; set; }
        [MaxLength(24)]
        public string VFDAT { get; set; }
        [MaxLength(24)]
        public string HSDAT { get; set; }
        [MaxLength(10)]
        public string GEBER { get; set; }
        [MaxLength(16)]
        public string FISTL { get; set; }
        [MaxLength(14)]
        public string FIPOS { get; set; }
        [MaxLength(10)]
        public string MAT_KDAUF { get; set; }
        [MaxLength(6)]
        public string MAT_KDPOS { get; set; }
        [MaxLength(24)]
        public string MAT_PSPNR { get; set; }
        [MaxLength(10)]
        public string SAKTO { get; set; }
        [MaxLength(3)]
        public string LGTYP { get; set; }
        [MaxLength(10)]
        public string LGPLA { get; set; }
        [MaxLength(6)]
        public string LSTAR { get; set; }
        [MaxLength(10)]
        public string LLIEF { get; set; }
        [MaxLength(4)]
        public string FKBER { get; set; }
        [MaxLength(4)]
        public string PARGB { get; set; }
        [MaxLength(4)]
        public string PARBU { get; set; }

    }
}