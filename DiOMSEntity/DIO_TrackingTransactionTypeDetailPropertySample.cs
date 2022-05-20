namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackingTransactionTypeDetailPropertySample
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TrackingTransactionTypeDetailPropertySampleID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(4000)]
        public string Sample { get; set; }

        public int? TrackingTransactionTypeDetailPropertyID { get; set; }

        public virtual DIO_TrackingTransactionTypeDetailProperty DIO_TrackingTransactionTypeDetailProperty { get; set; }
    }
}
