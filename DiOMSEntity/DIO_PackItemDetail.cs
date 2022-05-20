namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackItemDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackItemDetail()
        {
            DIO_PackItemDetailLocation = new HashSet<DIO_PackItemDetailLocation>();
        }

        [Key]
        public int PackItemDetailID { get; set; }

        public int PackItemID { get; set; }

        public int KitDetailID { get; set; }

        public decimal QuantityPerPack { get; set; }

        public decimal QuantityToPack { get; set; }

        public decimal? Quantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_KitDetail DIO_KitDetail { get; set; }

        public virtual DIO_PackItem DIO_PackItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetailLocation> DIO_PackItemDetailLocation { get; set; }
    }
}
