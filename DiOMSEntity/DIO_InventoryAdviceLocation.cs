namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryAdviceLocation
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int InventoryAdviceLocationID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? InventoryAdviceDetailID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_InventoryAdviceDetail DIO_InventoryAdviceDetail { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }
    }
}