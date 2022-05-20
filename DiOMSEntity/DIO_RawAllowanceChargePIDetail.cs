namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawAllowanceChargePIDetail
    {
        [Key]
        public int AllowanceChargeID { get; set; }

        public int? RawPurchaseInvoiceDetailNo { get; set; }

        [StringLength(50)]
        public string ItemAllowanceCode1 { get; set; }

        public decimal? ItemAllowanceAmount1 { get; set; }

        [StringLength(50)]
        public string ItemAllowancePercent1 { get; set; }

        [StringLength(255)]
        public string ItemAllowanceDescription1 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceCode2 { get; set; }

        public decimal? ItemAllowanceAmount2 { get; set; }

        [StringLength(50)]
        public string ItemAllowancePercent2 { get; set; }

        [StringLength(255)]
        public string ItemAllowanceDescription2 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceCode3 { get; set; }

        public decimal? ItemAllowanceAmount3 { get; set; }

        [StringLength(50)]
        public string ItemAllowancePercent3 { get; set; }

        [StringLength(255)]
        public string ItemAllowanceDescription3 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceCode4 { get; set; }

        public decimal? ItemAllowanceAmount4 { get; set; }

        [StringLength(50)]
        public string ItemAllowancePercent4 { get; set; }

        [StringLength(255)]
        public string ItemAllowanceDescription4 { get; set; }

        [StringLength(50)]
        public string ItemAllowanceMethodOfHandling4 { get; set; }

        public decimal? LineItemAllowanceRate1 { get; set; }

        public decimal? LineItemAllowanceRate2 { get; set; }

        public decimal? LineItemAllowanceRate3 { get; set; }

        public decimal? LineItemAllowanceRate4 { get; set; }

        public decimal? LineItemAllowanceQty1 { get; set; }

        public decimal? LineItemAllowanceQty2 { get; set; }

        public decimal? LineItemAllowanceQty3 { get; set; }

        public decimal? LineItemAllowanceQty4 { get; set; }

        [StringLength(50)]
        public string ItemChargeCode1 { get; set; }

        public decimal? ItemChargeAmount1 { get; set; }

        public decimal? ItemChargePercent1 { get; set; }

        [StringLength(255)]
        public string ItemChargeDescription1 { get; set; }

        [StringLength(50)]
        public string ItemChargeMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string ItemChargeCode2 { get; set; }

        public decimal? ItemChargeAmount2 { get; set; }

        public decimal? ItemChargePercent2 { get; set; }

        [StringLength(255)]
        public string ItemChargeDescription2 { get; set; }

        [StringLength(50)]
        public string ItemChargeMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string ItemChargeCode3 { get; set; }

        public decimal? ItemChargeAmount3 { get; set; }

        public decimal? ItemChargePercent3 { get; set; }

        [StringLength(255)]
        public string ItemChargeDescription3 { get; set; }

        [StringLength(50)]
        public string ItemChargeMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string ItemChargeCode4 { get; set; }

        public decimal? ItemChargeAmount4 { get; set; }

        public decimal? ItemChargePercent4 { get; set; }

        [StringLength(255)]
        public string ItemChargeDescription4 { get; set; }

        [StringLength(50)]
        public string ItemChargeMethodOfHandling4 { get; set; }

        public decimal? ItemChargeRate1 { get; set; }

        public decimal? ItemChargeRate2 { get; set; }

        public decimal? ItemChargeRate3 { get; set; }

        public decimal? ItemChargeRate4 { get; set; }

        public decimal? ItemChargeQty1 { get; set; }

        public decimal? ItemChargeQty2 { get; set; }

        public decimal? ItemChargeQty3 { get; set; }

        public decimal? ItemChargeQty4 { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_RawPurchaseInvoiceDetail DIO_RawPurchaseInvoiceDetail { get; set; }
    }
}
