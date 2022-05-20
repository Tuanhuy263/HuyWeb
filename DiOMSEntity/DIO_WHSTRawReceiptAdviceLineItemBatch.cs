namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHSTRawReceiptAdviceLineItemBatch
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHSTRawReceiptAdviceLineItemBatchID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(30)]
        public string BatchCode { get; set; }

        [StringLength(30)]
        public string ManufactureNumber { get; set; }

        public DateTime? ManufacturingDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? CartonQty { get; set; }

        public int? WHSTRawReceiptAdviceLineItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_WHSTRawReceiptAdviceLineItem DIO_WHSTRawReceiptAdviceLineItem { get; set; }
    }
}
