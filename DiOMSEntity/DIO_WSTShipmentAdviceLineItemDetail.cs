namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTShipmentAdviceLineItemDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ShipmentAdviceLineItemDetailId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? ShipmentAdviceLineItemId { get; set; }

        public int? SODetail { get; set; }

        public int? PODetail { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_WSTShipmentAdviceLineItem DIO_WSTShipmentAdviceLineItem { get; set; }

        public virtual DIS_PODetail DIS_PODetail { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }
    }
}
