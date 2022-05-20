namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ScaleSize
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ScaleSizeID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? ScaleID { get; set; }

        public int? SizeID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? Index { get; set; }

        public virtual DIO_Scale DIO_Scale { get; set; }

        public virtual DIO_Size DIO_Size { get; set; }
    }
}
