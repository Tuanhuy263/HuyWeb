namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryRepackCarton
    {
        [Key]
        public int InventoryRepackCartonNo { get; set; }

        public int OriginalCartonNo { get; set; }

        public int NewCartonNo { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton1 { get; set; }
    }
}
