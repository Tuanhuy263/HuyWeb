namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OrderChangeAcknowledgmentHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_OrderChangeAcknowledgmentHeader()
        {
            DIO_OrderChangeAcknowledgmentCommission = new HashSet<DIO_OrderChangeAcknowledgmentCommission>();
            DIO_OrderChangeAcknowledgmentDetail = new HashSet<DIO_OrderChangeAcknowledgmentDetail>();
            DIO_OrderChangeAcknowledgmentFreight = new HashSet<DIO_OrderChangeAcknowledgmentFreight>();
            DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge = new HashSet<DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string GSTCode { get; set; }

        public int? SOHeaderNo { get; set; }

        public bool? IsSentEDI { get; set; }

        [StringLength(50)]
        public string PSTCode { get; set; }

        [StringLength(255)]
        public string PSTDescription { get; set; }

        [StringLength(250)]
        public string ACKPersonName { get; set; }

        [StringLength(250)]
        public string BillToContactName { get; set; }

        [StringLength(250)]
        public string ShipToContactName { get; set; }

        [StringLength(50)]
        public string ACKPersonTel { get; set; }

        [StringLength(250)]
        public string ACKPersonFax { get; set; }

        [StringLength(250)]
        public string ACKPersonEmail { get; set; }

        public int? DiscType { get; set; }

        public int? TermDiscType { get; set; }

        [Key]
        public int OrderChangeAcknowledgmentID { get; set; }

        [StringLength(20)]
        public string TransactionPurposeCode { get; set; }

        [StringLength(20)]
        public string TransactionControlNumber { get; set; }

        [StringLength(250)]
        public string TransactionSetType { get; set; }

        [StringLength(255)]
        public string UserDefined36 { get; set; }

        [StringLength(255)]
        public string UserDefined73 { get; set; }

        [StringLength(255)]
        public string UserDefined74 { get; set; }

        [StringLength(255)]
        public string SONumber { get; set; }

        [StringLength(255)]
        public string OrderChangeRequestNumber { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [StringLength(255)]
        public string EDISONumber { get; set; }

        [StringLength(103)]
        public string SOOriginalNumber { get; set; }

        public DateTime? SODate { get; set; }

        public DateTime? MustArriveDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DueDateCalculation { get; set; }

        [StringLength(250)]
        public string OriginalReferenceNo { get; set; }

        [StringLength(250)]
        public string ContractNo { get; set; }

        public string Message { get; set; }

        [StringLength(250)]
        public string FOBMethodOfPayment { get; set; }

        [StringLength(250)]
        public string FOBPoint { get; set; }

        [StringLength(20)]
        public string SaleRequirementCode { get; set; }

        [StringLength(100)]
        public string InternalVendorNumber { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        [StringLength(255)]
        public string SCACCode { get; set; }

        [StringLength(255)]
        public string RoutingName { get; set; }

        [StringLength(50)]
        public string TransportTypeCode { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? ScheduleShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        [StringLength(500)]
        public string Routing { get; set; }

        [StringLength(30)]
        public string InstructionType { get; set; }

        [StringLength(264)]
        public string SpecialInstruction { get; set; }

        [StringLength(264)]
        public string CarrierName { get; set; }

        public string WarehouseInstruction { get; set; }

        [StringLength(80)]
        public string ShipToDcNumber { get; set; }

        public DateTime? CancelDate { get; set; }

        public DateTime? EffectRequestShipDate { get; set; }

        [StringLength(30)]
        public string RefID { get; set; }

        [StringLength(3)]
        public string RefIDQual { get; set; }

        [StringLength(250)]
        public string FOBDescription { get; set; }

        [StringLength(100)]
        public string GuestName { get; set; }

        [StringLength(100)]
        public string GuestContactInfo { get; set; }

        [StringLength(100)]
        public string HubSenderID { get; set; }

        [StringLength(250)]
        public string BuyerCode { get; set; }

        [StringLength(250)]
        public string FowarderName { get; set; }

        [StringLength(250)]
        public string SupplierCode { get; set; }

        [StringLength(250)]
        public string ShipFromQualifier { get; set; }

        [StringLength(250)]
        public string BillToQualifier { get; set; }

        public byte? Status { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExchangeRateAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalDiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalBeforeDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPaymentDue { get; set; }

        public byte? PriceType { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? TermDiscDueDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax { get; set; }

        [StringLength(30)]
        public string DefaultBolNumber { get; set; }

        [StringLength(255)]
        public string TrackingNumber { get; set; }

        [StringLength(255)]
        public string SpecialHandlingNote { get; set; }

        [StringLength(100)]
        public string BuyerQualifier { get; set; }

        [StringLength(100)]
        public string BuyerName { get; set; }

        [StringLength(50)]
        public string MerchandiseCode { get; set; }

        [StringLength(250)]
        public string ShipToQualifier { get; set; }

        [StringLength(250)]
        public string TicketCode { get; set; }

        [StringLength(255)]
        public string ProductGroupDescription { get; set; }

        [StringLength(255)]
        public string GuestContactPhone { get; set; }

        public long? TraceStatus { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCommissionAmount { get; set; }

        public bool? IsFixPercentCommission { get; set; }

        [Column(TypeName = "money")]
        public decimal? RateFixPercentCommision { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        public int? CalculateChargeTypeTax { get; set; }

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

        [StringLength(20)]
        public string CurrencyCode { get; set; }

        [StringLength(250)]
        public string ACKType { get; set; }

        public DateTime? ACKDate { get; set; }

        public int? HubID { get; set; }

        public int? ChannelID { get; set; }

        public int? ShippingInfoShipFrom { get; set; }

        public int? HubShippingInfoShipTo { get; set; }

        public int? ShippingInfoBillTo { get; set; }

        public int? FreightBillToID { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        public int? DepartmentID { get; set; }

        public int? FOBPaymentID { get; set; }

        public int? Currency { get; set; }

        public int? BaseCurrencyCode { get; set; }

        public int? TermTypeID { get; set; }

        public int? TermBasisDateID { get; set; }

        public int? InvoiceTypeID { get; set; }

        public int? RoutingCodeTypeID { get; set; }

        public int? ShippingInfoMarkForStoreNo { get; set; }

        public int? FixTaxID { get; set; }

        public int? ERPTermID { get; set; }

        public int? FlagID { get; set; }

        public int? TransportationProviderID { get; set; }

        public int? TransportationMethodID { get; set; }

        public int? BillToTransportation { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_BillToTransportation DIO_BillToTransportation { get; set; }

        public virtual DIO_Channel DIO_Channel { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIO_Currency DIO_Currency1 { get; set; }

        public virtual DIO_Department DIO_Department { get; set; }

        public virtual DIO_ERP_Term DIO_ERP_Term { get; set; }

        public virtual DIO_Flag DIO_Flag { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        public virtual DIO_InvoiceType DIO_InvoiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentCommission> DIO_OrderChangeAcknowledgmentCommission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentDetail> DIO_OrderChangeAcknowledgmentDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentFreight> DIO_OrderChangeAcknowledgmentFreight { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_RoutingCodeType DIO_RoutingCodeType { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo4 { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        public virtual DIO_TermBasisDate DIO_TermBasisDate { get; set; }

        public virtual DIO_TermsType DIO_TermsType { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge> DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge { get; set; }
    }
}
