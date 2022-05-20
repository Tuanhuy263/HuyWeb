namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawSIHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawSIHeader()
        {
            DIO_RawSIDetail = new HashSet<DIO_RawSIDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawSIHeaderID { get; set; }

        [StringLength(50)]
        public string ReceiverID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        [StringLength(50)]
        public string InvoiceNumber { get; set; }

        public DateTime? SODate { get; set; }

        [StringLength(50)]
        public string SONumber { get; set; }

        [StringLength(50)]
        public string BuyerCurrency { get; set; }

        [StringLength(50)]
        public string InternalVendorNumber { get; set; }

        [StringLength(50)]
        public string DepartmentNumber { get; set; }

        [StringLength(50)]
        public string ProductGroupDescription { get; set; }

        [StringLength(50)]
        public string ShipToLocation { get; set; }

        [StringLength(50)]
        public string ShipToCode { get; set; }

        [StringLength(50)]
        public string ShipToAddress1 { get; set; }

        [StringLength(50)]
        public string ShipToAddress2 { get; set; }

        [StringLength(50)]
        public string ShipToCity { get; set; }

        [StringLength(100)]
        public string ShipToState { get; set; }

        [StringLength(50)]
        public string ShipToZipcode { get; set; }

        [StringLength(50)]
        public string ShipToCountry { get; set; }

        [StringLength(50)]
        public string BillToName { get; set; }

        [StringLength(50)]
        public string BillToCode { get; set; }

        [StringLength(50)]
        public string BillToAddress { get; set; }

        [StringLength(50)]
        public string BillToCity { get; set; }

        [StringLength(50)]
        public string BillToState { get; set; }

        [StringLength(50)]
        public string BillToZipcode { get; set; }

        [StringLength(50)]
        public string BillToCountry { get; set; }

        [StringLength(50)]
        public string DIIVendorName { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactEmail { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        [StringLength(50)]
        public string ShipToQualifier { get; set; }

        [StringLength(50)]
        public string ContractNO { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalBacthAmount { get; set; }

        [StringLength(50)]
        public string ShipFromName { get; set; }

        [StringLength(50)]
        public string ShipFromCode { get; set; }

        [StringLength(50)]
        public string ShipFromAddName { get; set; }

        [StringLength(50)]
        public string ShipFromAddress { get; set; }

        [StringLength(50)]
        public string ShipFromCity { get; set; }

        [StringLength(50)]
        public string ShipFromState { get; set; }

        [StringLength(50)]
        public string ShipFromZipcode { get; set; }

        [StringLength(50)]
        public string ShipFromCountry { get; set; }

        [StringLength(50)]
        public string RemitToName { get; set; }

        [StringLength(50)]
        public string RemitToCode { get; set; }

        [StringLength(50)]
        public string RemitToAddress { get; set; }

        [StringLength(50)]
        public string RemitToCity { get; set; }

        [StringLength(50)]
        public string RemitToState { get; set; }

        [StringLength(50)]
        public string RemitToZipcode { get; set; }

        [StringLength(50)]
        public string RemitToCountry { get; set; }

        [StringLength(50)]
        public string TermsTypeCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermsDiscPercent { get; set; }

        public DateTime? TermsDiscountDueDate { get; set; }

        public int? TermsDiscDaysDue { get; set; }

        public DateTime? TermsNetDueDate { get; set; }

        public int? TermsNetDays { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermsDiscAmount { get; set; }

        [StringLength(50)]
        public string TermsDescription { get; set; }

        [StringLength(50)]
        public string TermsBasisDateCode { get; set; }

        public DateTime? ShippedDate { get; set; }

        [StringLength(50)]
        public string FOBMethod { get; set; }

        [StringLength(50)]
        public string FOBTransportationTermsCode { get; set; }

        [StringLength(50)]
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

        [StringLength(50)]
        public string Routing { get; set; }

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
        public string UserDefined102 { get; set; }

        [StringLength(50)]
        public string ASNShipmentID { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalUnitShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        public int? NumberOfLineItem { get; set; }

        [StringLength(50)]
        public string UOMForUnitsShipped { get; set; }

        [StringLength(50)]
        public string UnitOfMeasureForTotalWeight { get; set; }

        [StringLength(50)]
        public string BM { get; set; }

        [StringLength(50)]
        public string BillOfLading { get; set; }

        [StringLength(50)]
        public string MerchandiseType { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalNumberOfCases { get; set; }

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
        public string ProNumber { get; set; }

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
        public string InvoiceGSTTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? GSTAmount { get; set; }

        [StringLength(50)]
        public string SalesTaxID { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalesTaxAmount { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawSIDetail> DIO_RawSIDetail { get; set; }
    }
}
