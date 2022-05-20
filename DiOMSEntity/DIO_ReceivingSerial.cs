namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReceivingSerial
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceivingSerialID { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? WarehouseCount { get; set; }

        public bool? IsIgnored { get; set; }

        public int? SerialID { get; set; }

        public int? ReceivingItemNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ReceivingItem DIO_ReceivingItem { get; set; }

        public virtual DIO_Serial DIO_Serial { get; set; }
    }
}
