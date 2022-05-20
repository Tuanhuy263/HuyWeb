namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocationInfo")]
    public partial class LocationInfo
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column("_SODetailInfo")]
        public int? C_SODetailInfo { get; set; }

        public int? SODetailInfo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LocationManagementID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual SODetailInfo SODetailInfo1 { get; set; }

        public virtual SODetailInfo SODetailInfo2 { get; set; }
    }
}
