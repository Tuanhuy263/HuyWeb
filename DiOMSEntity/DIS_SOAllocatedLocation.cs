namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_SOAllocatedLocation
    {
        [Key]
        public int SOAllocatedLocationNo { get; set; }

        public int? SODetailNo { get; set; }

        public int? MasterLocationID { get; set; }

        public int? OldMasterLocationID { get; set; }

        public decimal? AllocatedQty { get; set; }

        public decimal? CommitQty { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }
    }
}
