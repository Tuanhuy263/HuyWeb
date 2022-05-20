namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SubLineItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int SubLineItemID { get; set; }

        [StringLength(255)]
        public string SubLineItemNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity { get; set; }

        [StringLength(255)]
        public string SubLineUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship { get; set; }

        public int? SODetailNo { get; set; }

        public int? LineItemNo { get; set; }

        public int? SIDetailNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_LineItem DIS_LineItem { get; set; }

        public virtual DIS_SaleInvoiceDetail DIS_SaleInvoiceDetail { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }
    }
}
