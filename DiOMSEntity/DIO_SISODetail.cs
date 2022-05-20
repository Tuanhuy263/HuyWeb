namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SISODetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int SISODetailNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoicedQty { get; set; }

        public int? SIDetailNo { get; set; }

        public int? SODetailNo { get; set; }

        public int? SISOHeaderNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public virtual DIS_SaleInvoiceDetail DIS_SaleInvoiceDetail { get; set; }

        public virtual DIO_SISOHeader DIO_SISOHeader { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }
    }
}
