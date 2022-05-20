namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackingOrderStatusDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        public int? SODetailNo { get; set; }

        [Column("_TrackingOrderStatusHeaderNo")]
        public int? C_TrackingOrderStatusHeaderNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_TrackingOrderStatusHeader DIO_TrackingOrderStatusHeader { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }
    }
}
