using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public enum PacType
    {
        PurchaseOrder,
        SalesOrder,
        GoodsMovement,
        MaterialMaster
    }
    public class DataManager
    {
        public int ID { get; set; }
        [MaxLength(25)]
        public string PackageName { get; set; }
        public PacType PackageType { get; set; }
        public DateTime LoadingDate { get; set; }
        public int Extracted_Count { get; set; }
        public int Loaded_Count { get; set; }
        public int Error_Count { get; set; }
        public string Load_Status { get; set; }

    }
}