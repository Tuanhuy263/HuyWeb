namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawPurchaseInvoiceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawPurchaseInvoiceHeader()
        {
            DIO_RawAllowanceChargePIHeader = new HashSet<DIO_RawAllowanceChargePIHeader>();
            DIO_RawPurchaseInvoiceDetail = new HashSet<DIO_RawPurchaseInvoiceDetail>();
        }

        [Key]
        public int RawPurchaseInvoiceNo { get; set; }

        [StringLength(20)]
        public string PurchaseInvoiceNumber { get; set; }

        [StringLength(50)]
        public string ReceiverID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(50)]
        public string CurrencyCode { get; set; }

        [StringLength(50)]
        public string InternalVendorNumber { get; set; }

        public decimal? ExchangeRateAmount { get; set; }

        public int? Status { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? TotalBeforeDiscount { get; set; }

        public decimal? TotalPaymentDue { get; set; }

        public decimal? TotalPaymentAmount { get; set; }

        public decimal? DueDateCalculation { get; set; }

        public DateTime? TermDiscDueDate { get; set; }

        [StringLength(50)]
        public string TermDiscPercent { get; set; }

        [StringLength(50)]
        public string TermDiscDayDue { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        public decimal? TermDiscAmount { get; set; }

        public DateTime? PODate { get; set; }

        [StringLength(255)]
        public string PONumber { get; set; }

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

        public decimal? TotalInvAmount { get; set; }

        public decimal? TotalInvAmountSubjToTerms { get; set; }

        public decimal? TotalInvAmountLessDiscount { get; set; }

        public decimal? TotalDiscountAmount { get; set; }

        [StringLength(50)]
        public string TransportationTypeCode { get; set; }

        [StringLength(50)]
        public string StandardCarrierAlphaCode { get; set; }

        [StringLength(255)]
        public string RoutingCarrierName { get; set; }

        public decimal? TotalUnitShipped { get; set; }

        public decimal? TotalWeight { get; set; }

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

        public decimal? TotalNumberOfCase { get; set; }

        public decimal? NumberOfLineItem { get; set; }

        public int? InvoiceGSTTaxID { get; set; }

        public decimal? GSTAmount { get; set; }

        public int? HSTSalesTaxID { get; set; }

        public decimal? HSTSalesTaxAmount { get; set; }

        public int? InvalidRawPIType { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent1 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceDescription1 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent2 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceDescription2 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent3 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceDescription3 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent4 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceDescription4 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling4 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceDescription5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling5 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceTypeCode6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowanceAmount6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAllowancePercent6 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceDescription6 { get; set; }

        [StringLength(50)]
        public string InvoiceAllowanceMethodOfHandling6 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent1 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeDescription1 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling1 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent2 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeDescription2 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling2 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent3 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeDescription3 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling3 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent4 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeDescription4 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling4 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeTypeCode5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargeAmount5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceChargePercent5 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeDescription5 { get; set; }

        [StringLength(50)]
        public string InvoiceChargeMethodOfHandling5 { get; set; }

        [StringLength(50)]
        public string UserDefined102 { get; set; }

        [StringLength(250)]
        public string ProNumber { get; set; }

        [StringLength(50)]
        public string ShipmentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawAllowanceChargePIHeader> DIO_RawAllowanceChargePIHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawPurchaseInvoiceDetail> DIO_RawPurchaseInvoiceDetail { get; set; }
    }
}
