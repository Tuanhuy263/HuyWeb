namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomFieldForSmartTurn
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string SmartTurnFieldName { get; set; }

        [StringLength(255)]
        public string DIOMSFieldName { get; set; }

        [StringLength(255)]
        public string PersistentObject { get; set; }

        public bool? IsActive { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string SmartTurnType { get; set; }
    }
}
