namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackDetailItemBatch
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PackDetailItemBatchID { get; set; }

        [StringLength(100)]
        public string Barcode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? PackDetailItemID { get; set; }

        public int? PackDetailBatchID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? PickDetailBarcodeID { get; set; }

        [StringLength(100)]
        public string Batchcode { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }

        public virtual DIO_PackDetailItem DIO_PackDetailItem { get; set; }
    }
}
