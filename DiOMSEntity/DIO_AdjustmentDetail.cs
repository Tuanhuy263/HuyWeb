namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AdjustmentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AdjustmentDetail()
        {
            DIO_AdjustmentBatch = new HashSet<DIO_AdjustmentBatch>();
            DIO_AdjustmentSerial = new HashSet<DIO_AdjustmentSerial>();
        }

        [Key]
        public int AdjustmentDetailNo { get; set; }

        public int AdjustmentHeaderNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? Onhand { get; set; }

        public decimal? ItemQty { get; set; }

        public decimal? ItemQtyInCarton { get; set; }

        public decimal? ItemQtyInPallet { get; set; }

        public decimal? WarehouseCount { get; set; }

        public decimal? UnitCost { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(255)]
        public string QBID { get; set; }

        public int? MasterLocationID { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountIndividual { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountQtyInCarton { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountQtyInPallet { get; set; }

        [Column(TypeName = "money")]
        public decimal? Difference { get; set; }

        [Column(TypeName = "money")]
        public decimal? DifferenceQtyCarton { get; set; }

        [Column(TypeName = "money")]
        public decimal? DifferenceQtyPallet { get; set; }

        [Column(TypeName = "money")]
        public decimal? PreviousOnhand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentBatch> DIO_AdjustmentBatch { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_AdjustmentHeader DIO_AdjustmentHeader { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentSerial> DIO_AdjustmentSerial { get; set; }
    }
}
