namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LandedCostHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_LandedCostHeader()
        {
            DIO_LandedCostLineItem = new HashSet<DIO_LandedCostLineItem>();
            DIO_StockInExpenditure = new HashSet<DIO_StockInExpenditure>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LandedCostHeaderNo { get; set; }

        [StringLength(255)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public int? WHStockInNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public virtual DIO_WHStockIn DIO_WHStockIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LandedCostLineItem> DIO_LandedCostLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInExpenditure> DIO_StockInExpenditure { get; set; }
    }
}
