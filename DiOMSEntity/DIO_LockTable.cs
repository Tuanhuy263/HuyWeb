namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LockTable
    {
        [Key]
        public int LockTableID { get; set; }

        [Required]
        [StringLength(200)]
        public string TableNameKeyValue { get; set; }

        [Required]
        [StringLength(100)]
        public string TableName { get; set; }

        [Required]
        [StringLength(100)]
        public string KeyValue { get; set; }

        [Required]
        [StringLength(400)]
        public string LockID { get; set; }

        public long TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        [StringLength(100)]
        public string ComputerName { get; set; }
    }
}
