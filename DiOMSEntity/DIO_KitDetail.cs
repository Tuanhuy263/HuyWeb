namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_KitDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_KitDetail()
        {
            DIO_OpenPackDetail = new HashSet<DIO_OpenPackDetail>();
            DIO_PackItemDetail = new HashSet<DIO_PackItemDetail>();
        }

        [Key]
        public int KitDetailID { get; set; }

        public int MasterKitID { get; set; }

        public int ChildItemID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public decimal KitQuantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TimeImplement { get; set; }

        public virtual DIO_MasterKit DIO_MasterKit { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPackDetail> DIO_OpenPackDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetail> DIO_PackItemDetail { get; set; }
    }
}
