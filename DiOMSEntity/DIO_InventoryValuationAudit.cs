namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryValuationAudit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryValuationAudit()
        {
            DIO_InventoryValuationAudit1 = new HashSet<DIO_InventoryValuationAudit>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int InventoryValuationAuditID { get; set; }

        public DateTime? SystemDate { get; set; }

        [StringLength(50)]
        public string DocumentNo { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public DateTime? DocumentDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransactionQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? IssuedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransactionPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? CalculatedCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? CumulativeQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? CumulativeValue { get; set; }

        [StringLength(255)]
        public string QBID { get; set; }

        public int? TransactionReference { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? ActivityCodeID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ActivityCode DIO_ActivityCode { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryValuationAudit> DIO_InventoryValuationAudit1 { get; set; }

        public virtual DIO_InventoryValuationAudit DIO_InventoryValuationAudit2 { get; set; }
    }
}
