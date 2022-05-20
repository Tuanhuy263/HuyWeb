namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RequestResultDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RequestResultDetailID { get; set; }

        [StringLength(4000)]
        public string Messages { get; set; }

        [StringLength(4000)]
        public string DocumentNumber { get; set; }

        public DateTime? RequestedDate { get; set; }

        public byte? Status { get; set; }

        public int? RequestResultHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        public DateTime? DocumentDate { get; set; }

        public virtual DIO_RequestResultHeader DIO_RequestResultHeader { get; set; }
    }
}
