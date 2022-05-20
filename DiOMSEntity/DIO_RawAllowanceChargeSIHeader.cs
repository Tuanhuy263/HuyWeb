namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawAllowanceChargeSIHeader
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AllowanceChargeID { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent1 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription1 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent2 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription2 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent3 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription3 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent4 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription4 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling4 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent5 { get; set; }

        [StringLength(255)]
        public string InvoiceChargeDescription5 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent1 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription1 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent2 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription2 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent3 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription3 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent4 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription4 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling4 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent5 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent6 { get; set; }

        [StringLength(255)]
        public string InvoiceAllowanceDescription6 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling6 { get; set; }

        public int? RawSaleInvoiceNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_RawSaleInvoiceHeader DIO_RawSaleInvoiceHeader { get; set; }
    }
}
