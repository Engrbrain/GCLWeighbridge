using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAP_GCL.Models
{
    public class Material
    {
        public int ID { get; set; }
        public string Item_Name { get; set; }
        public string Item_Code_No { get; set; }
        public string Item_Unit { get; set; }
        public string Item_Type { get; set; }
        public int Item_Prise { get; set; }
        public int Item_Max_Qty { get; set; }
        public int Item_Min_Qty { get; set; }
        public int Item_Code { get; set; }
        public int CoCode { get; set; }
        public int YearID { get; set; }
        public int UserID { get; set; }
        public int EntryDate { get; set; }
        public int UpdateDate { get; set; }
    }
}