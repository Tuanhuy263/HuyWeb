namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawSalesCatalogHeader
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawSalesCatalogID { get; set; }

        [StringLength(500)]
        public string CatalogNumber { get; set; }

        [StringLength(500)]
        public string ReceiverID { get; set; }

        [StringLength(500)]
        public string SenderVendorID { get; set; }

        [StringLength(500)]
        public string VendorSelectionCode { get; set; }

        [StringLength(500)]
        public string SelectionCodeDescription { get; set; }

        [StringLength(500)]
        public string CatalogAction { get; set; }

        [StringLength(500)]
        public string CatalogDate1 { get; set; }

        [StringLength(500)]
        public string CatalogDate2 { get; set; }

        [StringLength(500)]
        public string CatalogDate3 { get; set; }

        [StringLength(500)]
        public string CatalogDate4 { get; set; }

        [StringLength(500)]
        public string CatalogDate5 { get; set; }

        [StringLength(500)]
        public string CatalogDate6 { get; set; }

        [StringLength(500)]
        public string CurrencyCode { get; set; }

        [StringLength(500)]
        public string CountryofOrigin1Name { get; set; }

        [StringLength(500)]
        public string CountryofOrigin1Code { get; set; }

        [StringLength(500)]
        public string CountryofOrigin2Name { get; set; }

        [StringLength(500)]
        public string CountryofOrigin2Code { get; set; }

        [StringLength(500)]
        public string CountryofOrigin3Name { get; set; }

        [StringLength(500)]
        public string CountryofOrigin3Code { get; set; }

        [StringLength(500)]
        public string ShipFromName { get; set; }

        [StringLength(500)]
        public string ShipFromLocationCode { get; set; }

        [StringLength(500)]
        public string ShipFromAddName { get; set; }

        [StringLength(500)]
        public string ShipFromAddress { get; set; }

        [StringLength(500)]
        public string ShipFromCity { get; set; }

        [StringLength(500)]
        public string ShipFromState { get; set; }

        [StringLength(500)]
        public string ShipFromPostalCode { get; set; }

        [StringLength(500)]
        public string ShipFromCountry { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(500)]
        public string ProductQualifier { get; set; }

        [StringLength(500)]
        public string ProductCode { get; set; }

        [StringLength(500)]
        public string VendorProductID { get; set; }

        [StringLength(500)]
        public string ColorCode { get; set; }

        [StringLength(500)]
        public string SizeCode { get; set; }

        public DateTime? ItemPublicationDate { get; set; }

        [StringLength(500)]
        public string ProductDescription { get; set; }

        [StringLength(500)]
        public string TradeBrandName { get; set; }

        [StringLength(500)]
        public string Warranty { get; set; }

        [StringLength(500)]
        public string HazardClassCode { get; set; }

        [StringLength(500)]
        public string HazardClassDescription { get; set; }

        [StringLength(500)]
        public string HarmonizeCode1 { get; set; }

        [StringLength(500)]
        public string HarmonizeCode2 { get; set; }

        [StringLength(500)]
        public string NMFC { get; set; }

        [StringLength(500)]
        public string QuotaCategory { get; set; }

        [StringLength(500)]
        public string ImageDescription { get; set; }

        [StringLength(500)]
        public string Image1 { get; set; }

        [StringLength(500)]
        public string Image2 { get; set; }

        [StringLength(500)]
        public string Image3 { get; set; }

        [StringLength(500)]
        public string ColorDescription { get; set; }

        [StringLength(500)]
        public string SizeDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? PublishedPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SuggestedRetailPrice { get; set; }

        [StringLength(500)]
        public string ConditionType { get; set; }

        [StringLength(500)]
        public string ItemDiscontinueDateTypeCode { get; set; }

        public DateTime? ItemDiscontinueDate { get; set; }

        [StringLength(500)]
        public string UPCType { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinimumQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaximumQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinimumOrderMultiple { get; set; }

        public DateTime? ItemOrderAvailableDate { get; set; }

        public DateTime? ItemShipAvailableDate { get; set; }

        [StringLength(500)]
        public string InvoicedUnitOrMeasure { get; set; }

        [StringLength(500)]
        public string PackageSpecifications { get; set; }

        [Column(TypeName = "money")]
        public decimal? Length { get; set; }

        [Column(TypeName = "money")]
        public decimal? Height { get; set; }

        [Column(TypeName = "money")]
        public decimal? Width { get; set; }

        [StringLength(500)]
        public string UnitofMeasure { get; set; }

        [StringLength(500)]
        public string FabricDescription { get; set; }

        [StringLength(500)]
        public string LeadTime { get; set; }

        [StringLength(500)]
        public string LeadTimeUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackSize { get; set; }

        [StringLength(500)]
        public string PackSizeUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [StringLength(500)]
        public string WeightUnit { get; set; }

        [StringLength(500)]
        public string Volume { get; set; }

        [StringLength(500)]
        public string VolumeUnit { get; set; }

        public int? TotalNumberofLineItems { get; set; }

        [StringLength(500)]
        public string Prepack1RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack1Quantity { get; set; }

        [StringLength(500)]
        public string Prepack1Unit { get; set; }

        [StringLength(500)]
        public string Prepack1ProductType { get; set; }

        [StringLength(500)]
        public string Prepack1ProductCode { get; set; }

        public int? Prepack2LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack2RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack2Quantity { get; set; }

        [StringLength(500)]
        public string Prepack2Unit { get; set; }

        [StringLength(500)]
        public string Prepack2ProductType { get; set; }

        [StringLength(500)]
        public string Prepack2ProductCode { get; set; }

        public int? Prepack3LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack3RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack3Quantity { get; set; }

        [StringLength(500)]
        public string Prepack3Unit { get; set; }

        [StringLength(500)]
        public string Prepack3ProductType { get; set; }

        [StringLength(500)]
        public string Prepack3ProductCode { get; set; }

        public int? Prepack4LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack4RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack4Quantity { get; set; }

        [StringLength(500)]
        public string Prepack4Unit { get; set; }

        [StringLength(500)]
        public string Prepack4ProductType { get; set; }

        [StringLength(500)]
        public string Prepack4ProductCode { get; set; }

        public int? Prepack5LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack5RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack5Quantity { get; set; }

        [StringLength(500)]
        public string Prepack5Unit { get; set; }

        [StringLength(500)]
        public string Prepack5ProductType { get; set; }

        [StringLength(500)]
        public string Prepack5ProductCode { get; set; }

        public int? Prepack6LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack6RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack6Quantity { get; set; }

        [StringLength(500)]
        public string Prepack6Unit { get; set; }

        [StringLength(500)]
        public string Prepack6ProductType { get; set; }

        [StringLength(500)]
        public string Prepack6ProductCode { get; set; }

        public int? Prepack7LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack7RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack7Quantity { get; set; }

        [StringLength(500)]
        public string Prepack7Unit { get; set; }

        [StringLength(500)]
        public string Prepack7ProductType { get; set; }

        [StringLength(500)]
        public string Prepack7ProductCode { get; set; }

        public int? Prepack8LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack8RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack8Quantity { get; set; }

        [StringLength(500)]
        public string Prepack8Unit { get; set; }

        [StringLength(500)]
        public string Prepack8ProductType { get; set; }

        [StringLength(500)]
        public string Prepack8ProductCode { get; set; }

        public int? Prepack9LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack9RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack9Quantity { get; set; }

        [StringLength(500)]
        public string Prepack9Unit { get; set; }

        [StringLength(500)]
        public string Prepack9ProductType { get; set; }

        [StringLength(500)]
        public string Prepack9ProductCode { get; set; }

        public int? Prepack10LineNumber { get; set; }

        [StringLength(500)]
        public string Prepack10RelationshipCode { get; set; }

        [StringLength(500)]
        public string Prepack10Quantity { get; set; }

        [StringLength(500)]
        public string Prepack10Unit { get; set; }

        [StringLength(500)]
        public string Prepack10ProductType { get; set; }

        [StringLength(500)]
        public string Prepack10ProductCode { get; set; }

        [StringLength(500)]
        public string Currency { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
