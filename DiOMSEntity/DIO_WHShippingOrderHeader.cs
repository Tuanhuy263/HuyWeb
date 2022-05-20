namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHShippingOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHShippingOrderHeader()
        {
            DIO_WHShippingAdviceHeader = new HashSet<DIO_WHShippingAdviceHeader>();
            DIO_WHShippingOrderDetail = new HashSet<DIO_WHShippingOrderDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHShippingOrderHeaderID { get; set; }

        [StringLength(255)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        [StringLength(50)]
        public string SONumber { get; set; }

        [StringLength(255)]
        public string EDISONumber { get; set; }

        public DateTime? SODate { get; set; }

        public int? Status { get; set; }

        [StringLength(100)]
        public string HubSenderID { get; set; }

        [StringLength(255)]
        public string SCACCode { get; set; }

        [StringLength(100)]
        public string BuyerName { get; set; }

        [StringLength(250)]
        public string BuyerCode { get; set; }

        [StringLength(255)]
        public string LinkSequence { get; set; }

        [StringLength(255)]
        public string MasterReference { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(255)]
        public string ShipToCodeType { get; set; }

        [StringLength(255)]
        public string ShipToFacility { get; set; }

        [StringLength(255)]
        public string RoutingName { get; set; }

        [StringLength(100)]
        public string BuyerQualifier { get; set; }

        [StringLength(50)]
        public string MerchandiseCode { get; set; }

        [StringLength(255)]
        public string ProductGroupDescription { get; set; }

        [StringLength(255)]
        public string GuestContactPhone { get; set; }

        [StringLength(250)]
        public string ShipFromQualifier { get; set; }

        [StringLength(250)]
        public string ShipToQualifier { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        [StringLength(100)]
        public string InternalVendorNumber { get; set; }

        [StringLength(250)]
        public string SupplierCode { get; set; }

        [StringLength(250)]
        public string FowarderName { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        [StringLength(100)]
        public string GuestName { get; set; }

        [StringLength(100)]
        public string GuestContactInfo { get; set; }

        [StringLength(250)]
        public string FOBDescription { get; set; }

        [StringLength(50)]
        public string ContractNo { get; set; }

        [StringLength(20)]
        public string TransactionPurposeCode { get; set; }

        [StringLength(50)]
        public string TransportTypeCode { get; set; }

        public string Message { get; set; }

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

        [StringLength(60)]
        public string OrderByContactFirstName { get; set; }

        [StringLength(60)]
        public string OrderByContactLastName { get; set; }

        [StringLength(80)]
        public string OrderByContactPhone { get; set; }

        [StringLength(100)]
        public string OrderByContactEmail { get; set; }

        [StringLength(255)]
        public string SpecialHandlingNote { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        public int? HubID { get; set; }

        public int? ShipToCode { get; set; }

        public int? ShipFromCode { get; set; }

        public int? StoreNo { get; set; }

        public int? TransportationProviderID { get; set; }

        public int? TransportationMethodID { get; set; }

        public int? RoutingCodeTypeID { get; set; }

        public int? InvoiceTypeID { get; set; }

        public int? SaleRequirementID { get; set; }

        public int? FOBPaymentID { get; set; }

        public int? LocationQualifierID { get; set; }

        public int? TermTypeID { get; set; }

        public int? TermBasisDateID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string WHShippingOrderNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? DueDateCalculation { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? TermDiscDueDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscDayDue { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal? TermDiscAmount { get; set; }

        public bool? IsFixPercentCommission { get; set; }

        public DateTime? CancelDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? RateFixPercentCommision { get; set; }

        [StringLength(50)]
        public string GSTCode { get; set; }

        [StringLength(255)]
        public string GSTDescription { get; set; }

        [StringLength(50)]
        public string PSTCode { get; set; }

        [StringLength(255)]
        public string PSTDescription { get; set; }

        public byte? PriceType { get; set; }

        [StringLength(103)]
        public string SOOriginalNumber { get; set; }

        public long? WHSOTraceStatus { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        [StringLength(10)]
        public string PromotionCode { get; set; }

        [StringLength(30)]
        public string OriginalReferenceNo { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalShippedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalShipmentWeight { get; set; }

        [StringLength(120)]
        public string TransactionControlNo { get; set; }

        [StringLength(500)]
        public string WarehouseInstruction { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        [StringLength(250)]
        public string BillToQualifier { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public int? FromMasterLocationID { get; set; }

        public int? ToMasterLocationID { get; set; }

        public int? BillToCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderAmount { get; set; }

        public int? ShippingInfoBillTo { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        public virtual DIO_InvoiceType DIO_InvoiceType { get; set; }

        public virtual DIO_LocationQualifier DIO_LocationQualifier { get; set; }

        public virtual DIO_RoutingCodeType DIO_RoutingCodeType { get; set; }

        public virtual DIO_SaleRequirement DIO_SaleRequirement { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo4 { get; set; }

        public virtual DIO_TermBasisDate DIO_TermBasisDate { get; set; }

        public virtual DIO_TermsType DIO_TermsType { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderDetail> DIO_WHShippingOrderDetail { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }
    }
}
