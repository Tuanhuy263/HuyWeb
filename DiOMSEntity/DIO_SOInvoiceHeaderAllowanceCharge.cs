namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SOInvoiceHeaderAllowanceCharge
    {
        [Key]
        public int SOInvoiceHeaderAllowanceChargeID { get; set; }

        public int SaleInvoiceNo { get; set; }

        public int? AllowanceChargeID { get; set; }

        public int? AllowanceChargeHandleID { get; set; }

        public int? Sequence { get; set; }

        public int? Indicator { get; set; }

        public decimal? Amount { get; set; }

        public decimal? Percentage { get; set; }

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

        public bool? DontExportToQB { get; set; }

        [StringLength(4000)]
        public string AllowanceChargeDescription { get; set; }

        public int? SOHeaderAllowanceChargeID { get; set; }

        public virtual DIO_AllowanceCharge DIO_AllowanceCharge { get; set; }

        public virtual DIO_AllowanceChargeHandle DIO_AllowanceChargeHandle { get; set; }

        public virtual DIS_SaleInvoiceHeader DIS_SaleInvoiceHeader { get; set; }
    }
}
