namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_HubDefaultValue
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int HubDefaultID { get; set; }

        public int? Key { get; set; }

        [StringLength(100)]
        public string Value { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }
    }
}
