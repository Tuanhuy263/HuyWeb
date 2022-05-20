namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AlertBoxViewHistory
    {
        public int ID { get; set; }

        public int AlertBoxID { get; set; }

        [StringLength(64)]
        public string ApplicationName { get; set; }

        [StringLength(64)]
        public string UserID { get; set; }

        public int ViewCount { get; set; }

        public DateTime LastViewDate { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_AlertBox DIO_AlertBox { get; set; }
    }
}
