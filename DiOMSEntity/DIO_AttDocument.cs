namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AttDocument
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int DocumentID { get; set; }

        [StringLength(200)]
        public string DocumentName { get; set; }

        [StringLength(200)]
        public string TransactionNo { get; set; }

        public int? TransactionType { get; set; }

        [StringLength(5)]
        public string ExtendFile { get; set; }

        [StringLength(4000)]
        public string DescriptionFile { get; set; }

        public byte[] ValueContentFile { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
