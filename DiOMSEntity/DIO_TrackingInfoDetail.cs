namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackingInfoDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TrackingInfoDetailID { get; set; }

        public int? TrackingInfoHeaderID { get; set; }

        public int? TrackingTransactionTypeDetailID { get; set; }

        public int? ActionType { get; set; }

        [StringLength(100)]
        public string ObjectType { get; set; }

        [StringLength(100)]
        public string ObjectID { get; set; }

        [StringLength(100)]
        public string ObjectKey { get; set; }

        [StringLength(100)]
        public string FieldName { get; set; }

        [StringLength(100)]
        public string NewValue { get; set; }

        [StringLength(100)]
        public string OldValue { get; set; }

        public virtual DIO_TrackingInfoHeader DIO_TrackingInfoHeader { get; set; }

        public virtual DIO_TrackingTransactionTypeDetail DIO_TrackingTransactionTypeDetail { get; set; }
    }
}
