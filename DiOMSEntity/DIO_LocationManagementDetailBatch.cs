namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LocationManagementDetailBatch
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LocationManagementDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Onhand { get; set; }

        public bool? IsCount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Allocated { get; set; }

        [Column(TypeName = "money")]
        public decimal? Packed { get; set; }

        [Column(TypeName = "money")]
        public decimal? OnOrder { get; set; }

        [Column(TypeName = "money")]
        public decimal? IndividualItemQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedForWO { get; set; }

        [Column(TypeName = "money")]
        public decimal? InProductionQty { get; set; }

        public int? LocationManagementDetail { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? Batch { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }

        public virtual DIO_LocationManagementDetail DIO_LocationManagementDetail { get; set; }
    }
}
