namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_Hub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_Hub()
        {
            DIO_ACKCompareInfors = new HashSet<DIO_ACKCompareInfors>();
            DIO_ACKSOHeader = new HashSet<DIO_ACKSOHeader>();
            DIO_ASNLabelTemplate = new HashSet<DIO_ASNLabelTemplate>();
            DIO_AssignCustomer = new HashSet<DIO_AssignCustomer>();
            DIO_AutoReport = new HashSet<DIO_AutoReport>();
            DIO_BlanketPOHeader = new HashSet<DIO_BlanketPOHeader>();
            DIO_BlanketSOHeader = new HashSet<DIO_BlanketSOHeader>();
            DIO_CarrierInfo = new HashSet<DIO_CarrierInfo>();
            DIO_ChangeHubCriteria = new HashSet<DIO_ChangeHubCriteria>();
            DIO_ChangeHubCriteria1 = new HashSet<DIO_ChangeHubCriteria>();
            DIO_CreditDebitMemo = new HashSet<DIO_CreditDebitMemo>();
            DIO_CustomerCrossReference = new HashSet<DIO_CustomerCrossReference>();
            DIO_CustomerCrossReference1 = new HashSet<DIO_CustomerCrossReference>();
            DIO_CustomerMarkForStore = new HashSet<DIO_CustomerMarkForStore>();
            DIO_CustomerPayment = new HashSet<DIO_CustomerPayment>();
            DIO_CustomerRouting = new HashSet<DIO_CustomerRouting>();
            DIO_CustomerStatement = new HashSet<DIO_CustomerStatement>();
            DIO_DefaultShippingInfo = new HashSet<DIO_DefaultShippingInfo>();
            DIO_Department = new HashSet<DIO_Department>();
            DIO_EDIExportTrack = new HashSet<DIO_EDIExportTrack>();
            DIO_EmailTemplate = new HashSet<DIO_EmailTemplate>();
            DIO_ERP_Hub = new HashSet<DIO_ERP_Hub>();
            DIO_FormConfig = new HashSet<DIO_FormConfig>();
            DIO_FTPAccount = new HashSet<DIO_FTPAccount>();
            DIO_HubAllowanceCharge = new HashSet<DIO_HubAllowanceCharge>();
            DIO_HubBatch = new HashSet<DIO_HubBatch>();
            DIO_HubContactInfo = new HashSet<DIO_HubContactInfo>();
            DIO_HubCustomField = new HashSet<DIO_HubCustomField>();
            DIO_HubDefaultValue = new HashSet<DIO_HubDefaultValue>();
            DIO_HubEDIExportMapping = new HashSet<DIO_HubEDIExportMapping>();
            DIO_HubEDIMapping = new HashSet<DIO_HubEDIMapping>();
            DIO_HubFormMapping = new HashSet<DIO_HubFormMapping>();
            DIO_HubFreight = new HashSet<DIO_HubFreight>();
            DIO_HubReport = new HashSet<DIO_HubReport>();
            DIO_HubReportField = new HashSet<DIO_HubReportField>();
            DIO_HubReportField1 = new HashSet<DIO_HubReportField>();
            DIO_HubSaleRep = new HashSet<DIO_HubSaleRep>();
            DIO_HubWarehouseLevel = new HashSet<DIO_HubWarehouseLevel>();
            DIO_InventoryAdviceConfig = new HashSet<DIO_InventoryAdviceConfig>();
            DIO_ItemDateRangePrice = new HashSet<DIO_ItemDateRangePrice>();
            DIO_MasterBOL = new HashSet<DIO_MasterBOL>();
            DIO_ModuleFile = new HashSet<DIO_ModuleFile>();
            DIO_NonEDIImportExportTemplate = new HashSet<DIO_NonEDIImportExportTemplate>();
            DIO_OrderChangeAcknowledgmentHeader = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIO_OrderChangeRequestHeader = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_PickingList = new HashSet<DIO_PickingList>();
            DIO_PrintTemplate = new HashSet<DIO_PrintTemplate>();
            DIO_PrintTemplateHubVendor = new HashSet<DIO_PrintTemplateHubVendor>();
            DIO_ProductCodes = new HashSet<DIO_ProductCodes>();
            DIO_ProjectSales = new HashSet<DIO_ProjectSales>();
            DIO_PTSASN = new HashSet<DIO_PTSASN>();
            DIO_ReportFile = new HashSet<DIO_ReportFile>();
            DIO_RoutingByZipCode = new HashSet<DIO_RoutingByZipCode>();
            DIO_ShippingInfo1 = new HashSet<DIO_ShippingInfo>();
            DIO_ShipTo_QBCustomer_Job = new HashSet<DIO_ShipTo_QBCustomer_Job>();
            DIO_SplitSOCriteria = new HashSet<DIO_SplitSOCriteria>();
            DIO_WarehouseLevel = new HashSet<DIO_WarehouseLevel>();
            DIO_WHShippingAdviceHeader = new HashSet<DIO_WHShippingAdviceHeader>();
            DIO_WHShippingOrderHeader = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WHStockOut = new HashSet<DIO_WHStockOut>();
            DIO_WSTReceiptAdviceHeader = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIO_WSTShipmentAdviceHeader = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIS_ASN = new HashSet<DIS_ASN>();
            DIS_FunctionTypeInfo = new HashSet<DIS_FunctionTypeInfo>();
            DIS_Hub1 = new HashSet<DIS_Hub>();
            DIS_PODetail = new HashSet<DIS_PODetail>();
            DIS_SODetail = new HashSet<DIS_SODetail>();
            DIS_HubItem = new HashSet<DIS_HubItem>();
            DIS_MasterLocation1 = new HashSet<DIS_MasterLocation>();
            DIS_PermissionAssignment = new HashSet<DIS_PermissionAssignment>();
            DIS_POHeader = new HashSet<DIS_POHeader>();
            DIS_SOHeader = new HashSet<DIS_SOHeader>();
        }

        [Key]
        public int HubID { get; set; }

        [Required]
        [StringLength(255)]
        public string HubCode { get; set; }

        public int? CustomerTypeID { get; set; }

        [StringLength(255)]
        public string HubName { get; set; }

        public int? CustomerPostingGroupID { get; set; }

        public int CurrencyCode { get; set; }

        public int? PaymentTermID { get; set; }

        [StringLength(255)]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        public string FaxNumber { get; set; }

        [StringLength(50)]
        public string HUBVENDORID { get; set; }

        [StringLength(50)]
        public string ERPHUBID { get; set; }

        [StringLength(16)]
        public string DEFAULTASN { get; set; }

        [StringLength(30)]
        public string VENDORNO { get; set; }

        [StringLength(16)]
        public string DEFAULTSHIPFROM { get; set; }

        [StringLength(16)]
        public string DEFAULTSHIPTO { get; set; }

        public long? CURRENTCARTONID { get; set; }

        [StringLength(50)]
        public string MANUFACTURERID { get; set; }

        public long? CURRENTGROUPID { get; set; }

        public long? CURRENTIVCID { get; set; }

        public long? CURRENT870ID { get; set; }

        public long? CURRENTASNID { get; set; }

        [StringLength(50)]
        public string ROUTINGREQUESTSEQ { get; set; }

        [StringLength(30)]
        public string INTERNALVENDORNUMBER { get; set; }

        public int? MINSTORE { get; set; }

        public int? MAXSTORE { get; set; }

        public double? REORDERCAL { get; set; }

        public double? TRENDFORECAST { get; set; }

        [StringLength(50)]
        public string ACTIVITYTYPES { get; set; }

        public bool? CHANGEMODEL { get; set; }

        public bool? ISDISREGARDED { get; set; }

        [StringLength(50)]
        public string NAMESHIPFROM { get; set; }

        [StringLength(50)]
        public string ADDRESS1SHIPFROM { get; set; }

        [StringLength(50)]
        public string ADDRESS2SHIPFROM { get; set; }

        [StringLength(10)]
        public string CITYSHIPFROM { get; set; }

        [StringLength(2)]
        public string STATESHIPFROM { get; set; }

        [StringLength(15)]
        public string ZIPCODESHIPFROM { get; set; }

        [StringLength(50)]
        public string NAMESHIPTO { get; set; }

        [StringLength(50)]
        public string ADDRESS1SHIPTO { get; set; }

        [StringLength(50)]
        public string ADDRESS2SHIPTO { get; set; }

        [StringLength(10)]
        public string CITYSHIPTO { get; set; }

        [StringLength(2)]
        public string STATESHIPTO { get; set; }

        [StringLength(15)]
        public string ZIPCODESHIPTO { get; set; }

        public int? CreditID { get; set; }

        public bool? BackOrder { get; set; }

        public string Notes { get; set; }

        public bool? IsOverShip { get; set; }

        public decimal? PercentOverShip { get; set; }

        [StringLength(2)]
        public string RptConfigProductQualifier { get; set; }

        [StringLength(255)]
        public string VendorNumber { get; set; }

        public int? HubClassID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string MainProductCodeQualifiers { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public int? HubShippingInfo { get; set; }

        public DateTime? QBModified { get; set; }

        [Column(TypeName = "money")]
        public decimal? HubBalance { get; set; }

        public int? HubTermID { get; set; }

        public int? ShelfTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditLimit { get; set; }

        public int? UOMWeightID { get; set; }

        public bool? ApplyTermToTransaction { get; set; }

        public int? TermTypeID { get; set; }

        public DateTime? LastSyncDate { get; set; }

        [StringLength(255)]
        public string ShortName { get; set; }

        public int? FOBPaymentID { get; set; }

        [StringLength(100)]
        public string UPSAccountNumber { get; set; }

        public int? BillToTransportation { get; set; }

        [StringLength(255)]
        public string Instructional { get; set; }

        [StringLength(100)]
        public string InternalMemo { get; set; }

        [StringLength(100)]
        public string InternalNotes { get; set; }

        public int? LengthUOM { get; set; }

        [StringLength(100)]
        public string FedexAccountNumber { get; set; }

        public int? FedexBillToTransportation { get; set; }

        public int? DiscountType { get; set; }

        public bool? IsTaxable { get; set; }

        public int? TermDiscountType { get; set; }

        public int? DiscountTypeNumber { get; set; }

        public bool? IsEDI { get; set; }

        public int? OrderTypeID { get; set; }

        public int? CalculateChargeTypeTax { get; set; }

        [StringLength(255)]
        public string ShipToQualifier { get; set; }

        public bool? CheckItemPrice { get; set; }

        public int? MatchSOForASNOption { get; set; }

        public bool? NotRequireSendSI { get; set; }

        [StringLength(255)]
        public string FolderForExportSI { get; set; }

        [StringLength(255)]
        public string FolderForExportSO { get; set; }

        [StringLength(255)]
        public string FolderForExportASN { get; set; }

        public bool? NeedSendConsolidateInvoice { get; set; }

        public int? MasterLocationID { get; set; }

        public bool? GetInvoiceNumberFromASN { get; set; }

        public bool? AssignSOOriginalNumberToInvoiceNumber { get; set; }

        [StringLength(255)]
        public string SmartTurnHubCode { get; set; }

        [StringLength(255)]
        public string SmartTurnHubName { get; set; }

        public bool? SendEDIInvoice { get; set; }

        public bool? SendEDIASN { get; set; }

        public bool? NeedSendEDIInvoice { get; set; }

        public bool? NeedSendEDIASN { get; set; }

        public bool? NeedSend846 { get; set; }

        public bool? NeedSend855 { get; set; }

        public int? AcknowledgmentItemStatusValidationType { get; set; }

        public bool? BaseOnTransPurposeCode { get; set; }

        [StringLength(100)]
        public string TransPurposeCode { get; set; }

        public int? CustomerSizeID { get; set; }

        [StringLength(4000)]
        public string DestinationPathOfExportedFile { get; set; }

        public bool? IsUseExportWithTemplate { get; set; }

        [StringLength(100)]
        public string ERPItemCodeQfr { get; set; }

        public bool? AssignSONumberToInvoiceNumber { get; set; }

        public int? ParentHubID { get; set; }

        public bool? UseMultiPCs { get; set; }

        public bool? ConsolidateASNByShipToCode { get; set; }

        public bool? ShortShip { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(1000)]
        public string AlternateLocation { get; set; }

        public bool? IsNoneEDI { get; set; }

        public bool? NeedSendNoneEDIInvoice { get; set; }

        public bool? NeedSendNoneEDIASN { get; set; }

        public bool? NeedSendNoneEDI850 { get; set; }

        public bool? NeedSend850 { get; set; }

        public bool? SendPOWithZeroQty { get; set; }

        public bool? NeedCreateConsolidateASN { get; set; }

        [StringLength(100)]
        public string EDITradingPartnerNumber { get; set; }

        public bool? SupportMultiPCs { get; set; }

        public bool? CompareWithExtendInventory { get; set; }

        public int? SortUCCLabelOption { get; set; }

        public bool? ConsolidateSOByShipToCode { get; set; }

        public bool? ChargeHub { get; set; }

        [StringLength(100)]
        public string AllowanceChargeCodeHub { get; set; }

        public bool? RequireSameLotNumber { get; set; }

        public int? MinPercentForAllocation { get; set; }

        public bool? PercentForAllocation { get; set; }

        [StringLength(2)]
        public string GS1Prefix { get; set; }

        [StringLength(5)]
        public string LabelerCode { get; set; }

        [StringLength(5)]
        public string GS1LocationNumber { get; set; }

        public bool? GS1LocationIsWithExtension { get; set; }

        [StringLength(100)]
        public string DesOwningParty { get; set; }

        public int? TermBasisDateID { get; set; }

        public bool? SplitSO_1SO1Item { get; set; }

        public int? QBClassID { get; set; }

        public int? QBSOTemplateID { get; set; }

        public int? QBSITemplateID { get; set; }

        public int? QBAccountID { get; set; }

        public bool? GetWeightFromCustomerItem { get; set; }

        [StringLength(500)]
        public string LicenseNo { get; set; }

        public bool? AllowPartialShipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKCompareInfors> DIO_ACKCompareInfors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSOHeader> DIO_ACKSOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ASNLabelTemplate> DIO_ASNLabelTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AssignCustomer> DIO_AssignCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutoReport> DIO_AutoReport { get; set; }

        public virtual DIO_BillToTransportation DIO_BillToTransportation { get; set; }

        public virtual DIO_BillToTransportation DIO_BillToTransportation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPOHeader> DIO_BlanketPOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSOHeader> DIO_BlanketSOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CarrierInfo> DIO_CarrierInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ChangeHubCriteria> DIO_ChangeHubCriteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ChangeHubCriteria> DIO_ChangeHubCriteria1 { get; set; }

        public virtual DIO_Credit DIO_Credit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CreditDebitMemo> DIO_CreditDebitMemo { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIO_CustomerCategories DIO_CustomerCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerCrossReference> DIO_CustomerCrossReference { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerCrossReference> DIO_CustomerCrossReference1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerMarkForStore> DIO_CustomerMarkForStore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerPayment> DIO_CustomerPayment { get; set; }

        public virtual DIO_CustomerPostingGroup DIO_CustomerPostingGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerRouting> DIO_CustomerRouting { get; set; }

        public virtual DIO_CustomerSize DIO_CustomerSize { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerStatement> DIO_CustomerStatement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_DefaultShippingInfo> DIO_DefaultShippingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Department> DIO_Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EDIExportTrack> DIO_EDIExportTrack { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EmailTemplate> DIO_EmailTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ERP_Hub> DIO_ERP_Hub { get; set; }

        public virtual DIO_ERP_Term DIO_ERP_Term { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_FormConfig> DIO_FormConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_FTPAccount> DIO_FTPAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubAllowanceCharge> DIO_HubAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubBatch> DIO_HubBatch { get; set; }

        public virtual DIO_HubClass DIO_HubClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubContactInfo> DIO_HubContactInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubCustomField> DIO_HubCustomField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubDefaultValue> DIO_HubDefaultValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubEDIExportMapping> DIO_HubEDIExportMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubEDIMapping> DIO_HubEDIMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubFormMapping> DIO_HubFormMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubFreight> DIO_HubFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubReport> DIO_HubReport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubReportField> DIO_HubReportField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubReportField> DIO_HubReportField1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubSaleRep> DIO_HubSaleRep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubWarehouseLevel> DIO_HubWarehouseLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryAdviceConfig> DIO_InventoryAdviceConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ItemDateRangePrice> DIO_ItemDateRangePrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterBOL> DIO_MasterBOL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ModuleFile> DIO_ModuleFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_NonEDIImportExportTemplate> DIO_NonEDIImportExportTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader { get; set; }

        public virtual DIO_OrderType DIO_OrderType { get; set; }

        public virtual DIO_PaymentTerm DIO_PaymentTerm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingList> DIO_PickingList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PrintTemplate> DIO_PrintTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PrintTemplateHubVendor> DIO_PrintTemplateHubVendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductCodes> DIO_ProductCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProjectSales> DIO_ProjectSales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSASN> DIO_PTSASN { get; set; }

        public virtual DIO_QBClass DIO_QBClass { get; set; }

        public virtual DIO_QBTemplate DIO_QBTemplate { get; set; }

        public virtual DIO_QBTemplate DIO_QBTemplate1 { get; set; }

        public virtual DIO_QuickBookAccount DIO_QuickBookAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReportFile> DIO_ReportFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RoutingByZipCode> DIO_RoutingByZipCode { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ShippingInfo> DIO_ShippingInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ShipTo_QBCustomer_Job> DIO_ShipTo_QBCustomer_Job { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SplitSOCriteria> DIO_SplitSOCriteria { get; set; }

        public virtual DIO_TermBasisDate DIO_TermBasisDate { get; set; }

        public virtual DIO_TermsType DIO_TermsType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WarehouseLevel> DIO_WarehouseLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOut> DIO_WHStockOut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_FunctionTypeInfo> DIS_FunctionTypeInfo { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Hub> DIS_Hub1 { get; set; }

        public virtual DIS_Hub DIS_Hub2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PODetail> DIS_PODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SODetail> DIS_SODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_HubItem> DIS_HubItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterLocation> DIS_MasterLocation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PermissionAssignment> DIS_PermissionAssignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader { get; set; }
    }
}
