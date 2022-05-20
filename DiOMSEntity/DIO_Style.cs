namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Style
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Style()
        {
            DIO_Style1 = new HashSet<DIO_Style>();
            DIS_HubItem = new HashSet<DIS_HubItem>();
            DIS_MasterItem = new HashSet<DIS_MasterItem>();
            DIS_VendorItem = new HashSet<DIS_VendorItem>();
        }

        [Key]
        public int StyleID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool? StyleType { get; set; }

        [StringLength(250)]
        public string Style { get; set; }

        public int? GlobalStyle { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        public int? ObjectType { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? ScaleID { get; set; }

        public virtual DIO_Scale DIO_Scale { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Style> DIO_Style1 { get; set; }

        public virtual DIO_Style DIO_Style2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_HubItem> DIS_HubItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterItem> DIS_MasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_VendorItem> DIS_VendorItem { get; set; }
    }
}
