namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TableImport
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TableValueMember { get; set; }

        [Required]
        [StringLength(250)]
        public string TableValueDisplay { get; set; }

        public int? OrderNo { get; set; }

        [StringLength(50)]
        public string TableImportType { get; set; }

        [StringLength(4000)]
        public string FileName { get; set; }

        public int? Priority { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
