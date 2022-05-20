namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_MasterItemAudit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MasterItemID { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public int? ColorID { get; set; }

        public int? SizeID { get; set; }

        public int? FabricID { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? GroupItemID { get; set; }

        [StringLength(20)]
        public string GTIN { get; set; }

        [StringLength(20)]
        public string ERPItemCode { get; set; }

        [StringLength(20)]
        public string UPC { get; set; }

        [StringLength(20)]
        public string EAN { get; set; }

        public int? ItemType { get; set; }

        public int? OwnerType { get; set; }

        public int? GlobalStyle { get; set; }

        public decimal? Density { get; set; }

        public decimal? Depth { get; set; }

        public decimal? Diameter { get; set; }

        public decimal? Gauge { get; set; }

        public decimal? Length { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Width { get; set; }

        public decimal? Height { get; set; }

        public decimal? Volume { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(3)]
        public string BasicUnitPrice { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? LCost { get; set; }

        public byte? ManagementType { get; set; }

        public int? ValuationMethod { get; set; }

        [StringLength(48)]
        public string ProductCode1 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(48)]
        public string ProductCode2 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(48)]
        public string ProductCode3 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(48)]
        public string ProductCode4 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(48)]
        public string ProductCode5 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(48)]
        public string ProductCode6 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(48)]
        public string ProductCode7 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(48)]
        public string ProductCode8 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(48)]
        public string ProductCode9 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(48)]
        public string ProductCode10 { get; set; }

        [StringLength(2)]
        public string ProductCodeQualifier10 { get; set; }

        public int? ObjectType { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        public decimal? LengthBaseRate { get; set; }

        public decimal? WidthBaseRate { get; set; }

        public decimal? HeightBaseRate { get; set; }

        public decimal? WeightBaseRate { get; set; }

        public decimal? VolumeBaseRate { get; set; }

        public int? LengthCode { get; set; }

        public int? WidthCode { get; set; }

        public int? HeightCode { get; set; }

        public int? VolumeCode { get; set; }

        public int? WeightCode { get; set; }

        public int? LengthBaseCode { get; set; }

        public int? WeightBaseCode { get; set; }

        public int? CustomsID { get; set; }

        public bool? NonInventory { get; set; }

        public bool? NonReturn { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
