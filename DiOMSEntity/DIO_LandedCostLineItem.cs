namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LandedCostLineItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LandedCostItemLineNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomsAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExpenditureAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DistributedAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? WarehouseCost { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        public int? LandedCostHeaderNo { get; set; }

        public int? MasterItemID { get; set; }

        public int? TaxID { get; set; }

        public int? DiscountID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? UOMCode { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        public virtual DIO_LandedCostHeader DIO_LandedCostHeader { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }
    }
}
