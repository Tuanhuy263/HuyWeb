namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OrderChangeAcknowledgmentCommission
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? SONo { get; set; }

        [Key]
        public int SOComissionID { get; set; }

        [Column(TypeName = "money")]
        public decimal? CommissionRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_OrderChangeAcknowledgmentHeader DIO_OrderChangeAcknowledgmentHeader { get; set; }
    }
}
