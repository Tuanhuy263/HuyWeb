namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AssignItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AssignItemID { get; set; }

        public int? UserID { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_User DIS_User { get; set; }
    }
}
