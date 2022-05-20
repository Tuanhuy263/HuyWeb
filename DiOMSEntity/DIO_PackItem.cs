namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackItem()
        {
            DIO_PackItemBatch = new HashSet<DIO_PackItemBatch>();
            DIO_PackItemDetail = new HashSet<DIO_PackItemDetail>();
            DIO_PackItemSerial = new HashSet<DIO_PackItemSerial>();
        }

        [Key]
        public int PackItemID { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public int MasterItemID { get; set; }

        public int ToLocation { get; set; }

        public decimal MaximunPackQuantity { get; set; }

        public decimal PackQuantity { get; set; }

        public decimal? UnitCost { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public int? QBAccountID { get; set; }

        public DateTime? QBModifiedDate { get; set; }

        public byte? Status { get; set; }

        public bool? FromSO { get; set; }

        public virtual DIO_MasterKit DIO_MasterKit { get; set; }

        public virtual DIO_QuickBookAccount DIO_QuickBookAccount { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemBatch> DIO_PackItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetail> DIO_PackItemDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemSerial> DIO_PackItemSerial { get; set; }
    }
}
