namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WarehouseLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WarehouseLevel()
        {
            DIO_HubWarehouseLevel = new HashSet<DIO_HubWarehouseLevel>();
            DIO_WarehouseLevelDetail = new HashSet<DIO_WarehouseLevelDetail>();
            DIO_WarehouseLevelTemplate = new HashSet<DIO_WarehouseLevelTemplate>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WarehouseLevelID { get; set; }

        [StringLength(255)]
        public string WarehouseLevelCode { get; set; }

        public string Description { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? HubID { get; set; }

        public int? WarehouseLevelType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubWarehouseLevel> DIO_HubWarehouseLevel { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WarehouseLevelDetail> DIO_WarehouseLevelDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WarehouseLevelTemplate> DIO_WarehouseLevelTemplate { get; set; }
    }
}
