namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CategoryItemPolicy
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CategoryItemPolicyID { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? FromQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public bool? IsActive { get; set; }

        public int? Priority { get; set; }

        public int? CategoryItemID { get; set; }

        public int? CurrencyID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_CategoryItems DIO_CategoryItems { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }
    }
}
