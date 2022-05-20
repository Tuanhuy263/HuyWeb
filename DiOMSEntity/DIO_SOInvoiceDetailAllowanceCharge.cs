namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SOInvoiceDetailAllowanceCharge
    {
        [Key]
        public int SOInvoiceDetailAllowanceChargeID { get; set; }

        public int SaleInvoiceDetailNo { get; set; }

        public int? AllowanceChargeID { get; set; }

        public int? AllowanceChargeHandleID { get; set; }

        public int? Sequence { get; set; }

        public int? Indicator { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Percentage { get; set; }

        public decimal? Rate { get; set; }

        public decimal? Quantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(255)]
        public string QBID { get; set; }

        [StringLength(255)]
        public string AllowanceChargeDescription { get; set; }

        public bool? DontExportToQB { get; set; }

        public int? SODetailAllowanceChargeID { get; set; }

        public virtual DIO_AllowanceCharge DIO_AllowanceCharge { get; set; }

        public virtual DIO_AllowanceChargeHandle DIO_AllowanceChargeHandle { get; set; }

        public virtual DIS_SaleInvoiceDetail DIS_SaleInvoiceDetail { get; set; }
    }
}
