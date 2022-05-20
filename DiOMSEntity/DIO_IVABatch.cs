namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_IVABatch
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int IVABatchID { get; set; }

        public DateTime? SystemDate { get; set; }

        [StringLength(255)]
        public string DocumentNo { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public DateTime? DocumentDate { get; set; }

        public DateTime? BBD { get; set; }

        [StringLength(100)]
        public string ActivityCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransactionQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? CumulativeQuantity { get; set; }

        public int? BatchID { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        public DateTime? IVADate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? BatchContainer { get; set; }

        [Column(TypeName = "money")]
        public decimal? TransQuantity { get; set; }

        public byte? IVAType { get; set; }

        [StringLength(100)]
        public string MasterLocationCode { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }

        public virtual DIO_BatchContainer DIO_BatchContainer { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }
    }
}
