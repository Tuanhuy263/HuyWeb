namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackUserDoing
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(250)]
        public string Username { get; set; }

        [StringLength(250)]
        public string TransactionNumber { get; set; }

        [StringLength(250)]
        public string TransactionType { get; set; }

        [StringLength(250)]
        public string Action { get; set; }

        public DateTime? EditTime { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
