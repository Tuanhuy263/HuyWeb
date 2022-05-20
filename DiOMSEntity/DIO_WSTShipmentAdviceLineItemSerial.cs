namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTShipmentAdviceLineItemSerial
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ShipmentAdviceLineItemSerialId { get; set; }

        public int? SerialId { get; set; }

        public int? ShipmentAdviceLineItemId { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_Serial DIO_Serial { get; set; }

        public virtual DIO_WSTShipmentAdviceLineItem DIO_WSTShipmentAdviceLineItem { get; set; }
    }
}
