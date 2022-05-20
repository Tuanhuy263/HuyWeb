namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BlanketPODetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int BlanketDetailNo { get; set; }

        public int? MasterItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainingQuantity { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? UOMCodeBase { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? MasterLocationID { get; set; }

        public DateTime? ShippingDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public int? BlanketPOHeaderNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? FCLQuantity { get; set; }

        public virtual DIO_BlanketPOHeader DIO_BlanketPOHeader { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }
    }
}
