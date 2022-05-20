namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_POHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_POHeader()
        {
            DIO_AllocatedPOSO = new HashSet<DIO_AllocatedPOSO>();
            DIO_PODeposit = new HashSet<DIO_PODeposit>();
            DIO_POFreight = new HashSet<DIO_POFreight>();
            DIO_POHeaderAllowanceCharge = new HashSet<DIO_POHeaderAllowanceCharge>();
            DIO_POPIHeader = new HashSet<DIO_POPIHeader>();
            DIO_POSOHeader = new HashSet<DIO_POSOHeader>();
            DIO_WHRecipientNoticeHeader = new HashSet<DIO_WHRecipientNoticeHeader>();
            DIO_WHStockIn = new HashSet<DIO_WHStockIn>();
            DIO_WSTReceiptAdviceCarton = new HashSet<DIO_WSTReceiptAdviceCarton>();
            DIO_WSTReceiptAdvicePalletPO = new HashSet<DIO_WSTReceiptAdvicePalletPO>();
            DIO_WSTReceiptAdvicePO = new HashSet<DIO_WSTReceiptAdvicePO>();
            DIO_WSTShipmentAdviceCarton = new HashSet<DIO_WSTShipmentAdviceCarton>();
            DIO_WSTShipmentAdvicePalletPO = new HashSet<DIO_WSTShipmentAdvicePalletPO>();
            DIO_WSTShipmentAdvicePO = new HashSet<DIO_WSTShipmentAdvicePO>();
            DIOW_PalletInfo = new HashSet<DIOW_PalletInfo>();
            DIS_ASNPO = new HashSet<DIS_ASNPO>();
            DIS_Carton = new HashSet<DIS_Carton>();
            DIS_PODetail = new HashSet<DIS_PODetail>();
            DIS_PurchaseInvoiceHeader = new HashSet<DIS_PurchaseInvoiceHeader>();
        }

        [Key]
        public int PONo { get; set; }

        public int VendorID { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        public int? StoreNo { get; set; }

        [StringLength(50)]
        public string ReceiveID { get; set; }

        [StringLength(20)]
        public string TransType { get; set; }

        [StringLength(20)]
        public string POTransactionPurposeCode { get; set; }

        [StringLength(10)]
        public string POAcknowledgmentType { get; set; }

        [Required]
        [StringLength(255)]
        public string PONumber { get; set; }

        [StringLength(255)]
        public string POOriginalNumber { get; set; }

        public DateTime PODate { get; set; }

        public int? RoutingCodeTypeID { get; set; }

        [StringLength(255)]
        public string CancelAfter { get; set; }

        [StringLength(500)]
        public string Routing { get; set; }

        public int? ShipFromCode { get; set; }

        public int? ShipToCode { get; set; }

        [StringLength(255)]
        public string ShipToDC { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? ShipTime { get; set; }

        public int? BillToCode { get; set; }

        [StringLength(250)]
        public string InternalVendorNo { get; set; }

        [StringLength(250)]
        public string PromotionCode { get; set; }

        public int? BaseCurrencyCode { get; set; }

        public int CurrencyCode { get; set; }

        public decimal ExchangeRateAmount { get; set; }

        [StringLength(10)]
        public string TermDiscountAmount { get; set; }

        [StringLength(10)]
        public string TicketType { get; set; }

        [StringLength(4000)]
        public string Message { get; set; }

        [StringLength(255)]
        public string ContractNo { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        [StringLength(255)]
        public string PoNote2 { get; set; }

        [StringLength(255)]
        public string OrderByContactFirstName { get; set; }

        [StringLength(255)]
        public string OrderByContactLastName { get; set; }

        [StringLength(15)]
        public string OrderByContactPhone { get; set; }

        [StringLength(255)]
        public string OrderByContactEmail { get; set; }

        [StringLength(255)]
        public string LineItemAcknowledgment { get; set; }

        public DateTime? CancelDate { get; set; }

        public byte? Status { get; set; }

        public short? TraceStatus { get; set; }

        public int? SONo { get; set; }

        public int? TransitTime { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

        [StringLength(30)]
        public string ReleaseNumber { get; set; }

        [StringLength(30)]
        public string OriginalReferenceNumber { get; set; }

        [StringLength(30)]
        public string AppointmentNumber { get; set; }

        public int? DepartmentID { get; set; }

        public int? LocationQualifierID { get; set; }

        public int? FOBPaymentID { get; set; }

        [StringLength(255)]
        public string FOBDescription { get; set; }

        public int? SaleRequirementID { get; set; }

        public int? SpecialHandlingID { get; set; }

        public bool? BackOrder { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? TotalBeforeDiscount { get; set; }

        public decimal? TotalPaymentDue { get; set; }

        public byte? PriceType { get; set; }

        public DateTime? DueDate { get; set; }

        public int? TermBasisDateID { get; set; }

        public int? TermTypeID { get; set; }

        public DateTime? TermDiscDueDate { get; set; }

        public decimal? TermDiscPercent { get; set; }

        public decimal? TermDiscDayDue { get; set; }

        public decimal? DueDateCalculation { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        public decimal? TermDiscAmount { get; set; }

        public string GuestContactInfo { get; set; }

        [StringLength(100)]
        public string GuestName { get; set; }

        public int? InvoiceTypeID { get; set; }

        [StringLength(100)]
        public string QBPONo { get; set; }

        public bool? IsBlindPO { get; set; }

        public int? HubID { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(255)]
        public string AccountNumber { get; set; }

        public bool? IsFixTax { get; set; }

        public int? FixTaxID { get; set; }

        public int? ERPTermID { get; set; }

        public DateTime? QBDateModified { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        [StringLength(50)]
        public string TransportTypeCode { get; set; }

        public int? ShipToID { get; set; }

        public int? QBClassID { get; set; }

        public int? FlagID { get; set; }

        public int? POType { get; set; }

        [StringLength(100)]
        public string QBStatus { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [StringLength(20)]
        public string TransactionControlNo { get; set; }

        [StringLength(255)]
        public string SpecialTicketType { get; set; }

        [StringLength(255)]
        public string SpecialOrderType { get; set; }

        [StringLength(255)]
        public string UserDefined36 { get; set; }

        [StringLength(255)]
        public string BuyerStoreNumber { get; set; }

        [StringLength(255)]
        public string ProNo { get; set; }

        [StringLength(255)]
        public string ForwarderName { get; set; }

        [StringLength(255)]
        public string UserDefined73 { get; set; }

        [StringLength(255)]
        public string UserDefined74 { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        public bool? NeedToUpdateToQB { get; set; }

        public byte? Type { get; set; }

        [StringLength(255)]
        public string ShipToFacility { get; set; }

        [StringLength(255)]
        public string GuestContactPhone { get; set; }

        [StringLength(255)]
        public string ProductGroupDescription { get; set; }

        public int? EDIPOType { get; set; }

        [StringLength(255)]
        public string EDIPONumber { get; set; }

        public long? POTraceStatus { get; set; }

        public int? TransportationProviderID { get; set; }

        public int? TransportationMethodID { get; set; }

        [StringLength(255)]
        public string STPONumber { get; set; }

        public bool? ExportToSmartTurn { get; set; }

        public int? OrderTypeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax { get; set; }

        public bool? MarkAsReceived { get; set; }

        public bool? MarkAsRead { get; set; }

        public int? MasterLocationID { get; set; }

        public int? BlanketPOContractNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDeposit { get; set; }

        public DateTime? SuggestedRoutingDate { get; set; }

        [StringLength(255)]
        public string RoutingNumber { get; set; }

        public DateTime? ETADate { get; set; }

        public DateTime? RoutingDate { get; set; }

        public bool? SendPOWithZeroQty { get; set; }

        [StringLength(400)]
        public string PortOfLoading { get; set; }

        public int? TypeOfService { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AllocatedPOSO> DIO_AllocatedPOSO { get; set; }

        public virtual DIO_BlanketPOHeader DIO_BlanketPOHeader { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIO_Currency DIO_Currency1 { get; set; }

        public virtual DIO_Department DIO_Department { get; set; }

        public virtual DIO_ERP_Term DIO_ERP_Term { get; set; }

        public virtual DIO_Flag DIO_Flag { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        public virtual DIO_InvoiceType DIO_InvoiceType { get; set; }

        public virtual DIO_LocationQualifier DIO_LocationQualifier { get; set; }

        public virtual DIO_OrderType DIO_OrderType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PODeposit> DIO_PODeposit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POFreight> DIO_POFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POHeaderAllowanceCharge> DIO_POHeaderAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POPIHeader> DIO_POPIHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POSOHeader> DIO_POSOHeader { get; set; }

        public virtual DIO_QBClass DIO_QBClass { get; set; }

        public virtual DIO_RoutingCodeType DIO_RoutingCodeType { get; set; }

        public virtual DIO_SaleRequirement DIO_SaleRequirement { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIO_SpecialHandling DIO_SpecialHandling { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIO_TermBasisDate DIO_TermBasisDate { get; set; }

        public virtual DIO_TermsType DIO_TermsType { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIO_TypeOfService DIO_TypeOfService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHRecipientNoticeHeader> DIO_WHRecipientNoticeHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockIn> DIO_WHStockIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceCarton> DIO_WSTReceiptAdviceCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePalletPO> DIO_WSTReceiptAdvicePalletPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePO> DIO_WSTReceiptAdvicePO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceCarton> DIO_WSTShipmentAdviceCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePalletPO> DIO_WSTShipmentAdvicePalletPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePO> DIO_WSTShipmentAdvicePO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIOW_PalletInfo> DIOW_PalletInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNPO> DIS_ASNPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Carton> DIS_Carton { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PODetail> DIS_PODetail { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader { get; set; }
    }
}
