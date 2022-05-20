namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHShipAdvDRaw
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHShipAdvDRawID { get; set; }

        [StringLength(255)]
        public string CartonCode { get; set; }

        public int? LineItemNo { get; set; }

        [StringLength(255)]
        public string ProductDescription { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        [StringLength(255)]
        public string ProductCode1 { get; set; }

        [StringLength(10)]
        public string ProductQualifier1 { get; set; }

        [StringLength(255)]
        public string ProductCode2 { get; set; }

        [StringLength(10)]
        public string ProductQualifier2 { get; set; }

        [StringLength(255)]
        public string ProductCode3 { get; set; }

        [StringLength(10)]
        public string ProductQualifier3 { get; set; }

        [StringLength(255)]
        public string ProductCode4 { get; set; }

        [StringLength(10)]
        public string ProductQualifier4 { get; set; }

        [StringLength(255)]
        public string ProductCode5 { get; set; }

        [StringLength(10)]
        public string ProductQualifier5 { get; set; }

        [StringLength(255)]
        public string ProductCode6 { get; set; }

        [StringLength(10)]
        public string ProductQualifier6 { get; set; }

        [StringLength(255)]
        public string ProductCode7 { get; set; }

        [StringLength(10)]
        public string ProductQualifier7 { get; set; }

        [StringLength(255)]
        public string ProductCode8 { get; set; }

        [StringLength(10)]
        public string ProductQualifier8 { get; set; }

        [StringLength(255)]
        public string ProductCode9 { get; set; }

        [StringLength(10)]
        public string ProductQualifier9 { get; set; }

        [StringLength(255)]
        public string ProductCode10 { get; set; }

        [StringLength(10)]
        public string ProductQualifier10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(10)]
        public string UOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyOrdered { get; set; }

        [StringLength(10)]
        public string StatusType { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [StringLength(10)]
        public string WeightQualifier { get; set; }

        [StringLength(255)]
        public string LotNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQtyLot { get; set; }

        [StringLength(255)]
        public string ManifestNo { get; set; }

        [StringLength(255)]
        public string VehicleIDNo { get; set; }

        public DateTime? LotNoDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDiff { get; set; }

        [StringLength(255)]
        public string UCCode { get; set; }

        [StringLength(10)]
        public string WeightUOM { get; set; }

        public int? WHShipAdvHRawID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string UPCCode { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        public int? MasterItemID { get; set; }

        public int? WHShipOrderDetailID { get; set; }

        public int? SODetailID { get; set; }

        public int? CartonID { get; set; }

        public virtual DIO_WHShipAdvHRaw DIO_WHShipAdvHRaw { get; set; }
    }
}
