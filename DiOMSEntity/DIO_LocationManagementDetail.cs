namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LocationManagementDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_LocationManagementDetail()
        {
            DIO_LocationManagementDetailBatch = new HashSet<DIO_LocationManagementDetailBatch>();
            DIO_Serial = new HashSet<DIO_Serial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LocationManagementDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        public int? InventoryStatus { get; set; }

        public int? ItemBase { get; set; }

        public int? LocationManagement { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? Onhand { get; set; }

        public bool? IsCount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Allocated { get; set; }

        [Column(TypeName = "money")]
        public decimal? Packed { get; set; }

        [Column(TypeName = "money")]
        public decimal? OnOrder { get; set; }

        [Column(TypeName = "money")]
        public decimal? IndividualItemQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedForWO { get; set; }

        [Column(TypeName = "money")]
        public decimal? InProductionQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCartons { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        public virtual DIO_LocationManagement DIO_LocationManagement { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationManagementDetailBatch> DIO_LocationManagementDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Serial> DIO_Serial { get; set; }
    }
}
