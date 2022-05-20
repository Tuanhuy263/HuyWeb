namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WorkOrder()
        {
            DIO_WorkOrder1 = new HashSet<DIO_WorkOrder>();
            DIO_WorkOrderDetails = new HashSet<DIO_WorkOrderDetails>();
            DIO_WorkOrderInBatch = new HashSet<DIO_WorkOrderInBatch>();
            DIO_WorkOrderInSerial = new HashSet<DIO_WorkOrderInSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WorkOrderID { get; set; }

        [StringLength(50)]
        public string WorkOrderCode { get; set; }

        [StringLength(50)]
        public string WO_Level { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? Priority { get; set; }

        public DateTime? PlanStartDate { get; set; }

        public DateTime? PlanEndDate { get; set; }

        public DateTime? ActualStartDate { get; set; }

        public DateTime? CompleteDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? Status { get; set; }

        public bool? Active { get; set; }

        public int? SaleOrderID { get; set; }

        public int? LocationID { get; set; }

        public int? BillOfMaterialID { get; set; }

        public int? WorkOrderParentID { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [Column(TypeName = "money")]
        public decimal? ActualQuantity { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        public virtual DIO_BillOfMaterial DIO_BillOfMaterial { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrder> DIO_WorkOrder1 { get; set; }

        public virtual DIO_WorkOrder DIO_WorkOrder2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderDetails> DIO_WorkOrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderInBatch> DIO_WorkOrderInBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderInSerial> DIO_WorkOrderInSerial { get; set; }
    }
}
