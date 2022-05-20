namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InvoiceSOFreight
    {
        [Key]
        public int InvoiceSOFreightID { get; set; }

        public int SaleInvoiceNo { get; set; }

        public int? FreightID { get; set; }

        public decimal Amount { get; set; }

        public byte? DistributedMethod { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string FreightName { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public virtual DIO_Freight DIO_Freight { get; set; }

        public virtual DIS_SaleInvoiceHeader DIS_SaleInvoiceHeader { get; set; }
    }
}
