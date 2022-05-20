namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_FileTrackingInfo
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int FileTrackingInfoID { get; set; }

        public int? ActionType { get; set; }

        [StringLength(100)]
        public string Username { get; set; }

        [StringLength(100)]
        public string ComputerName { get; set; }

        [StringLength(100)]
        public string IPAddress { get; set; }

        [StringLength(4000)]
        public string Path { get; set; }

        [StringLength(4000)]
        public string Filename { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [StringLength(100)]
        public string TransactionNumber { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
