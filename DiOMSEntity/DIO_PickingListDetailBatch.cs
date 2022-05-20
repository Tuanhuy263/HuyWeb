namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickingListDetailBatch
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PickingListDetailBatchNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? PickedQuantity { get; set; }

        public bool? IsPicked { get; set; }

        public int? PickingListDetailNo { get; set; }

        public int? BatchID { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackedQuantity { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }

        public virtual DIO_PickingListDetail DIO_PickingListDetail { get; set; }
    }
}