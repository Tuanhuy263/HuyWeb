namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_MasterKit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_MasterKit()
        {
            DIO_KitDetail = new HashSet<DIO_KitDetail>();
            DIO_OpenPack = new HashSet<DIO_OpenPack>();
            DIO_PackItem = new HashSet<DIO_PackItem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MasterItemID { get; set; }

        [StringLength(20)]
        public string KitAttribute { get; set; }

        public int? ChildColor { get; set; }

        public int? ChildSize { get; set; }

        public decimal? ItemCommissionRate { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? UsedForImport { get; set; }

        public bool? IsGroupItem { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_KitDetail> DIO_KitDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPack> DIO_OpenPack { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItem> DIO_PackItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
