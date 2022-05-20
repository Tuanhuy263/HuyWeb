namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AdjustmentBatch
    {
        [Key]
        public int AdjustmentBatchID { get; set; }

        public int AdjustmentDetailNo { get; set; }

        public int BatchID { get; set; }

        public decimal? OriginalQuantity { get; set; }

        public decimal? WarehouseCount { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_AdjustmentDetail DIO_AdjustmentDetail { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }
    }
}
