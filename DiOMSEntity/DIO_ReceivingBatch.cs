namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReceivingBatch
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceivingBatchID { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? WarehouseCount { get; set; }

        public int? ReceivingItemNo { get; set; }

        public int? BatchID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }

        public virtual DIO_ReceivingItem DIO_ReceivingItem { get; set; }
    }
}
