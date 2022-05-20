namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawAllowanceChargePIHeader
    {
        [Key]
        public int AllowanceChargeID { get; set; }

        public int RawPurchaseInvoiceNo { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode1 { get; set; }

        public decimal? InvoiceChargeAmount1 { get; set; }

        [StringLength(50)]
        public string InvoiceChargePercent1 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription1 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode2 { get; set; }

        public decimal? InvoiceChargeAmount2 { get; set; }

        [StringLength(50)]
        public string InvoiceChargePercent2 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription2 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode3 { get; set; }

        public decimal? InvoiceChargeAmount3 { get; set; }

        [StringLength(50)]
        public string InvoiceChargePercent3 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription3 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode4 { get; set; }

        public decimal? InvoiceChargeAmount4 { get; set; }

        [StringLength(50)]
        public string InvoiceChargePercent4 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription4 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling4 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode5 { get; set; }

        public decimal? InvoiceChargeAmount5 { get; set; }

        [StringLength(50)]
        public string InvoiceChargePercent5 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription5 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode1 { get; set; }

        public decimal? InvoiceAllowanceAmount1 { get; set; }

        [StringLength(10)]
        public string InvoiceAllowancePercent1 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription1 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode2 { get; set; }

        public decimal? InvoiceAllowanceAmount2 { get; set; }

        [StringLength(10)]
        public string InvoiceAllowancePercent2 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription2 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode3 { get; set; }

        public decimal? InvoiceAllowanceAmount3 { get; set; }

        [StringLength(10)]
        public string InvoiceAllowancePercent3 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription3 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode4 { get; set; }

        public decimal? InvoiceAllowanceAmount4 { get; set; }

        [StringLength(10)]
        public string InvoiceAllowancePercent4 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription4 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling4 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode5 { get; set; }

        public decimal? InvoiceAllowanceAmount5 { get; set; }

        [StringLength(10)]
        public string InvoiceAllowancePercent5 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode6 { get; set; }

        public decimal? InvoiceAllowanceAmount6 { get; set; }

        [StringLength(10)]
        public string InvoiceAllowancePercent6 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription6 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling6 { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_RawPurchaseInvoiceHeader DIO_RawPurchaseInvoiceHeader { get; set; }
    }
}
