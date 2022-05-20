namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawSaleInvoiceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawSaleInvoiceHeader()
        {
            DIO_RawAllowanceChargeSIHeader = new HashSet<DIO_RawAllowanceChargeSIHeader>();
            DIO_RawSaleInvoiceDetail = new HashSet<DIO_RawSaleInvoiceDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawSaleInvoiceNo { get; set; }

        [StringLength(20)]
        public string SaleInvoiceNumber { get; set; }

        [StringLength(50)]
        public string ReceiverID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(50)]
        public string CurrencyCode { get; set; }

        [StringLength(50)]
        public string InternalVendorNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExchangeRateAmount { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalBeforeDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPaymentDue { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPaymentAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DueDateCalculation { get; set; }

        public DateTime? TermDiscDueDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscPercent { get; set; }

        [StringLength(50)]
        public string TermDiscDayDue { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscAmount { get; set; }

        public DateTime? SODate { get; set; }

        [StringLength(255)]
        public string SONumber { get; set; }

        [StringLength(255)]
        public string DepartmentNumber { get; set; }

        [StringLength(50)]
        public string ProductGroupDescription { get; set; }

        [StringLength(255)]
        public string ShipToLocation { get; set; }

        [StringLength(255)]
        public string ShipToCode { get; set; }

        [StringLength(255)]
        public string ShipToAdditionalName { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(255)]
        public string ShipToCity { get; set; }

        [StringLength(255)]
        public string ShipToState { get; set; }

        [StringLength(255)]
        public string ShipToZipCode { get; set; }

        [StringLength(255)]
        public string ShipToCountry { get; set; }

        [StringLength(255)]
        public string BillToName { get; set; }

        [StringLength(255)]
        public string BillToCode { get; set; }

        [StringLength(255)]
        public string BillToAddress { get; set; }

        [StringLength(255)]
        public string BillToCity { get; set; }

        [StringLength(255)]
        public string BillToState { get; set; }

        [StringLength(255)]
        public string BillToZipCode { get; set; }

        [StringLength(255)]
        public string BillToCountry { get; set; }

        [StringLength(255)]
        public string DIIVendorNameProfileID { get; set; }

        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(255)]
        public string ContactEmail { get; set; }

        [StringLength(30)]
        public string ContactPhone { get; set; }

        [StringLength(50)]
        public string ShipToQualifier { get; set; }

        [StringLength(50)]
        public string ContractNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalBatchAmount { get; set; }

        [StringLength(255)]
        public string ShipFromName { get; set; }

        [StringLength(255)]
        public string ShipFromCode { get; set; }

        [StringLength(255)]
        public string ShipFromAddName { get; set; }

        [StringLength(255)]
        public string ShipFromAddress { get; set; }

        [StringLength(255)]
        public string ShipFromCity { get; set; }

        [StringLength(255)]
        public string ShipFromState { get; set; }

        [StringLength(255)]
        public string ShipFromZipCode { get; set; }

        [StringLength(255)]
        public string ShipFromCountry { get; set; }

        [StringLength(255)]
        public string RemitToName { get; set; }

        [StringLength(255)]
        public string RemitToCode { get; set; }

        [StringLength(255)]
        public string RemitToAddress { get; set; }

        [StringLength(255)]
        public string RemitToCity { get; set; }

        [StringLength(255)]
        public string RemitToState { get; set; }

        [StringLength(255)]
        public string RemitToZipCode { get; set; }

        [StringLength(255)]
        public string RemitToCountry { get; set; }

        [StringLength(255)]
        public string TermTypeCode { get; set; }

        public DateTime? TermNetDueDate { get; set; }

        [StringLength(255)]
        public string TermDiscDaysDue { get; set; }

        public int? TermsNetDays { get; set; }

        [StringLength(50)]
        public string TermBasisDateCode { get; set; }

        public DateTime? ShippedDate { get; set; }

        [StringLength(50)]
        public string FOBMethodOfPayment { get; set; }

        [StringLength(50)]
        public string FOBTransportationTermCode { get; set; }

        [StringLength(255)]
        public string FOBDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalInvAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalInvAmountSubjToTerms { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalInvAmountLessDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscountAmount { get; set; }

        [StringLength(50)]
        public string TransportationTypeCode { get; set; }

        [StringLength(50)]
        public string StandardCarrierAlphaCode { get; set; }

        [StringLength(255)]
        public string RoutingCarrierName { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalUnitShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        [StringLength(50)]
        public string UOMForUnitShipped { get; set; }

        [StringLength(50)]
        public string UOMForTotalWeight { get; set; }

        [StringLength(50)]
        public string BMCNQual { get; set; }

        [StringLength(50)]
        public string BillOfLading { get; set; }

        [StringLength(50)]
        public string MerchandiseType { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalNumberOfCase { get; set; }

        [Column(TypeName = "money")]
        public decimal? NumberOfLineItem { get; set; }

        public int? InvoiceGSTTaxID { get; set; }

        [Column(TypeName = "money")]
        public decimal? GSTAmount { get; set; }

        public int? HSTSalesTaxID { get; set; }

        [Column(TypeName = "money")]
        public decimal? HSTSalesTaxAmount { get; set; }

        public int? InvalidRawSIType { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string SCACCode { get; set; }

        public DateTime? POReceivedDate { get; set; }

        [StringLength(255)]
        public string TotalUnitShippedUOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawAllowanceChargeSIHeader> DIO_RawAllowanceChargeSIHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawSaleInvoiceDetail> DIO_RawSaleInvoiceDetail { get; set; }
    }
}
