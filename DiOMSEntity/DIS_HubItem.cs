namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_HubItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_HubItem()
        {
            DIO_DefaultPackSize = new HashSet<DIO_DefaultPackSize>();
            DIO_HubItemAllowanceCharge = new HashSet<DIO_HubItemAllowanceCharge>();
            DIO_HubItemSaleRep = new HashSet<DIO_HubItemSaleRep>();
            DIO_HubItemStore = new HashSet<DIO_HubItemStore>();
            DIO_ProductCodes = new HashSet<DIO_ProductCodes>();
            DIO_SuggestionPrice = new HashSet<DIO_SuggestionPrice>();
        }

        [Key]
        public int HubItemID { get; set; }

        public int? MasterItemID { get; set; }

        public int? HubID { get; set; }

        public int? DiscountID { get; set; }

        public int? TaxID { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? StyleID { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        [StringLength(10)]
        public string BuyersCat { get; set; }

        [StringLength(250)]
        public string UPC { get; set; }

        [StringLength(20)]
        public string EAN { get; set; }

        [StringLength(20)]
        public string GTIN { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string HubUOM { get; set; }

        public short? UOMConvert { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public int? DefaultLocation { get; set; }

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

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public decimal? PublishedPrice { get; set; }

        public decimal? SuggestedRetailPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemQtyPerMasterCarton { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemQtyPerInnerCarton { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemQtyPerPallet { get; set; }

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

        public int? WeightCode { get; set; }

        public int? LengthCode { get; set; }

        public int? WidthCode { get; set; }

        public int? HeightCode { get; set; }

        public int? VolumeCode { get; set; }

        public bool? UseVolumeOnly { get; set; }

        public byte? ItemStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReportQuota846 { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinStock846 { get; set; }

        public bool? IsExclusion846 { get; set; }

        public DateTime? ItemDiscontinueDate { get; set; }

        public int? ItemDiscontinueDateType { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? Default846Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefaultQty846 { get; set; }

        [StringLength(100)]
        public string AlternateItems { get; set; }

        [StringLength(20)]
        public string CountryOrigin { get; set; }

        [StringLength(20)]
        public string HSCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThresHold { get; set; }

        [StringLength(20)]
        public string Season { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvailableForPurchase { get; set; }

        public int? NumberOfItemsPerBox { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinSell { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxSell { get; set; }

        public bool? CheckBuyPlan { get; set; }

        public bool? OpentoBuy { get; set; }

        public DateTime? OpentoBuyFrom { get; set; }

        public DateTime? OpentoBuyTo { get; set; }

        public int? AllowBuyQty { get; set; }

        public bool? RequireSendASN { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_DefaultPackSize> DIO_DefaultPackSize { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubItemAllowanceCharge> DIO_HubItemAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubItemSaleRep> DIO_HubItemSaleRep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubItemStore> DIO_HubItemStore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductCodes> DIO_ProductCodes { get; set; }

        public virtual DIO_Style DIO_Style { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SuggestionPrice> DIO_SuggestionPrice { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual ItemDiscontinueDateType ItemDiscontinueDateType1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure4 { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure5 { get; set; }
    }
}
