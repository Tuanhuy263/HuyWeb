namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ImportFileInfo
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int FileID { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        public long? FileSize { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? FileDate { get; set; }

        [StringLength(100)]
        public string CheckSum { get; set; }

        [StringLength(100)]
        public string TransactionType { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
