namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryStatus()
        {
            DIO_InventoryCarton = new HashSet<DIO_InventoryCarton>();
            DIO_InventoryLineItem = new HashSet<DIO_InventoryLineItem>();
            DIO_InventoryPallet = new HashSet<DIO_InventoryPallet>();
            DIO_LineItemBatch = new HashSet<DIO_LineItemBatch>();
            DIO_LineItemSerial = new HashSet<DIO_LineItemSerial>();
            DIO_LocationManagementDetail = new HashSet<DIO_LocationManagementDetail>();
            DIO_Serial = new HashSet<DIO_Serial>();
            DIO_WH947LineItem = new HashSet<DIO_WH947LineItem>();
            DIO_WSTReceiptAdviceCarton = new HashSet<DIO_WSTReceiptAdviceCarton>();
            DIO_WSTReceiptAdviceLineItem = new HashSet<DIO_WSTReceiptAdviceLineItem>();
            DIO_WSTReceiptAdviceLineItemBatch = new HashSet<DIO_WSTReceiptAdviceLineItemBatch>();
            DIO_WSTReceiptAdviceLineItemSerial = new HashSet<DIO_WSTReceiptAdviceLineItemSerial>();
            DIO_WSTReceiptAdvicePallet = new HashSet<DIO_WSTReceiptAdvicePallet>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int InventoryStatusID { get; set; }

        [StringLength(50)]
        public string StatusCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public bool? IsGood { get; set; }

        public bool? IsBad { get; set; }

        public bool? CanSales { get; set; }

        public bool? CanTransfer { get; set; }

        public bool? Pallet { get; set; }

        public bool? Carton { get; set; }

        public bool? IsItem { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryCarton> DIO_InventoryCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItem> DIO_InventoryLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryPallet> DIO_InventoryPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LineItemBatch> DIO_LineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LineItemSerial> DIO_LineItemSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationManagementDetail> DIO_LocationManagementDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Serial> DIO_Serial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WH947LineItem> DIO_WH947LineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceCarton> DIO_WSTReceiptAdviceCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItem> DIO_WSTReceiptAdviceLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItemBatch> DIO_WSTReceiptAdviceLineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItemSerial> DIO_WSTReceiptAdviceLineItemSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePallet> DIO_WSTReceiptAdvicePallet { get; set; }
    }
}
