namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawOrderChangeAcknowledgmentHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawOrderChangeAcknowledgmentHeader()
        {
            DIO_RawOrderChangeAcknowledgmentDetail = new HashSet<DIO_RawOrderChangeAcknowledgmentDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        [Key]
        public int Raw865ID { get; set; }

        [StringLength(250)]
        public string TransactionControlNumber { get; set; }

        [StringLength(250)]
        public string ReceiverID { get; set; }

        [StringLength(250)]
        public string TransactionSetType { get; set; }

        [StringLength(250)]
        public string ACKType { get; set; }

        [StringLength(250)]
        public string PONumber { get; set; }

        public int? PONumberID { get; set; }

        [StringLength(250)]
        public string EDISONumber { get; set; }

        public DateTime? PODate { get; set; }

        public DateTime? ACKDate { get; set; }

        public int? CurrencyID { get; set; }

        public int? HubID { get; set; }

        [StringLength(20)]
        public string CurrencyCode { get; set; }

        [StringLength(50)]
        public string HubSenderID { get; set; }

        [StringLength(50)]
        public string InternalVendorNo { get; set; }

        [StringLength(250)]
        public string FOBMethodOfPayment { get; set; }

        [StringLength(250)]
        public string FOBPoint { get; set; }

        [StringLength(250)]
        public string FOBDescription { get; set; }

        [StringLength(20)]
        public string SaleRequirementCode { get; set; }

        [StringLength(20)]
        public string TermsTypeCode { get; set; }

        [StringLength(20)]
        public string TermsBasisDateCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermsDiscountPercent { get; set; }

        public DateTime? TermsDiscountDueDate { get; set; }

        public int? TermsDiscDaysDue { get; set; }

        public DateTime? TermsNetDueDate { get; set; }

        public int? TermsNetDays { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermsDiscountAmount { get; set; }

        [StringLength(250)]
        public string TermsDescription { get; set; }

        [StringLength(250)]
        public string SCACCode { get; set; }

        public int? TransportationMethodID { get; set; }

        [StringLength(20)]
        public string TransportationMethodCode { get; set; }

        [StringLength(250)]
        public string CarrierName { get; set; }

        [StringLength(4000)]
        public string SpecialInstruction { get; set; }

        [StringLength(4000)]
        public string MessageText { get; set; }

        [StringLength(250)]
        public string ACKPersonName { get; set; }

        [StringLength(50)]
        public string ACKPersonTel { get; set; }

        [StringLength(250)]
        public string ACKPersonFax { get; set; }

        [StringLength(250)]
        public string ACKPersonEmail { get; set; }

        [StringLength(250)]
        public string ShipToName { get; set; }

        [StringLength(250)]
        public string ShipToCodeType { get; set; }

        [StringLength(250)]
        public string ShipToCode { get; set; }

        [StringLength(250)]
        public string ShipToAddress { get; set; }

        [StringLength(250)]
        public string ShipToCity { get; set; }

        [StringLength(20)]
        public string ShipToState { get; set; }

        [StringLength(20)]
        public string ShipToZipCode { get; set; }

        [StringLength(250)]
        public string ShipToCountryCode { get; set; }

        [StringLength(250)]
        public string ShipToContactName { get; set; }

        [StringLength(250)]
        public string ShipToContactPhone { get; set; }

        [StringLength(250)]
        public string ShipToContactEmail { get; set; }

        [StringLength(250)]
        public string BillToName { get; set; }

        [StringLength(50)]
        public string BillToCodeType { get; set; }

        [StringLength(50)]
        public string BillToCode { get; set; }

        [StringLength(250)]
        public string BillToAddress1 { get; set; }

        [StringLength(250)]
        public string BillToAddress2 { get; set; }

        [StringLength(250)]
        public string BillToCity { get; set; }

        [StringLength(20)]
        public string BillToState { get; set; }

        [StringLength(20)]
        public string BillToZipCode { get; set; }

        [StringLength(250)]
        public string BillToCountryCode { get; set; }

        [StringLength(250)]
        public string BillToContactName { get; set; }

        [StringLength(250)]
        public string BillToContactPhone { get; set; }

        [StringLength(250)]
        public string BillToContactEmail { get; set; }

        [StringLength(250)]
        public string ShipFromName { get; set; }

        [StringLength(20)]
        public string ShipFromCodeType { get; set; }

        [StringLength(20)]
        public string ShipFromCode { get; set; }

        [StringLength(250)]
        public string ShipFromAddress { get; set; }

        [StringLength(250)]
        public string ShipFromCity { get; set; }

        [StringLength(20)]
        public string ShipFromState { get; set; }

        [StringLength(20)]
        public string ShipFromZipCode { get; set; }

        [StringLength(250)]
        public string ShipFromCountryCode { get; set; }

        [StringLength(20)]
        public string DepartmentNo { get; set; }

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

        [StringLength(255)]
        public string AllowanceDescription1 { get; set; }

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

        [StringLength(255)]
        public string AllowanceDescription2 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator3 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode3 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling3 { get; set; }

        [StringLength(250)]
        public string AllowanceDescription3 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator4 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode4 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling4 { get; set; }

        [StringLength(250)]
        public string AllowanceDescription4 { get; set; }

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
        public string AllowanceDescription5 { get; set; }

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
        public string AllowanceDescription6 { get; set; }

        [StringLength(250)]
        public string UserDefined1 { get; set; }

        [StringLength(250)]
        public string UserDefined2 { get; set; }

        [StringLength(250)]
        public string UserDefined3 { get; set; }

        [StringLength(250)]
        public string UserDefined4 { get; set; }

        [StringLength(250)]
        public string UserDefined5 { get; set; }

        [StringLength(250)]
        public string UserDefined6 { get; set; }

        [StringLength(250)]
        public string UserDefined7 { get; set; }

        [StringLength(250)]
        public string UserDefined8 { get; set; }

        [StringLength(250)]
        public string UserDefined9 { get; set; }

        [StringLength(250)]
        public string UserDefined10 { get; set; }

        public int? NumberOfLine { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public int? ShipToAddressId { get; set; }

        public int? ShipFromAddressId { get; set; }

        public int? ShippingInfoBillTo { get; set; }

        public int? ShippingInfoMarkForStore { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? ScheduleShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        public DateTime? CancelDate { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

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

        [StringLength(255)]
        public string OrderChangeRequestNumber { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawOrderChangeAcknowledgmentDetail> DIO_RawOrderChangeAcknowledgmentDetail { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }
    }
}
