namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TmpAdjustmentCarton")]
    public partial class TmpAdjustmentCarton
    {
        [Key]
        public int AdjustmentCartonNo { get; set; }

        public int AdjustmentHeaderNo { get; set; }

        public int CartonNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }

        public virtual TmpAdjustmentHeader TmpAdjustmentHeader { get; set; }
    }
}
