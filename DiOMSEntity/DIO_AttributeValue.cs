namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AttributeValue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AttributeValue()
        {
            DIS_HubItem = new HashSet<DIS_HubItem>();
            DIS_HubItem1 = new HashSet<DIS_HubItem>();
            DIS_MasterItem = new HashSet<DIS_MasterItem>();
            DIS_MasterItem1 = new HashSet<DIS_MasterItem>();
            DIS_MasterItem2 = new HashSet<DIS_MasterItem>();
            DIO_MasterKit = new HashSet<DIO_MasterKit>();
            DIO_MasterKit1 = new HashSet<DIO_MasterKit>();
            DIO_SizeRun = new HashSet<DIO_SizeRun>();
            DIO_SizeRun1 = new HashSet<DIO_SizeRun>();
            DIS_VendorItem = new HashSet<DIS_VendorItem>();
            DIS_VendorItem1 = new HashSet<DIS_VendorItem>();
        }

        [Key]
        public int AttributeValueID { get; set; }

        public int AttributeTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Values { get; set; }

        public int? AttributeGroupID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string AttributeValueDescription { get; set; }

        public DateTime? ReplicationDate { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? Index { get; set; }

        public virtual DIO_AttributeGroup DIO_AttributeGroup { get; set; }

        public virtual DIO_AttributeType DIO_AttributeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_HubItem> DIS_HubItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_HubItem> DIS_HubItem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterItem> DIS_MasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterItem> DIS_MasterItem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterItem> DIS_MasterItem2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterKit> DIO_MasterKit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterKit> DIO_MasterKit1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SizeRun> DIO_SizeRun { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SizeRun> DIO_SizeRun1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_VendorItem> DIS_VendorItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_VendorItem> DIS_VendorItem1 { get; set; }
    }
}
