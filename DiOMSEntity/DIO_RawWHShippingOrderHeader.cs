namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawWHShippingOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawWHShippingOrderHeader()
        {
            DIO_RawWHShippingOrderDetail = new HashSet<DIO_RawWHShippingOrderDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawWHShippingOrderHeaderID { get; set; }

        [StringLength(20)]
        public string TransactionPurposeCode { get; set; }

        [StringLength(20)]
        public string TransactionControlNo { get; set; }

        [StringLength(255)]
        public string SpecialTicketType { get; set; }

        [StringLength(255)]
        public string DocumentNumber { get; set; }

        [StringLength(255)]
        public string SpecialOrderType { get; set; }

        [StringLength(255)]
        public string UserDefined36 { get; set; }

        [StringLength(255)]
        public string BuyerStoreNumber { get; set; }

        [StringLength(10)]
        public string ProNo { get; set; }

        [StringLength(255)]
        public string ForwarderName { get; set; }

        [StringLength(255)]
        public string UserDefined73 { get; set; }

        [StringLength(255)]
        public string UserDefined74 { get; set; }

        [StringLength(255)]
        public string SONumber { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [StringLength(255)]
        public string EDISONumber { get; set; }

        [StringLength(103)]
        public string SOOriginalNumber { get; set; }

        public DateTime? SODate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DueDateCalculation { get; set; }

        [StringLength(10)]
        public string PromotionCode { get; set; }

        [StringLength(30)]
        public string OriginalReferenceNo { get; set; }

        [StringLength(50)]
        public string ContractNo { get; set; }

        public string Message { get; set; }

        [StringLength(100)]
        public string InternalVendorNumber { get; set; }

        [StringLength(100)]
        public string VendorName { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        public int? InvalidRawWHSOType { get; set; }

        [StringLength(255)]
        public string SCACCode { get; set; }

        [StringLength(255)]
        public string RoutingName { get; set; }

        [StringLength(50)]
        public string TransportTypeCode { get; set; }

        [StringLength(50)]
        public string ShippingMethod { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? ScheduleShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        [StringLength(500)]
        public string Routing { get; set; }

        [StringLength(30)]
        public string InstructionType { get; set; }

        [StringLength(500)]
        public string WarehouseInstruction { get; set; }

        [StringLength(80)]
        public string ShipToDcNumber { get; set; }

        public DateTime? CancelDate { get; set; }

        public DateTime? EffectRequestShipDate { get; set; }

        [StringLength(30)]
        public string RefID { get; set; }

        [StringLength(3)]
        public string RefIDQual { get; set; }

        [StringLength(60)]
        public string OrderByContactFirstName { get; set; }

        [StringLength(60)]
        public string OrderByContactLastName { get; set; }

        [StringLength(80)]
        public string OrderByContactPhone { get; set; }

        [StringLength(100)]
        public string OrderByContactEmail { get; set; }

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
        public string ShipToQualifier { get; set; }

        [StringLength(250)]
        public string ShipFromQualifier { get; set; }

        [StringLength(250)]
        public string BillToQualifier { get; set; }

        public int? Status { get; set; }

        public bool? IsBackOrder { get; set; }

        public byte? AllocationStatus { get; set; }

        public int? TransitTime { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPaymentDue { get; set; }

        public byte? PriceType { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? TermDiscDueDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscDayDue { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalBeforeDiscount { get; set; }

        [StringLength(255)]
        public string TrackingNumber { get; set; }

        [StringLength(255)]
        public string LabelFileName { get; set; }

        [StringLength(255)]
        public string EDIHubName { get; set; }

        [StringLength(255)]
        public string EDIShipToName { get; set; }

        [StringLength(255)]
        public string EDIAddress1 { get; set; }

        [StringLength(255)]
        public string EDIAddress2 { get; set; }

        [StringLength(255)]
        public string EDIAddress3 { get; set; }

        [StringLength(255)]
        public string EDICity { get; set; }

        [StringLength(255)]
        public string EDIState { get; set; }

        [StringLength(255)]
        public string EDICountry { get; set; }

        [StringLength(255)]
        public string EDIZipCode { get; set; }

        [StringLength(255)]
        public string EDIPhone { get; set; }

        [StringLength(255)]
        public string SpecialHandlingNote { get; set; }

        [StringLength(100)]
        public string BuyerQualifier { get; set; }

        [StringLength(100)]
        public string BuyerName { get; set; }

        [StringLength(50)]
        public string MerchandiseCode { get; set; }

        [StringLength(255)]
        public string ShipToFacility { get; set; }

        [StringLength(250)]
        public string TicketCode { get; set; }

        [StringLength(255)]
        public string ProductGroupDescription { get; set; }

        [StringLength(255)]
        public string GuestContactPhone { get; set; }

        public long? SOTraceStatus { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCommissionAmount { get; set; }

        public bool? IsFixPercentCommission { get; set; }

        [Column(TypeName = "money")]
        public decimal? RateFixPercentCommision { get; set; }

        public int? SOType { get; set; }

        [StringLength(255)]
        public string InfoContactName { get; set; }

        [StringLength(50)]
        public string InfoContactTel { get; set; }

        [StringLength(250)]
        public string OrderByContactFax { get; set; }

        [StringLength(255)]
        public string ServiceTechnicianName { get; set; }

        [StringLength(255)]
        public string ServiceTechnicianTel { get; set; }

        [StringLength(50)]
        public string BillToContactTel { get; set; }

        [StringLength(50)]
        public string BillToContactFax { get; set; }

        [StringLength(50)]
        public string BillToContactEmail { get; set; }

        [StringLength(50)]
        public string LnNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? NumberOfLineItem { get; set; }

        public bool? CreatePOFromSO { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderAmount { get; set; }

        [StringLength(50)]
        public string GSTCode { get; set; }

        [StringLength(255)]
        public string GSTDescription { get; set; }

        [StringLength(50)]
        public string PSTCode { get; set; }

        [StringLength(255)]
        public string PSTDescription { get; set; }

        [StringLength(255)]
        public string DepositorOrder { get; set; }

        [StringLength(255)]
        public string LinkSequence { get; set; }

        [StringLength(255)]
        public string MasterReference { get; set; }

        [StringLength(255)]
        public string ShipToCodeType { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalShippedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalShipmentWeight { get; set; }

        [StringLength(20)]
        public string InvoiceType { get; set; }

        [StringLength(20)]
        public string SaleRequirementCode { get; set; }

        [StringLength(20)]
        public string DepartmentNo { get; set; }

        [StringLength(250)]
        public string FOBMethodOfPayment { get; set; }

        [StringLength(250)]
        public string FOBPoint { get; set; }

        [StringLength(20)]
        public string TermsTypeCode { get; set; }

        [StringLength(20)]
        public string TermsBasisDateType { get; set; }

        [StringLength(50)]
        public string InternalVendorNo { get; set; }

        [StringLength(30)]
        public string SOTransactionPurposeCode { get; set; }

        [StringLength(250)]
        public string OrderedByContactFirstName { get; set; }

        [StringLength(250)]
        public string OrderedByContactLastName { get; set; }

        [StringLength(30)]
        public string OrderedByContactPhone { get; set; }

        [StringLength(250)]
        public string OrderedByContactEmail { get; set; }

        [StringLength(20)]
        public string OrderContactFax { get; set; }

        [StringLength(250)]
        public string ShipToLocation { get; set; }

        [StringLength(250)]
        public string ShipToName { get; set; }

        [StringLength(250)]
        public string ShipToAddName { get; set; }

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

        [StringLength(250)]
        public string ShipToPhone { get; set; }

        [StringLength(250)]
        public string ShipToCountry { get; set; }

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

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawWHShippingOrderDetail> DIO_RawWHShippingOrderDetail { get; set; }
    }
}
