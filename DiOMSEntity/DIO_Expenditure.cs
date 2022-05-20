namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Expenditure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Expenditure()
        {
            DIO_StockInExpenditure = new HashSet<DIO_StockInExpenditure>();
        }

        [Key]
        public int ExpenditureID { get; set; }

        [Required]
        [StringLength(20)]
        public string ExpenditureCode { get; set; }

        [Required]
        [StringLength(250)]
        public string ExpenditureName { get; set; }

        public decimal? Amount { get; set; }

        public byte DistributedMethod { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInExpenditure> DIO_StockInExpenditure { get; set; }
    }
}
