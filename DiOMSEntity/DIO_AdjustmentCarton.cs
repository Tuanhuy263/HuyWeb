namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AdjustmentCarton
    {
        [Key]
        public int AdjustmentCartonNo { get; set; }

        public int AdjustmentHeaderNo { get; set; }

        public int CartonNo { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsCount { get; set; }

        public bool? IsAdjust { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsNew { get; set; }

        public int? AdjustmentPalletNo { get; set; }

        public virtual DIO_AdjustmentPallet DIO_AdjustmentPallet { get; set; }

        public virtual DIO_AdjustmentHeader DIO_AdjustmentHeader { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }
    }
}
