using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SAP_GCL.Models
{
    public enum ErrType
    {
        MissingReference,
        MissingMaterial,
        WrongSAPKey,
        ETLErrors
    }

    public enum TransType
    {
        PurchaseOrder,
        SalesOrder,
        GoodsMovement
    }
    public class DocumentErrors
    {
        public int ID { get; set; }
        [MaxLength(15)]
        public string TicketNumber { get; set; }
        [MaxLength(15)]
        public string SlipCode { get; set; }
        [MaxLength(15)]
        public string Vehicle_No { get; set; }
        [MaxLength(15)]
        public string Item_Code { get; set; }
        [MaxLength(15)]
        public string Netwt { get; set; }
        [MaxLength(15)]
        public string GrossDate { get; set; }
        [MaxLength(15)]
        public string SAPReference { get; set; }
       
        public TransType TransactionType { get; set; }
       
        public ErrType ErrorType { get; set; }
        [MaxLength(1000)]
        public string ErrorDescription { get; set; }

        [MaxLength(1000)]
        public string Recommendation { get; set; }
        public DateTime LoadingDate { get; set; }

    }
}