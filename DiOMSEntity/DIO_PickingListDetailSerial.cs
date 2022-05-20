namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickingListDetailSerial
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PickingListDetailSerialNo { get; set; }

        public bool? IsPicked { get; set; }

        public int? PickingListDetailNo { get; set; }

        public int? SerialID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? IsPacked { get; set; }

        public virtual DIO_PickingListDetail DIO_PickingListDetail { get; set; }

        public virtual DIO_Serial DIO_Serial { get; set; }
    }
}
