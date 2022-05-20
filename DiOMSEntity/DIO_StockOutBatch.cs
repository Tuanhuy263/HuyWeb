namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_StockOutBatch
    {
        [Key]
        public int StockOutBatchID { get; set; }

        public int? WHStockOutDetailNo { get; set; }

        public int? BatchID { get; set; }

        public decimal? Quantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TmpReturnedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReturnedQuantity { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }

        public virtual DIO_WHStockOutDetail DIO_WHStockOutDetail { get; set; }
    }
}
