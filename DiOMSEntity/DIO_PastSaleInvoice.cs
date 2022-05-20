namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PastSaleInvoice
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string Customer { get; set; }

        [StringLength(255)]
        public string TransactionType { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransactionNumber { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(255)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToZipCode { get; set; }

        [StringLength(255)]
        public string ItemCode { get; set; }

        [StringLength(255)]
        public string ItemDescription { get; set; }

        [StringLength(255)]
        public string UOM { get; set; }

        public DateTime? TransactionDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
