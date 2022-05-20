namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WarehouseLevelTemplate
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WarehouseLevelTemplateID { get; set; }

        public int? WarehouseLevelID { get; set; }

        public int? InventoryAdviceConfigID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_InventoryAdviceConfig DIO_InventoryAdviceConfig { get; set; }

        public virtual DIO_WarehouseLevel DIO_WarehouseLevel { get; set; }
    }
}
