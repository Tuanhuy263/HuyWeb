namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawASNSubLineItem
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

        public int? RawLineItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_RawLineItem DIO_RawLineItem { get; set; }
    }
}
