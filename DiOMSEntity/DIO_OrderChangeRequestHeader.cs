namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OrderChangeRequestHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_OrderChangeRequestHeader()
        {
            DIO_OrderChangeRequestDetail = new HashSet<DIO_OrderChangeRequestDetail>();
            DIO_OrderChangeRequestHeaderAllowanceCharge = new HashSet<DIO_OrderChangeRequestHeaderAllowanceCharge>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public long? OrderTraceStatus { get; set; }

        [StringLength(250)]
        public string BookingNo { get; set; }

        [StringLength(250)]
        public string AuthorizationForExpenseNumber { get; set; }

        [StringLength(250)]
        public string ImportDescription { get; set; }

        [StringLength(250)]
        public string CustomerReferenceNumber { get; set; }

        [StringLength(250)]
        public string DistributionDescription { get; set; }

        [StringLength(250)]
        public string VesselName { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalExtendedLineAmt { get; set; }

        [StringLength(250)]
        public string DocumentNumber { get; set; }

        public bool? IsSentEDI { get; set; }

        [StringLength(250)]
        public string EDISONumber { get; set; }

        [StringLength(250)]
        public string TransactionSetType { get; set; }

        [StringLength(250)]
        public string SONumber { get; set; }

        [StringLength(100)]
        public string ExportedTime { get; set; }

        public DateTime? SODate { get; set; }

        public DateTime? SOChangeDate { get; set; }

        public DateTime? CancelAfterDate { get; set; }

        public int? Status { get; set; }

        [StringLength(20)]
        public string DepartmentNo { get; set; }

        [StringLength(250)]
        public string ProductGroupDescription { get; set; }

        [StringLength(50)]
        public string InternalVendorNo { get; set; }

        [StringLength(10)]
        public string FOBPaymentCode { get; set; }

        [StringLength(200)]
        public string FOBPaymentName { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(255)]
        public string SCACCode { get; set; }

        [StringLength(30)]
        public string ServiceLevelCode { get; set; }

        [StringLength(30)]
        public string CarrierName { get; set; }

        [StringLength(250)]
        public string InfoContactName { get; set; }

        [StringLength(30)]
        public string InfoContactTel { get; set; }

        [StringLength(300)]
        public string Note { get; set; }

        [StringLength(30)]
        public string SOTransactionPurposeCode { get; set; }

        [StringLength(250)]
        public string VendorName { get; set; }

        [StringLength(250)]
        public string DepartmentDescription { get; set; }

        [StringLength(20)]
        public string POReleaseNumber { get; set; }

        [StringLength(30)]
        public string PromotionCode { get; set; }

        [StringLength(250)]
        public string GuestName { get; set; }

        [StringLength(250)]
        public string GuestContactInfo { get; set; }

        [StringLength(250)]
        public string FOBPoint { get; set; }

        [StringLength(250)]
        public string FOBDescription { get; set; }

        [StringLength(255)]
        public string SaleRequirementCode { get; set; }

        [StringLength(255)]
        public string SaleRequirementName { get; set; }

        [StringLength(50)]
        public string OriginalReferenceNo { get; set; }

        [StringLength(250)]
        public string ContractNo { get; set; }

        [StringLength(4000)]
        public string Message { get; set; }

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
        public string TermTypeCode { get; set; }

        [StringLength(50)]
        public string TermTypeDescription { get; set; }

        [StringLength(20)]
        public string TermBasisDateCode { get; set; }

        [StringLength(50)]
        public string TermBasisDateDescription { get; set; }

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

        [StringLength(2)]
        public string RoutingCodeTypeCode { get; set; }

        [StringLength(250)]
        public string RoutingCodeTypeDescription { get; set; }

        [StringLength(250)]
        public string TransportationMethodCode { get; set; }

        [StringLength(250)]
        public string TransportationMethodName { get; set; }

        [StringLength(250)]
        public string ShipToLocation { get; set; }

        [StringLength(20)]
        public string OrderContactFax { get; set; }

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

        public int? NumberOfLine { get; set; }

        [StringLength(250)]
        public string BuyerName { get; set; }

        [StringLength(250)]
        public string BuyerTel { get; set; }

        [StringLength(250)]
        public string BuyerFax { get; set; }

        [StringLength(250)]
        public string BuyerMail { get; set; }

        [StringLength(50)]
        public string BillToContactTel { get; set; }

        [StringLength(250)]
        public string BillToContactName { get; set; }

        [StringLength(50)]
        public string BillToContactFax { get; set; }

        [StringLength(250)]
        public string BillToContactEmail { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        [StringLength(20)]
        public string TotalWeightUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        [StringLength(20)]
        public string TotalVolumeUOM { get; set; }

        [StringLength(20)]
        public string ContactType { get; set; }

        [StringLength(250)]
        public string PortOfLoading { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrePack { get; set; }

        public int? Hub { get; set; }

        public int? SOHeader { get; set; }

        public int? ShipFromCode { get; set; }

        public int? ShipToCode { get; set; }

        public int? BillToCode { get; set; }

        public int? MarkForStore { get; set; }

        public int? BuyerAddress { get; set; }

        public int? ManufactureAddress { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? SONo { get; set; }

        [StringLength(250)]
        public string ItemID { get; set; }

        public int? SalesOrderNo { get; set; }

        [StringLength(50)]
        public string SOOriginalNo { get; set; }

        [StringLength(250)]
        public string EDILnNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestDetail> DIO_OrderChangeRequestDetail { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo4 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo5 { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeaderAllowanceCharge> DIO_OrderChangeRequestHeaderAllowanceCharge { get; set; }
    }
}
