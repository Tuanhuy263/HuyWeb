namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemDiscontinueDateType")]
    public partial class ItemDiscontinueDateType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemDiscontinueDateType()
        {
            DIS_HubItem = new HashSet<DIS_HubItem>();
            DIS_MasterItem = new HashSet<DIS_MasterItem>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemDiscontinueDateTypeCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_HubItem> DIS_HubItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterItem> DIS_MasterItem { get; set; }
    }
}
