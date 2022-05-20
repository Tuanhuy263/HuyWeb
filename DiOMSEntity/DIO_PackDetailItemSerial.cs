namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackDetailItemSerial
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PackDetailItemSerialID { get; set; }

        [StringLength(100)]
        public string Barcode { get; set; }

        public int? PackDetailItemID { get; set; }

        public int? PackDetailSerialID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? PickDetailBarcodeID { get; set; }

        public virtual DIO_PackDetailItem DIO_PackDetailItem { get; set; }

        public virtual DIO_Serial DIO_Serial { get; set; }
    }
}
