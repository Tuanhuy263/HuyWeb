namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PODetailInfo")]
    public partial class PODetailInfo
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column("_ItemInfo")]
        public int? C_ItemInfo { get; set; }

        public int? ItemInfo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PODetailNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual ItemInfo ItemInfo1 { get; set; }

        public virtual ItemInfo ItemInfo2 { get; set; }
    }
}
