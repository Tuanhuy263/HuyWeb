namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_SOHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_SOHeader()
        {
            DIO_ACKSOHeader = new HashSet<DIO_ACKSOHeader>();
            DIO_AllocatedPOSO = new HashSet<DIO_AllocatedPOSO>();
            DIO_CustomerPaymentDetail = new HashSet<DIO_CustomerPaymentDetail>();
            DIO_ERP_SOHeaderAllowanceCharge = new HashSet<DIO_ERP_SOHeaderAllowanceCharge>();
            DIO_MasterEventSO = new HashSet<DIO_MasterEventSO>();
            DIO_OrderChangeAcknowledgmentHeader = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIO_OrderChangeRequestHeader = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_OrderChangeRequestHeader1 = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_OrderStatusReport870Header = new HashSet<DIO_OrderStatusReport870Header>();
            DIO_POSOHeader = new HashSet<DIO_POSOHeader>();
            DIO_PTSASNSO = new HashSet<DIO_PTSASNSO>();
            DIO_SISOHeader = new HashSet<DIO_SISOHeader>();
            DIO_SOCommission = new HashSet<DIO_SOCommission>();
            DIO_SOFreight = new HashSet<DIO_SOFreight>();
            DIO_SOHeaderAllowanceCharge = new HashSet<DIO_SOHeaderAllowanceCharge>();
            DIO_TrackingOrderStatusHeader = new HashSet<DIO_TrackingOrderStatusHeader>();
            DIO_WHOrderHeader = new HashSet<DIO_WHOrderHeader>();
            DIO_WHShippingAdviceHeader = new HashSet<DIO_WHShippingAdviceHeader>();
            DIO_WHStockOut = new HashSet<DIO_WHStockOut>();
            DIO_WorkOrder = new HashSet<DIO_WorkOrder>();
            DIS_ASNSO = new HashSet<DIS_ASNSO>();
            DIS_POHeader = new HashSet<DIS_POHeader>();
            DIS_SaleInvoiceHeader = new HashSet<DIS_SaleInvoiceHeader>();
            DIS_SISO = new HashSet<DIS_SISO>();
            DIS_SODetail = new HashSet<DIS_SODetail>();
            DIS_SOHeader1 = new HashSet<DIS_SOHeader>();
            DIS_SOHeader11 = new HashSet<DIS_SOHeader>();
        }

        [Key]
        public int SONo { get; set; }

        public int HubID { get; set; }

        public int? ChannelID { get; set; }

        [StringLength(20)]
        public string TransactionPurposeCode { get; set; }

        [StringLength(255)]
        public string SONumber { get; set; }

        [StringLength(103)]
        public string SOOriginalNumber { get; set; }

        public int? StoreNo { get; set; }

        public int BaseCurrencyCode { get; set; }

        public int CurrencyCode { get; set; }

        public decimal ExchangeRateAmount { get; set; }

        public DateTime? SODate { get; set; }

        public DateTime? DueDate { get; set; }

        public decimal? DueDateCalculation { get; set; }

        public int? TermBasisDateID { get; set; }

        public int? TermTypeID { get; set; }

        public DateTime? TermDiscDueDate { get; set; }

        public decimal? TermDiscPercent { get; set; }

        public decimal? TermDiscDayDue { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        public decimal? TermDiscAmount { get; set; }

        public int? DepartmentID { get; set; }

        public int? LocationQualifierID { get; set; }

        [StringLength(250)]
        public string PromotionCode { get; set; }

        [StringLength(80)]
        public string GetContactInfo { get; set; }

        public int? FOBPaymentID { get; set; }

        [StringLength(250)]
        public string FOBDescription { get; set; }

        public int? SaleRequirementID { get; set; }

        [StringLength(250)]
        public string OriginalReferenceNo { get; set; }

        [StringLength(250)]
        public string ContractNo { get; set; }

        public string Message { get; set; }

        [StringLength(10)]
        public string SpecialTickerType { get; set; }

        [StringLength(255)]
        public string SpecialOrderType { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        public int? RoutingCodeTypeID { get; set; }

        [StringLength(500)]
        public string Routing { get; set; }

        [StringLength(30)]
        public string InstructionType { get; set; }

        [StringLength(264)]
        public string Instruction { get; set; }

        [StringLength(80)]
        public string ShipToDcNumber { get; set; }

        public DateTime? CancelDate { get; set; }

        public DateTime? EffectRequestShipDate { get; set; }

        [StringLength(30)]
        public string RefID { get; set; }

        [StringLength(3)]
        public string RefIDQual { get; set; }

        public int? SpecialHandlingID { get; set; }

        public int? ShipFromCode { get; set; }

        public int? ShipToCode { get; set; }

        [StringLength(60)]
        public string OrderByContactFirstName { get; set; }

        [StringLength(60)]
        public string OrderByContactLastName { get; set; }

        [StringLength(80)]
        public string OrderByContactPhone { get; set; }

        [StringLength(100)]
        public string OrderByContactEmail { get; set; }

        public int? BillToCode { get; set; }

        public int? ParentSoID { get; set; }

        public int? OriginalParentSoID { get; set; }

        public int? InvoiceTypeID { get; set; }

        public byte? Status { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        public int? TransitTime { get; set; }

        public bool? IsBackOrder { get; set; }

        public byte? AllocationStatus { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? TotalBeforeDiscount { get; set; }

        public decimal? TotalPaymentDue { get; set; }

        public byte? PriceType { get; set; }

        [StringLength(250)]
        public string GuestName { get; set; }

        public string GuestContactInfo { get; set; }

        public decimal? TotalCommissionAmount { get; set; }

        [StringLength(255)]
        public string QBSONo { get; set; }

        public bool? IsFixPercentCommission { get; set; }

        public decimal? RateFixPercentCommision { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsFixTax { get; set; }

        public int? FixTaxID { get; set; }

        public int? ERPTermID { get; set; }

        public DateTime? QBDateModified { get; set; }

        [StringLength(100)]
        public string InternalVendorNumber { get; set; }

        [StringLength(255)]
        public string DepartmentName { get; set; }

        [StringLength(50)]
        public string TransportTypeCode { get; set; }

        [StringLength(250)]
        public string HubSenderID { get; set; }

        public int? QBClassID { get; set; }

        public int? FlagID { get; set; }

        public string WarehouseInstruction { get; set; }

        [StringLength(30)]
        public string DefaultBolNumber { get; set; }

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

        [StringLength(100)]
        public string QBStatus { get; set; }

        [StringLength(250)]
        public string BuyerCode { get; set; }

        [StringLength(250)]
        public string FowarderName { get; set; }

        [StringLength(250)]
        public string SupplierCode { get; set; }

        [StringLength(250)]
        public string ShipToQualifier { get; set; }

        [StringLength(255)]
        public string EDISONumber { get; set; }

        [StringLength(255)]
        public string SpecialHandlingNote { get; set; }

        [StringLength(250)]
        public string ShipFromQualifier { get; set; }

        [StringLength(250)]
        public string BillToQualifier { get; set; }

        [StringLength(100)]
        public string BuyerQualifier { get; set; }

        [StringLength(100)]
        public string BuyerName { get; set; }

        [StringLength(50)]
        public string MerchandiseCode { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [StringLength(20)]
        public string TransactionControlNo { get; set; }

        [StringLength(255)]
        public string SpecialTicketType { get; set; }

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

        public DateTime? ScheduleShipDate { get; set; }

        public long? SOTraceStatus { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        [StringLength(255)]
        public string ShipToFacility { get; set; }

        [StringLength(250)]
        public string TicketCode { get; set; }

        public byte? DropshipStatus { get; set; }

        public int? SOType { get; set; }

        public bool? IsNeedToSyncQB { get; set; }

        [StringLength(255)]
        public string ProductGroupDescription { get; set; }

        [StringLength(255)]
        public string GuestContactPhone { get; set; }

        [StringLength(255)]
        public string SCACCode { get; set; }

        [StringLength(255)]
        public string RoutingName { get; set; }

        public int? TransportationProviderID { get; set; }

        public int? TransportationMethodID { get; set; }

        [StringLength(100)]
        public string AllowanceOrChargeDescription1 { get; set; }

        [StringLength(100)]
        public string AllowanceOrChargeDescription2 { get; set; }

        [StringLength(100)]
        public string AllowanceOrChargeDescription3 { get; set; }

        [StringLength(100)]
        public string AllowanceOrChargeDescription4 { get; set; }

        [StringLength(100)]
        public string AllowanceOrChargeDescription5 { get; set; }

        [StringLength(255)]
        public string InfoContactName { get; set; }

        [StringLength(50)]
        public string InfoContactTel { get; set; }

        [StringLength(250)]
        public string OrderContactFax { get; set; }

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

        [StringLength(250)]
        public string OrderByContactFax { get; set; }

        public bool? CreatePOFromSO { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        public int? DiscType { get; set; }

        public int? TermDiscType { get; set; }

        [StringLength(100)]
        public string QBMasterSONo { get; set; }

        [StringLength(50)]
        public string GSTCode { get; set; }

        [StringLength(255)]
        public string GSTDescription { get; set; }

        [StringLength(50)]
        public string PSTCode { get; set; }

        [StringLength(255)]
        public string PSTDescription { get; set; }

        [StringLength(255)]
        public string STSONumber { get; set; }

        public bool? ExportToSmartTurn { get; set; }

        [StringLength(255)]
        public string CommentTypeCode { get; set; }

        public bool? IsSplitedOrder { get; set; }

        public bool? IsSubOrder { get; set; }

        public int? MasterLocationID { get; set; }

        [StringLength(255)]
        public string CustomerOrderType { get; set; }

        public int? OrderTypeID { get; set; }

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

        public int? CalculateChargeTypeTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax { get; set; }

        [StringLength(255)]
        public string FreightAccountNumber { get; set; }

        public int? BillToTransportation { get; set; }

        [Column(TypeName = "money")]
        public decimal? OriginalDiscountAmount { get; set; }

        [StringLength(255)]
        public string TrailingStatus { get; set; }

        [StringLength(255)]
        public string LeadingStatus { get; set; }

        public int? FreightBillToID { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPOWeight { get; set; }

        public int? NumberOfCartons { get; set; }

        [StringLength(250)]
        public string WarehouseCurrency { get; set; }

        [StringLength(250)]
        public string StorePONumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? WarehouseTax { get; set; }

        [StringLength(100)]
        public string WarehouseID { get; set; }

        [StringLength(250)]
        public string SeasonLinelistCode { get; set; }

        [StringLength(250)]
        public string CustomerGeneralNotes { get; set; }

        [StringLength(250)]
        public string CustomerWarehouseInstructions { get; set; }

        [StringLength(250)]
        public string CustomerShippingInstructions { get; set; }

        public DateTime? MustArriveDate { get; set; }

        [StringLength(255)]
        public string ItemDepartNo { get; set; }

        [StringLength(255)]
        public string ItemDepartName { get; set; }

        public int? OwnerID { get; set; }

        public bool? IsDeletedByUser { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmountHeader { get; set; }

        public bool? HasDiscountAmountHeader { get; set; }

        [StringLength(255)]
        public string QBIDOfDiscountAmountHeader { get; set; }

        public int? AllocatedStatus { get; set; }

        [StringLength(255)]
        public string QBOnlineID { get; set; }

        public int? BlanketPOContractNo { get; set; }

        [StringLength(250)]
        public string ShipVia { get; set; }

        [StringLength(250)]
        public string RoyaltyCode { get; set; }

        [StringLength(250)]
        public string RoyaltyRate { get; set; }

        [StringLength(100)]
        public string VendorOrderNo { get; set; }

        [StringLength(100)]
        public string Region { get; set; }

        public DateTime? ActualShipDate { get; set; }

        [StringLength(100)]
        public string BKQBSONo { get; set; }

        [StringLength(250)]
        public string ArtCode { get; set; }

        [StringLength(4000)]
        public string FutureUse7 { get; set; }

        [StringLength(4000)]
        public string FutureUse90 { get; set; }

        [StringLength(4000)]
        public string FutureUse91 { get; set; }

        [StringLength(4000)]
        public string FutureUse92 { get; set; }

        [StringLength(4000)]
        public string FutureUse93 { get; set; }

        [StringLength(4000)]
        public string FutureUse94 { get; set; }

        [StringLength(4000)]
        public string FutureUse95 { get; set; }

        [StringLength(4000)]
        public string FutureUse96 { get; set; }

        [StringLength(4000)]
        public string FutureUse97 { get; set; }

        [StringLength(4000)]
        public string FutureUse138 { get; set; }

        [StringLength(4000)]
        public string FutureUse159 { get; set; }

        [StringLength(4000)]
        public string FutureUse139 { get; set; }

        [StringLength(4000)]
        public string FutureUse140 { get; set; }

        [StringLength(4000)]
        public string FutureUse141 { get; set; }

        [StringLength(4000)]
        public string FutureUse142 { get; set; }

        [StringLength(4000)]
        public string FutureUse161 { get; set; }

        [StringLength(4000)]
        public string FutureUse162 { get; set; }

        [StringLength(4000)]
        public string FutureUse163 { get; set; }

        [StringLength(4000)]
        public string FutureUse184 { get; set; }

        [StringLength(4000)]
        public string FutureUse189 { get; set; }

        public bool? IsCreatedRA { get; set; }

        public int? StyleTotal { get; set; }

        public int? BuyPlanStatusHeader { get; set; }

        public int? SKU_AllocationStatus { get; set; }

        [StringLength(1000)]
        public string CancelNote { get; set; }

        public DateTime? MustShipDate { get; set; }

        [StringLength(50)]
        public string CustomField_String50_1 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_2 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_3 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_4 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_5 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_6 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_7 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_8 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_9 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_10 { get; set; }

        public bool? CustomField_Bool_1 { get; set; }

        public bool? CustomField_Bool_2 { get; set; }

        public bool? CustomField_Bool_3 { get; set; }

        public bool? CustomField_Bool_4 { get; set; }

        public bool? CustomField_Bool_5 { get; set; }

        public bool? CustomField_Bool_6 { get; set; }

        public bool? CustomField_Bool_7 { get; set; }

        public bool? CustomField_Bool_8 { get; set; }

        public bool? CustomField_Bool_9 { get; set; }

        public bool? CustomField_Bool_10 { get; set; }

        public DateTime? CustomField_DateTime_1 { get; set; }

        public DateTime? CustomField_DateTime_2 { get; set; }

        public DateTime? CustomField_DateTime_3 { get; set; }

        public DateTime? CustomField_DateTime_4 { get; set; }

        public DateTime? CustomField_DateTime_5 { get; set; }

        public DateTime? CustomField_DateTime_6 { get; set; }

        public DateTime? CustomField_DateTime_7 { get; set; }

        public DateTime? CustomField_DateTime_8 { get; set; }

        public DateTime? CustomField_DateTime_9 { get; set; }

        public DateTime? CustomField_DateTime_10 { get; set; }

        public int? CustomField_Int_1 { get; set; }

        public int? CustomField_Int_2 { get; set; }

        public int? CustomField_Int_3 { get; set; }

        public int? CustomField_Int_4 { get; set; }

        public int? CustomField_Int_5 { get; set; }

        public int? CustomField_Int_6 { get; set; }

        public int? CustomField_Int_7 { get; set; }

        public int? CustomField_Int_8 { get; set; }

        public int? CustomField_Int_9 { get; set; }

        public int? CustomField_Int_10 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_1 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_2 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_3 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_4 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_5 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_6 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_7 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_8 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_9 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_10 { get; set; }

        public long? CustomField_Long_1 { get; set; }

        public long? CustomField_Long_2 { get; set; }

        public long? CustomField_Long_3 { get; set; }

        public long? CustomField_Long_4 { get; set; }

        public long? CustomField_Long_5 { get; set; }

        public long? CustomField_Long_6 { get; set; }

        public long? CustomField_Long_7 { get; set; }

        public long? CustomField_Long_8 { get; set; }

        public long? CustomField_Long_9 { get; set; }

        public long? CustomField_Long_10 { get; set; }

        [StringLength(250)]
        public string ServiceCode { get; set; }

        [StringLength(250)]
        public string ServiceName { get; set; }

        public string MessageForReport { get; set; }

        public int? TypeOfServiceID { get; set; }

        public byte? ECommerce { get; set; }

        public int? RequireSendASN { get; set; }

        public bool? IsReplacementOrder { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPaymentAmount { get; set; }

        [StringLength(500)]
        public string UPS_Status_Type_Description { get; set; }

        public byte? UPS_Status_Type { get; set; }

        public byte? UPS_Status_Type_Code { get; set; }

        [StringLength(200)]
        public string ShipmentIDByCarrier { get; set; }

        public int? ItemBaseID { get; set; }

        public string UPSErrorMessage { get; set; }

        public byte? TrackingStatus { get; set; }

        public int? SOOriginalReplacement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSOHeader> DIO_ACKSOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AllocatedPOSO> DIO_AllocatedPOSO { get; set; }

        public virtual DIO_BillToTransportation DIO_BillToTransportation { get; set; }

        public virtual DIO_BlanketSOHeader DIO_BlanketSOHeader { get; set; }

        public virtual DIO_Channel DIO_Channel { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIO_Currency DIO_Currency1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerPaymentDetail> DIO_CustomerPaymentDetail { get; set; }

        public virtual DIO_Department DIO_Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ERP_SOHeaderAllowanceCharge> DIO_ERP_SOHeaderAllowanceCharge { get; set; }

        public virtual DIO_ERP_Term DIO_ERP_Term { get; set; }

        public virtual DIO_Flag DIO_Flag { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        public virtual DIO_InvoiceType DIO_InvoiceType { get; set; }

        public virtual DIO_LocationQualifier DIO_LocationQualifier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterEventSO> DIO_MasterEventSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderStatusReport870Header> DIO_OrderStatusReport870Header { get; set; }

        public virtual DIO_OrderType DIO_OrderType { get; set; }

        public virtual DIO_Owner DIO_Owner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POSOHeader> DIO_POSOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSASNSO> DIO_PTSASNSO { get; set; }

        public virtual DIO_QBClass DIO_QBClass { get; set; }

        public virtual DIO_RoutingCodeType DIO_RoutingCodeType { get; set; }

        public virtual DIO_SaleRequirement DIO_SaleRequirement { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SISOHeader> DIO_SISOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOCommission> DIO_SOCommission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOFreight> DIO_SOFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOHeaderAllowanceCharge> DIO_SOHeaderAllowanceCharge { get; set; }

        public virtual DIO_SpecialHandling DIO_SpecialHandling { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIO_TermBasisDate DIO_TermBasisDate { get; set; }

        public virtual DIO_TermsType DIO_TermsType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingOrderStatusHeader> DIO_TrackingOrderStatusHeader { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIO_TypeOfService DIO_TypeOfService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderHeader> DIO_WHOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOut> DIO_WHStockOut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrder> DIO_WorkOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNSO> DIS_ASNSO { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SISO> DIS_SISO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SODetail> DIS_SODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader1 { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader11 { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader3 { get; set; }
    }
}
