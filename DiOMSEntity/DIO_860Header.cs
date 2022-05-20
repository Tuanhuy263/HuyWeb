namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_860Header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_860Header()
        {
            DIO_860Detail = new HashSet<DIO_860Detail>();
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_860Detail> DIO_860Detail { get; set; }
    }
}
