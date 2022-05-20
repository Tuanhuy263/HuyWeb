namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WorkOrderDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WorkOrderDetails()
        {
            DIO_WorkOrderDetails_Location = new HashSet<DIO_WorkOrderDetails_Location>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WorkOrderDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? WorkOrderID { get; set; }

        public int? LocationID { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualQuantity { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        public virtual DIO_WorkOrder DIO_WorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderDetails_Location> DIO_WorkOrderDetails_Location { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
