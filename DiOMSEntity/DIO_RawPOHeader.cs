namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawPOHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawPOHeader()
        {
            DIO_RawPODetail = new HashSet<DIO_RawPODetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawPOHeaderId { get; set; }

        [StringLength(20)]
        public string TransactionControlNo { get; set; }

        [StringLength(10)]
        public string TransType { get; set; }

        [StringLength(30)]
        public string POTransactionPurposeCode { get; set; }

        [StringLength(50)]
        public string PONumber { get; set; }

        public DateTime? PODate { get; set; }

        [StringLength(20)]
        public string DepartmentNo { get; set; }

        [StringLength(250)]
        public string ProductGroupDescription { get; set; }

        [StringLength(250)]
        public string FutureUse7 { get; set; }

        [StringLength(50)]
        public string HubSenderID { get; set; }

        [StringLength(50)]
        public string InternalVendorNo { get; set; }

        [StringLength(250)]
        public string VendorName { get; set; }

        [StringLength(30)]
        public string PromotionCode { get; set; }

        [StringLength(250)]
        public string GuestName { get; set; }

        [StringLength(250)]
        public string GuestContactInfo { get; set; }

        [StringLength(250)]
        public string FOBMethodOfPayment { get; set; }

        [StringLength(250)]
        public string FOBPoint { get; set; }

        [StringLength(250)]
        public string FOBDescription { get; set; }

        [StringLength(20)]
        public string SaleRequirementCode { get; set; }

        [StringLength(50)]
        public string OriginalReferenceNo { get; set; }

        [StringLength(250)]
        public string ContractNo { get; set; }

        [StringLength(250)]
        public string Message { get; set; }

        [StringLength(250)]
        public string SaleRequirement { get; set; }

        public DateTime? POChangeDate { get; set; }

        [StringLength(20)]
        public string CurrencyCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscountAmount { get; set; }

        [StringLength(30)]
        public string VendorNo { get; set; }

        [StringLength(50)]
        public string SpecialTicketType { get; set; }

        [StringLength(50)]
        public string SpecialOrderType { get; set; }

        [StringLength(20)]
        public string TermsTypeCode { get; set; }

        [StringLength(20)]
        public string TermsBasisDateType { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscDaysDue { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        public int? TermsNetDays { get; set; }

        public DateTime? TermsNetDueDate { get; set; }

        public DateTime? TermsDiscountDueDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDayOfMonth { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        [StringLength(30)]
        public string RoutingCodeType { get; set; }

        [StringLength(50)]
        public string TransportTypeCode { get; set; }

        [StringLength(250)]
        public string ShipToLocation { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator6 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent6 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling6 { get; set; }

        [StringLength(250)]
        public string ShipToName { get; set; }

        [StringLength(250)]
        public string ShipToAdress2 { get; set; }

        [StringLength(250)]
        public string ShipToAdress1 { get; set; }

        [StringLength(250)]
        public string ShipToCity { get; set; }

        [StringLength(20)]
        public string ShipToState { get; set; }

        [StringLength(20)]
        public string ShipToZipCode { get; set; }

        [StringLength(20)]
        public string ShipFromCode { get; set; }

        [StringLength(250)]
        public string ShipFromName { get; set; }

        [StringLength(250)]
        public string ShipFromAddress1 { get; set; }

        [StringLength(250)]
        public string ShipFromAddress2 { get; set; }

        [StringLength(250)]
        public string ShipFromCity { get; set; }

        [StringLength(20)]
        public string ShipFromState { get; set; }

        [StringLength(20)]
        public string ShipFromZipCode { get; set; }

        [StringLength(250)]
        public string ShipFormCountry { get; set; }

        [StringLength(250)]
        public string OrderedByContactFirstName { get; set; }

        [StringLength(250)]
        public string OrderedByContactLastName { get; set; }

        [StringLength(30)]
        public string OrderedByContactPhone { get; set; }

        [StringLength(250)]
        public string OrderedByContactEmail { get; set; }

        [StringLength(250)]
        public string OrderedByName { get; set; }

        [StringLength(250)]
        public string OrderedByAddress1 { get; set; }

        [StringLength(250)]
        public string OrderedByAddress2 { get; set; }

        [StringLength(250)]
        public string OrderedByCity { get; set; }

        [StringLength(20)]
        public string OrderedByState { get; set; }

        [StringLength(20)]
        public string OrderedByZipCode { get; set; }

        [StringLength(250)]
        public string OrderedByCountry { get; set; }

        [StringLength(250)]
        public string BillToName { get; set; }

        [StringLength(50)]
        public string BillToCode { get; set; }

        [StringLength(250)]
        public string BillToAddress { get; set; }

        [StringLength(250)]
        public string BillToCity { get; set; }

        [StringLength(20)]
        public string BillToState { get; set; }

        [StringLength(20)]
        public string BillToZipCode { get; set; }

        [StringLength(250)]
        public string BillToCountry { get; set; }

        public int? NumberOfLineItem { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderAmount { get; set; }

        [StringLength(50)]
        public string MerchandiseCode { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator1 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent1 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling1 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator2 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent2 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling2 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator3 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent3 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling3 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator4 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent4 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling4 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator5 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent5 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling5 { get; set; }

        [StringLength(250)]
        public string FutureUse159 { get; set; }

        [StringLength(20)]
        public string InvoiceType { get; set; }

        [StringLength(250)]
        public string FutureUse161 { get; set; }

        [StringLength(250)]
        public string FutureUse162 { get; set; }

        [StringLength(250)]
        public string FutureUse163 { get; set; }

        public int? InvalidRawPOType { get; set; }

        public byte? Status { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int? RawType { get; set; }

        public bool? IsGeneratePO { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription6 { get; set; }

        [StringLength(255)]
        public string UserDefined73 { get; set; }

        [StringLength(255)]
        public string UserDefined74 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawPODetail> DIO_RawPODetail { get; set; }
    }
}
