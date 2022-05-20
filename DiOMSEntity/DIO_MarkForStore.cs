namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_MarkForStore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_MarkForStore()
        {
            DIO_CustomerMarkForStore = new HashSet<DIO_CustomerMarkForStore>();
            DIS_PODetail = new HashSet<DIS_PODetail>();
            DIS_SODetail = new HashSet<DIS_SODetail>();
            DIO_VendorMarkForStore = new HashSet<DIO_VendorMarkForStore>();
        }

        [Key]
        public int MarkForStoreID { get; set; }

        [Required]
        [StringLength(10)]
        public string MarkForStoreNo { get; set; }

        [StringLength(250)]
        public string MarkForName { get; set; }

        [StringLength(250)]
        public string MarkForAddress1 { get; set; }

        [StringLength(250)]
        public string MarkForAddress2 { get; set; }

        [StringLength(30)]
        public string MarkForCity { get; set; }

        [StringLength(3)]
        public string MarkForState { get; set; }

        [StringLength(15)]
        public string MarkForZipCode { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerMarkForStore> DIO_CustomerMarkForStore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PODetail> DIS_PODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SODetail> DIS_SODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorMarkForStore> DIO_VendorMarkForStore { get; set; }
    }
}
