namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw860
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Raw860()
        {
            DIO_Raw860Detail = new HashSet<DIO_Raw860Detail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int Raw860ID { get; set; }

        [StringLength(250)]
        public string DocumentNumber { get; set; }

        [StringLength(250)]
        public string TransactionSetType { get; set; }

        [StringLength(250)]
        public string SONumber { get; set; }

        public DateTime? SODate { get; set; }

        public DateTime? SOChangeDate { get; set; }

        public DateTime? CancelAfterDate { get; set; }

        public int? Status { get; set; }

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

        [StringLength(4000)]
        public string Message { get; set; }

        [StringLength(250)]
        public string SaleRequirement { get; set; }

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

        [StringLength(255)]
        public string SCACCode { get; set; }

        [StringLength(255)]
        public string RoutingName { get; set; }

        [StringLength(50)]
        public string TransportTypeCode { get; set; }

        [StringLength(250)]
        public string ShipToLocation { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator6 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode6 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription6 { get; set; }

        [StringLength(255)]
        public string UserDefined73 { get; set; }

        [StringLength(255)]
        public string UserDefined74 { get; set; }

        [StringLength(255)]
        public string UserDefined25 { get; set; }

        [StringLength(255)]
        public string UserDefined36 { get; set; }

        public DateTime? ScheduleShipDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent6 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling6 { get; set; }

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

        [StringLength(250)]
        public string ShipToQualifier { get; set; }

        [StringLength(250)]
        public string ShipToFacility { get; set; }

        [StringLength(250)]
        public string FowarderName { get; set; }

        [StringLength(250)]
        public string SupplierCode { get; set; }

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
        public string ShipFromQualifier { get; set; }

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
        public string BillToAddress2 { get; set; }

        [StringLength(250)]
        public string BillToCity { get; set; }

        [StringLength(20)]
        public string BillToState { get; set; }

        [StringLength(20)]
        public string BillToZipCode { get; set; }

        [StringLength(250)]
        public string BillToCountry { get; set; }

        [StringLength(250)]
        public string BillToQualifier { get; set; }

        public int? NumberOfLine { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        [StringLength(250)]
        public string EDISONumber { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription1 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription2 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription3 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription4 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription5 { get; set; }

        [StringLength(255)]
        public string UserDefined1 { get; set; }

        [StringLength(255)]
        public string UserDefined2 { get; set; }

        [StringLength(255)]
        public string UserDefined3 { get; set; }

        [StringLength(255)]
        public string UserDefined4 { get; set; }

        [StringLength(255)]
        public string UserDefined5 { get; set; }

        [StringLength(250)]
        public string ShipFromAdditionalName { get; set; }

        [StringLength(20)]
        public string ShipToCode { get; set; }

        [StringLength(30)]
        public string SOTransactionPurposeCode { get; set; }

        [StringLength(250)]
        public string DepartmentDescription { get; set; }

        [StringLength(20)]
        public string POReleaseNumber { get; set; }

        [StringLength(300)]
        public string Note { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? StartShipDate { get; set; }

        [StringLength(30)]
        public string CarrierName { get; set; }

        [StringLength(30)]
        public string ServiceLevelCode { get; set; }

        [StringLength(250)]
        public string InfoContactName { get; set; }

        [StringLength(30)]
        public string InfoContactTel { get; set; }

        [StringLength(20)]
        public string OrderContactFax { get; set; }

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

        [StringLength(250)]
        public string MarkForQualifier { get; set; }

        [StringLength(250)]
        public string BuyerStoreNo { get; set; }

        [StringLength(250)]
        public string BuyerName { get; set; }

        [StringLength(250)]
        public string BuyerAdditionalName { get; set; }

        [StringLength(250)]
        public string BuyerAddress1 { get; set; }

        [StringLength(250)]
        public string BuyerAddress2 { get; set; }

        [StringLength(50)]
        public string BuyerCity { get; set; }

        [StringLength(20)]
        public string BuyerState { get; set; }

        [StringLength(20)]
        public string BuyerZipCode { get; set; }

        [StringLength(50)]
        public string BuyerCountry { get; set; }

        [StringLength(250)]
        public string BuyerTel { get; set; }

        [StringLength(250)]
        public string BuyerFax { get; set; }

        [StringLength(250)]
        public string BuyerMail { get; set; }

        [StringLength(250)]
        public string ManufactureCode { get; set; }

        [StringLength(250)]
        public string ManufactureName { get; set; }

        [StringLength(250)]
        public string ManufactureAddName { get; set; }

        [StringLength(250)]
        public string ManufactureAddress1 { get; set; }

        [StringLength(250)]
        public string ManufactureAddress2 { get; set; }

        [StringLength(50)]
        public string ManufactureCity { get; set; }

        [StringLength(20)]
        public string ManufactureState { get; set; }

        [StringLength(20)]
        public string ManufactureZipCode { get; set; }

        [StringLength(50)]
        public string ManufactureCountry { get; set; }

        [StringLength(50)]
        public string BillToContactTel { get; set; }

        [StringLength(250)]
        public string BillToContactName { get; set; }

        [StringLength(50)]
        public string BillToContactFax { get; set; }

        [StringLength(250)]
        public string BillToContactEmail { get; set; }

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

        [StringLength(250)]
        public string BookingNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrePack { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalExtendedLineAmt { get; set; }

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
        public decimal? MarkForStoreQty { get; set; }

        [StringLength(250)]
        public string MarkForStoreAddress1 { get; set; }

        [StringLength(250)]
        public string MarkForStoreAddress2 { get; set; }

        [StringLength(50)]
        public string MarkForStoreCity { get; set; }

        [StringLength(20)]
        public string MarkForStoreState { get; set; }

        [StringLength(20)]
        public string MarkForStoreZipCode { get; set; }

        [StringLength(250)]
        public string CustomerName { get; set; }

        [StringLength(250)]
        public string EDILnNo { get; set; }

        [StringLength(50)]
        public string SOOriginalNo { get; set; }

        public int? SONo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw860Detail> DIO_Raw860Detail { get; set; }
    }
}
