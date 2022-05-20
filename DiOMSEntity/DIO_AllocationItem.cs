namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AllocationItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(200)]
        public string BatchCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int? LocationID { get; set; }

        public int? SODetailNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? MasterItemID { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }
    }
}
