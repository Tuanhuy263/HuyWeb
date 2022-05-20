namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PTSLineItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PTSLineItem()
        {
            DIO_PTSLineItemBatch = new HashSet<DIO_PTSLineItemBatch>();
            DIO_PTSLineItemSerial = new HashSet<DIO_PTSLineItemSerial>();
        }

        [Key]
        public int LineItemNo { get; set; }

        public int CartonNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public int? ObjectType { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_PTSCarton DIO_PTSCarton { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSLineItemBatch> DIO_PTSLineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSLineItemSerial> DIO_PTSLineItemSerial { get; set; }
    }
}
