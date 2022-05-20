namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_XPObjectWeakRelationShip
    {
        [Key]
        public int XPObjectWeakRelationShipID { get; set; }

        [Required]
        [StringLength(300)]
        public string ParentAssemblyFullName { get; set; }

        public int ParentKeyValue { get; set; }

        [Required]
        [StringLength(300)]
        public string ChildAssemblyFullName { get; set; }

        public int ChildKeyValue { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
