namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawOrderChangeAcknowledgmentDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsValidData { get; set; }

        public bool? IsIgnored { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        [Key]
        public int Raw865DetailID { get; set; }

        [StringLength(250)]
        public string LnNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemOrderedQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemChangedQuantity { get; set; }

        [StringLength(50)]
        public string ItemOrderedUOM { get; set; }

        [StringLength(50)]
        public string ERPItemCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? ChangedUnitPrice { get; set; }

        [StringLength(100)]
        public string CurrencyCode { get; set; }

        [StringLength(50)]
        public string UPCQualifier { get; set; }

        [StringLength(50)]
        public string UPCCode { get; set; }

        [StringLength(50)]
        public string BuyerItemQualifier { get; set; }

        [StringLength(50)]
        public string BuyerItemNo { get; set; }

        [StringLength(50)]
        public string VendorItemQualifier { get; set; }

        [StringLength(50)]
        public string VendorItemNo { get; set; }

        [StringLength(250)]
        public string ProductCode1 { get; set; }

        [StringLength(250)]
        public string ProductCode2 { get; set; }

        [StringLength(250)]
        public string ProductCode3 { get; set; }

        [StringLength(250)]
        public string ProductCode4 { get; set; }

        [StringLength(250)]
        public string ProductCode5 { get; set; }

        [StringLength(250)]
        public string ProductCode6 { get; set; }

        [StringLength(250)]
        public string ProductCode7 { get; set; }

        [StringLength(250)]
        public string ProductCode8 { get; set; }

        [StringLength(250)]
        public string ProductCode9 { get; set; }

        [StringLength(250)]
        public string ProductCode10 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(250)]
        public string ItemDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? NoOfInnerPack { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemTaxAmount { get; set; }

        [StringLength(50)]
        public string ItemStatusCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemACKQuantity { get; set; }

        public int? ItemACKUOMID { get; set; }

        [StringLength(50)]
        public string ItemACKUOM { get; set; }

        [StringLength(50)]
        public string ChangeTypeCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyLeftToRecieved { get; set; }

        [StringLength(250)]
        public string MarkForQualifier { get; set; }

        [StringLength(250)]
        public string MarkForStoreNo { get; set; }

        [StringLength(250)]
        public string MarkForAddress1 { get; set; }

        [StringLength(250)]
        public string MarkForAddress2 { get; set; }

        [StringLength(50)]
        public string MarkForCity { get; set; }

        [StringLength(20)]
        public string MarkForState { get; set; }

        [StringLength(20)]
        public string MarkForZipCode { get; set; }

        [StringLength(250)]
        public string MarkForStoreName { get; set; }

        public int? Raw865ID { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_RawOrderChangeAcknowledgmentHeader DIO_RawOrderChangeAcknowledgmentHeader { get; set; }
    }
}
