namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LineItemSerial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_LineItemSerial()
        {
            DIO_InventoryLineItemShippingAdviceSerial = new HashSet<DIO_InventoryLineItemShippingAdviceSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LineItemSerialID { get; set; }

        public int? SerialID { get; set; }

        public int? LineItemNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? LineItemID { get; set; }

        public bool? Scanned { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountQuantity { get; set; }

        public int? InventoryStatus { get; set; }

        public bool? IsIgnored { get; set; }

        public virtual DIO_InventoryLineItem DIO_InventoryLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryLineItemShippingAdviceSerial> DIO_InventoryLineItemShippingAdviceSerial { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        public virtual DIS_LineItem DIS_LineItem { get; set; }

        public virtual DIO_Serial DIO_Serial { get; set; }
    }
}
