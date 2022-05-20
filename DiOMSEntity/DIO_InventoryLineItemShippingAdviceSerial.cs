namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryLineItemShippingAdviceSerial
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LineItemShippingAdviceSerialID { get; set; }

        public int? LineItemID { get; set; }

        public int? SerialID { get; set; }

        public int? LineItemSerialID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? WHShippingAdviceDetailID { get; set; }

        public virtual DIO_InventoryLineItemShippingAdvice DIO_InventoryLineItemShippingAdvice { get; set; }

        public virtual DIO_LineItemSerial DIO_LineItemSerial { get; set; }

        public virtual DIO_Serial DIO_Serial { get; set; }

        public virtual DIO_WHShippingAdviceDetail DIO_WHShippingAdviceDetail { get; set; }
    }
}
