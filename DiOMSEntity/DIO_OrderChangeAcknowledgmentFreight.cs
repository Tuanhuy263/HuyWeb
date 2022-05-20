namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OrderChangeAcknowledgmentFreight
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int SOFreightID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public byte? DistributedMethod { get; set; }

        [StringLength(100)]
        public string FreightName { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public int? OrderChangeAcknowledgmentHeader { get; set; }

        public int? Freight { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_Freight DIO_Freight { get; set; }

        public virtual DIO_OrderChangeAcknowledgmentHeader DIO_OrderChangeAcknowledgmentHeader { get; set; }
    }
}
