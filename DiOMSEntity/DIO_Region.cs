namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Region
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RegionID { get; set; }

        [StringLength(100)]
        public string CustomerCode { get; set; }

        [StringLength(100)]
        public string ValueType { get; set; }

        [StringLength(100)]
        public string Value { get; set; }

        [StringLength(100)]
        public string Region { get; set; }

        [StringLength(100)]
        public string PersistentName { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string Extension { get; set; }

        public DateTime? ShipWeek { get; set; }
    }
}
