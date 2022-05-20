namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_EventActionAttributeUser
    {
        [Key]
        public int EventActionAttributeUserID { get; set; }

        public int? UserID { get; set; }

        public int? EventActionAttributeID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_EventActionAttribute DIS_EventActionAttribute { get; set; }

        public virtual DIS_User DIS_User { get; set; }
    }
}
