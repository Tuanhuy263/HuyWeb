namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawSaleInvoiceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawSaleInvoiceDetail()
        {
            DIO_RawAllowanceChargeSIDetail = new HashSet<DIO_RawAllowanceChargeSIDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawSaleInvoiceDetailNo { get; set; }

        public int? LnNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalSOQty { get; set; }

        [StringLength(50)]
        public string UOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [StringLength(255)]
        public string Relationship { get; set; }

        [StringLength(50)]
        public string BasisOfUnitPriceCode { get; set; }

        [StringLength(255)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceQty { get; set; }

        [StringLength(50)]
        public string Pack { get; set; }

        [StringLength(50)]
        public string ShipmentStatusCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDifference { get; set; }

        [StringLength(50)]
        public string InnerPack { get; set; }

        [StringLength(255)]
        public string SizeDescription { get; set; }

        [StringLength(50)]
        public string PackSize { get; set; }

        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(50)]
        public string ProductCode1 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(50)]
        public string ProductCode2 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(50)]
        public string ProductCode3 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(50)]
        public string ProductCode4 { get; set; }

        [StringLength(50)]
        public string ProductCode5 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(50)]
        public string ProductCode6 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(50)]
        public string ProductCode7 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(50)]
        public string ProductCode8 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(50)]
        public string ProductCode9 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(50)]
        public string ProductCode10 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(255)]
        public string ColorDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendLineAmount { get; set; }

        [StringLength(255)]
        public string BuyerStoreName { get; set; }

        [StringLength(255)]
        public string BuyerStoreCode { get; set; }

        [StringLength(255)]
        public string BuyerStoreAddress1 { get; set; }

        [StringLength(255)]
        public string BuyerStoreAddress2 { get; set; }

        [StringLength(255)]
        public string BuyerStoreCity { get; set; }

        [StringLength(255)]
        public string BuyerStoreState { get; set; }

        [StringLength(255)]
        public string BuyerStoreZipCode { get; set; }

        public int? RawSaleInvoiceNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string UserDefined102 { get; set; }

        [StringLength(255)]
        public string UserDefined196 { get; set; }

        [StringLength(255)]
        public string UserDefined197 { get; set; }

        [StringLength(255)]
        public string UserDefined226 { get; set; }

        [StringLength(255)]
        public string UserDefined227 { get; set; }

        public int? InvalidRawSIType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawAllowanceChargeSIDetail> DIO_RawAllowanceChargeSIDetail { get; set; }

        public virtual DIO_RawSaleInvoiceHeader DIO_RawSaleInvoiceHeader { get; set; }
    }
}
