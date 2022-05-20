namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Batch_ReceivedDate
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
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? QuantityInBox { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public int? Batch { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedIndividualQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedInBoxQty { get; set; }

        [StringLength(100)]
        public string LPN { get; set; }

        [StringLength(100)]
        public string Owner { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }
    }
}
