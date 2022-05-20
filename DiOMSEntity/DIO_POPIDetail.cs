namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_POPIDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int POPIDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? PODetailNo { get; set; }

        public int? PIDetailNo { get; set; }

        public int? POPIHeader { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_PurchaseInvoiceDetail DIS_PurchaseInvoiceDetail { get; set; }

        public virtual DIS_PODetail DIS_PODetail { get; set; }

        public virtual DIO_POPIHeader DIO_POPIHeader { get; set; }
    }
}
