namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReturnShipmentSerial
    {
        [Key]
        public int ReturnShipmentSerialID { get; set; }

        public int ReturnShipmentDetailNo { get; set; }

        public int SerialID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_ReturnShipmentDetail DIO_ReturnShipmentDetail { get; set; }

        public virtual DIO_Serial DIO_Serial { get; set; }
    }
}
