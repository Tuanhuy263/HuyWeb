namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CategoryItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_CategoryItems()
        {
            DIO_CategoryItemPolicy = new HashSet<DIO_CategoryItemPolicy>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CategoryItemID { get; set; }

        public int? CustomerCategoryID { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CategoryItemPolicy> DIO_CategoryItemPolicy { get; set; }

        public virtual DIO_CustomerCategories DIO_CustomerCategories { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
