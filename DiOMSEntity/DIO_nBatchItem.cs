namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_nBatchItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int BatchItemID { get; set; }

        public int? BatchID { get; set; }

        [StringLength(100)]
        public string BatchCode { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? MasterLocationID { get; set; }

        public int? MasterItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Difference { get; set; }

        [StringLength(100)]
        public string ManufactureNumber { get; set; }

        public DateTime? ManufacturingDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? Actived { get; set; }

        public bool? IsNew { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
