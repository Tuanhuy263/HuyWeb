namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_VendorPaymentDetail
    {
        [Key]
        public int VendorPaymentDetailID { get; set; }

        public int? VendorStatementID { get; set; }

        public int? InvoiceNo { get; set; }

        public decimal? Amount { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_VendorStatement DIO_VendorStatement { get; set; }

        public virtual DIS_PurchaseInvoiceHeader DIS_PurchaseInvoiceHeader { get; set; }
    }
}
