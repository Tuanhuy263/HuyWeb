namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LineItemBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_LineItemBatch()
        {
            DIO_InventoryLineItemShippingAdviceBatch = new HashSet<DIO_InventoryLineItemShippingAdviceBatch>();
            DIO_nInventoryLineItemBatch = new HashSet<DIO_nInventoryLineItemBatch>();
        }

        [Key]
        public int LineItemBatchID { get; set; }

        public int? LineItemID { get; set; }

        public int BatchID { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        public int? ASNLineItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ScanQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountQuantity { get; set; }

        public int? InventoryStatus { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }

        public virtual DIO_InventoryLineItem DIO_InventoryLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdviceBatch> DIO_InventoryLineItemShippingAdviceBatch { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        public virtual DIS_LineItem DIS_LineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_nInventoryLineItemBatch> DIO_nInventoryLineItemBatch { get; set; }
    }
}
