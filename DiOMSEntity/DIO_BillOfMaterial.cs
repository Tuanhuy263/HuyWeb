namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BillOfMaterial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_BillOfMaterial()
        {
            DIO_BillOfMaterialDetail = new HashSet<DIO_BillOfMaterialDetail>();
            DIO_WorkOrder = new HashSet<DIO_WorkOrder>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillOfMaterialID { get; set; }

        [Column(TypeName = "money")]
        public decimal? LabourCost { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        [StringLength(100)]
        public string BomName { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BillOfMaterialDetail> DIO_BillOfMaterialDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrder> DIO_WorkOrder { get; set; }
    }
}
