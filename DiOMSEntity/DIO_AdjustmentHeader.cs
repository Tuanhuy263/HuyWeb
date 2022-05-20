namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AdjustmentHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AdjustmentHeader()
        {
            DIO_AdjustmentCarton = new HashSet<DIO_AdjustmentCarton>();
            DIO_AdjustmentDetail = new HashSet<DIO_AdjustmentDetail>();
            DIO_AdjustmentHeader1 = new HashSet<DIO_AdjustmentHeader>();
            DIO_AdjustmentPallet = new HashSet<DIO_AdjustmentPallet>();
        }

        [Key]
        public int AdjustmentHeaderNo { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? MasterLocationID { get; set; }

        public int? ReasonCode { get; set; }

        [StringLength(250)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public long? Status { get; set; }

        public int? AdjustmentID { get; set; }

        public bool IsWarehouseCount { get; set; }

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

        public DateTime? QBModifiedDate { get; set; }

        public int? QBAccountID { get; set; }

        public long? StockAdjustmentTraceStatus { get; set; }

        [StringLength(250)]
        public string SmartTurnDocumentNo { get; set; }

        [StringLength(250)]
        public string SmartTurnWarehouseID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentCarton> DIO_AdjustmentCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentDetail> DIO_AdjustmentDetail { get; set; }

        public virtual DIO_QuickBookAccount DIO_QuickBookAccount { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_ReasonAdjustment DIO_ReasonAdjustment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentHeader> DIO_AdjustmentHeader1 { get; set; }

        public virtual DIO_AdjustmentHeader DIO_AdjustmentHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentPallet> DIO_AdjustmentPallet { get; set; }
    }
}
