namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_StockOutSerial
    {
        [Key]
        public int StockOutSerialID { get; set; }

        public int WHStockOutDetailNo { get; set; }

        public int SerialID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsReturning { get; set; }

        public bool? IsReturned { get; set; }

        public virtual DIO_Serial DIO_Serial { get; set; }

        public virtual DIO_WHStockOutDetail DIO_WHStockOutDetail { get; set; }
    }
}
