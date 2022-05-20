namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_VendorItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_VendorItem()
        {
            DIO_ProductCodes = new HashSet<DIO_ProductCodes>();
            DIO_SuggestionPrice = new HashSet<DIO_SuggestionPrice>();
            DIO_VendorItemMasterItem = new HashSet<DIO_VendorItemMasterItem>();
        }

        [Key]
        public int VendorItemID { get; set; }

        public int? VendorID { get; set; }

        public int? DiscountID { get; set; }

        public int? TaxID { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? StyleID { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        [StringLength(25)]
        public string CatalogNumber { get; set; }

        [StringLength(30)]
        public string GTIN { get; set; }

        [StringLength(30)]
        public string UPC { get; set; }

        [StringLength(30)]
        public string EAN { get; set; }

        public decimal? Price { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? LCost { get; set; }

        public short? PackSize { get; set; }

        public short? CaseSize { get; set; }

        [StringLength(50)]
        public string WHSEID { get; set; }

        [StringLength(50)]
        public string ListID { get; set; }

        [StringLength(50)]
        public string ItemOptid1 { get; set; }

        [StringLength(50)]
        public string ItemOptid2 { get; set; }

        [StringLength(50)]
        public string ItemOptid3 { get; set; }

        [StringLength(50)]
        public string ItemOptid4 { get; set; }

        [StringLength(50)]
        public string ItemOptid5 { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(50)]
        public string CONPONUM { get; set; }

        public bool? AlwaysAvailable { get; set; }

        public int? MinorDQty { get; set; }

        public decimal? MinQty { get; set; }

        public decimal? MinOrderValue { get; set; }

        public decimal? MaxQty { get; set; }

        public decimal? MaxOrderValue { get; set; }

        public int? DefaultLocation { get; set; }

        public bool? Alternative { get; set; }

        public decimal? Percentage { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? ColorID { get; set; }

        public int? SizeID { get; set; }

        [StringLength(48)]
        public string ProductCode1 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(48)]
        public string ProductCode2 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(48)]
        public string ProductCode3 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(48)]
        public string ProductCode4 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(48)]
        public string ProductCode5 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(48)]
        public string ProductCode6 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(48)]
        public string ProductCode7 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(48)]
        public string ProductCode8 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(48)]
        public string ProductCode9 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(48)]
        public string ProductCode10 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Length { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? Width { get; set; }

        [Column(TypeName = "money")]
        public decimal? Height { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        public bool? UseVolumeOnly { get; set; }

        public int? WeightCode { get; set; }

        public int? LengthCode { get; set; }

        public int? WidthCode { get; set; }

        public int? HeightCode { get; set; }

        public int? VolumeCode { get; set; }

        public byte? ItemStatus { get; set; }

        public int? MasterItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? MovingAverageGrowthRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? ForecastMinInventoryQty { get; set; }

        public int? ForecastLeadTimeShip { get; set; }

        public int? ForecastLeadTimeReceive { get; set; }

        [StringLength(100)]
        public string HighActivity { get; set; }

        public bool? IsHighVolume { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue1 { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductCodes> DIO_ProductCodes { get; set; }

        public virtual DIO_Style DIO_Style { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SuggestionPrice> DIO_SuggestionPrice { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorItemMasterItem> DIO_VendorItemMasterItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure4 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure5 { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
