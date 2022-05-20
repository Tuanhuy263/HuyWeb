namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ASNInvoiceDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ASNInvoiceDetailNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceQuantity { get; set; }

        public int? ASNInvoice { get; set; }

        public int? LineItemDetail { get; set; }

        public int? SaleInvoiceDetail { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ASNInvoice DIO_ASNInvoice { get; set; }

        public virtual DIS_LineItemDetail DIS_LineItemDetail { get; set; }

        public virtual DIS_SaleInvoiceDetail DIS_SaleInvoiceDetail { get; set; }
    }
}
