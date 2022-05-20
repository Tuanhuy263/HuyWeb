namespace DiOMSEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DiOMSContext : DbContext
    {
        public DiOMSContext()
            : base("name=DiOMSContext")
        {
        }

        public virtual DbSet<CleaningUpFilterCondition> CleaningUpFilterConditions { get; set; }
        public virtual DbSet<CleaningUpHistory> CleaningUpHistories { get; set; }
        public virtual DbSet<CommandReport> CommandReports { get; set; }
        public virtual DbSet<DICustomerAllocationInfo> DICustomerAllocationInfoes { get; set; }
        public virtual DbSet<DII_ASN> DII_ASN { get; set; }
        public virtual DbSet<DII_ASN_PO> DII_ASN_PO { get; set; }
        public virtual DbSet<DII_Batch> DII_Batch { get; set; }
        public virtual DbSet<DII_INNER_PACK> DII_INNER_PACK { get; set; }
        public virtual DbSet<DII_PACK> DII_PACK { get; set; }
        public virtual DbSet<DII_PACK_DETAIL> DII_PACK_DETAIL { get; set; }
        public virtual DbSet<DII_PALLET_PACK> DII_PALLET_PACK { get; set; }
        public virtual DbSet<DIO_860Detail> DIO_860Detail { get; set; }
        public virtual DbSet<DIO_860Header> DIO_860Header { get; set; }
        public virtual DbSet<DIO_AccountPeriod> DIO_AccountPeriod { get; set; }
        public virtual DbSet<DIO_ACKCompareInfors> DIO_ACKCompareInfors { get; set; }
        public virtual DbSet<DIO_ACKSODetail> DIO_ACKSODetail { get; set; }
        public virtual DbSet<DIO_ACKSOHeader> DIO_ACKSOHeader { get; set; }
        public virtual DbSet<DIO_ACKType> DIO_ACKType { get; set; }
        public virtual DbSet<DIO_ActivityCode> DIO_ActivityCode { get; set; }
        public virtual DbSet<DIO_Address> DIO_Address { get; set; }
        public virtual DbSet<DIO_AdjustmentBatch> DIO_AdjustmentBatch { get; set; }
        public virtual DbSet<DIO_AdjustmentCarton> DIO_AdjustmentCarton { get; set; }
        public virtual DbSet<DIO_AdjustmentDetail> DIO_AdjustmentDetail { get; set; }
        public virtual DbSet<DIO_AdjustmentHeader> DIO_AdjustmentHeader { get; set; }
        public virtual DbSet<DIO_AdjustmentPallet> DIO_AdjustmentPallet { get; set; }
        public virtual DbSet<DIO_AdjustmentSerial> DIO_AdjustmentSerial { get; set; }
        public virtual DbSet<DIO_AlertBox> DIO_AlertBox { get; set; }
        public virtual DbSet<DIO_AlertBoxViewHistory> DIO_AlertBoxViewHistory { get; set; }
        public virtual DbSet<DIO_AllocatedPOSO> DIO_AllocatedPOSO { get; set; }
        public virtual DbSet<DIO_AllocationItem> DIO_AllocationItem { get; set; }
        public virtual DbSet<DIO_AllowanceCharge> DIO_AllowanceCharge { get; set; }
        public virtual DbSet<DIO_AllowanceChargeHandle> DIO_AllowanceChargeHandle { get; set; }
        public virtual DbSet<DIO_AppointmentSecurityLog> DIO_AppointmentSecurityLog { get; set; }
        public virtual DbSet<DIO_ASNBOL> DIO_ASNBOL { get; set; }
        public virtual DbSet<DIO_ASNInvoice> DIO_ASNInvoice { get; set; }
        public virtual DbSet<DIO_ASNInvoiceDetail> DIO_ASNInvoiceDetail { get; set; }
        public virtual DbSet<DIO_ASNLabelTemplate> DIO_ASNLabelTemplate { get; set; }
        public virtual DbSet<DIO_AssignCustomer> DIO_AssignCustomer { get; set; }
        public virtual DbSet<DIO_AssignItem> DIO_AssignItem { get; set; }
        public virtual DbSet<DIO_AssignLocation> DIO_AssignLocation { get; set; }
        public virtual DbSet<DIO_AssignReport> DIO_AssignReport { get; set; }
        public virtual DbSet<DIO_AssignVendor> DIO_AssignVendor { get; set; }
        public virtual DbSet<DIO_AttDocument> DIO_AttDocument { get; set; }
        public virtual DbSet<DIO_AttributeGroup> DIO_AttributeGroup { get; set; }
        public virtual DbSet<DIO_AttributeType> DIO_AttributeType { get; set; }
        public virtual DbSet<DIO_AttributeValue> DIO_AttributeValue { get; set; }
        public virtual DbSet<DIO_AutoFillAddressMapping> DIO_AutoFillAddressMapping { get; set; }
        public virtual DbSet<DIO_AutoFillShippingInfoMapping> DIO_AutoFillShippingInfoMapping { get; set; }
        public virtual DbSet<DIO_AutomationFlow> DIO_AutomationFlow { get; set; }
        public virtual DbSet<DIO_AutomationFlowDetail> DIO_AutomationFlowDetail { get; set; }
        public virtual DbSet<DIO_AutomationFlowKeepTrack> DIO_AutomationFlowKeepTrack { get; set; }
        public virtual DbSet<DIO_AutomationSchedule> DIO_AutomationSchedule { get; set; }
        public virtual DbSet<DIO_AutomationStatusManagement> DIO_AutomationStatusManagement { get; set; }
        public virtual DbSet<DIO_AutoReport> DIO_AutoReport { get; set; }
        public virtual DbSet<DIO_AutoReportEmail> DIO_AutoReportEmail { get; set; }
        public virtual DbSet<DIO_AutoReportParameter> DIO_AutoReportParameter { get; set; }
        public virtual DbSet<DIO_AutoReportTime> DIO_AutoReportTime { get; set; }
        public virtual DbSet<DIO_AverageSalesOfLastYear> DIO_AverageSalesOfLastYear { get; set; }
        public virtual DbSet<DIO_BalanceSheet> DIO_BalanceSheet { get; set; }
        public virtual DbSet<DIO_BankAddress> DIO_BankAddress { get; set; }
        public virtual DbSet<DIO_BankList> DIO_BankList { get; set; }
        public virtual DbSet<DIO_BasisUnitPrice> DIO_BasisUnitPrice { get; set; }
        public virtual DbSet<DIO_Batch> DIO_Batch { get; set; }
        public virtual DbSet<DIO_Batch_ReceivedDate> DIO_Batch_ReceivedDate { get; set; }
        public virtual DbSet<DIO_BatchContainer> DIO_BatchContainer { get; set; }
        public virtual DbSet<DIO_BillOfMaterial> DIO_BillOfMaterial { get; set; }
        public virtual DbSet<DIO_BillOfMaterialDetail> DIO_BillOfMaterialDetail { get; set; }
        public virtual DbSet<DIO_BillToTransportation> DIO_BillToTransportation { get; set; }
        public virtual DbSet<DIO_BlanketPODetail> DIO_BlanketPODetail { get; set; }
        public virtual DbSet<DIO_BlanketPOHeader> DIO_BlanketPOHeader { get; set; }
        public virtual DbSet<DIO_BlanketSODetail> DIO_BlanketSODetail { get; set; }
        public virtual DbSet<DIO_BlanketSOHeader> DIO_BlanketSOHeader { get; set; }
        public virtual DbSet<DIO_BOLCarrierInfo> DIO_BOLCarrierInfo { get; set; }
        public virtual DbSet<DIO_BOLCustomerInfo> DIO_BOLCustomerInfo { get; set; }
        public virtual DbSet<DIO_Brand> DIO_Brand { get; set; }
        public virtual DbSet<DIO_BrokerPayment> DIO_BrokerPayment { get; set; }
        public virtual DbSet<DIO_BrokerPaymentDetail> DIO_BrokerPaymentDetail { get; set; }
        public virtual DbSet<DIO_CancelNote> DIO_CancelNote { get; set; }
        public virtual DbSet<DIO_CarrierAccounts> DIO_CarrierAccounts { get; set; }
        public virtual DbSet<DIO_CarrierInfo> DIO_CarrierInfo { get; set; }
        public virtual DbSet<DIO_CarrierService> DIO_CarrierService { get; set; }
        public virtual DbSet<DIO_CategoryItemPolicy> DIO_CategoryItemPolicy { get; set; }
        public virtual DbSet<DIO_CategoryItems> DIO_CategoryItems { get; set; }
        public virtual DbSet<DIO_ChangeHubCriteria> DIO_ChangeHubCriteria { get; set; }
        public virtual DbSet<DIO_Channel> DIO_Channel { get; set; }
        public virtual DbSet<DIO_City> DIO_City { get; set; }
        public virtual DbSet<DIO_CommonConfig> DIO_CommonConfig { get; set; }
        public virtual DbSet<DIO_CompanyInfo> DIO_CompanyInfo { get; set; }
        public virtual DbSet<DIO_CompanyService> DIO_CompanyService { get; set; }
        public virtual DbSet<DIO_ConnectingService> DIO_ConnectingService { get; set; }
        public virtual DbSet<DIO_CountFTPFile> DIO_CountFTPFile { get; set; }
        public virtual DbSet<DIO_Country> DIO_Country { get; set; }
        public virtual DbSet<DIO_Credit> DIO_Credit { get; set; }
        public virtual DbSet<DIO_CreditDebitDetail> DIO_CreditDebitDetail { get; set; }
        public virtual DbSet<DIO_CreditDebitMemo> DIO_CreditDebitMemo { get; set; }
        public virtual DbSet<DIO_CreditDebitPayment> DIO_CreditDebitPayment { get; set; }
        public virtual DbSet<DIO_Currency> DIO_Currency { get; set; }
        public virtual DbSet<DIO_CustomerCategories> DIO_CustomerCategories { get; set; }
        public virtual DbSet<DIO_CustomerCategoryPrice> DIO_CustomerCategoryPrice { get; set; }
        public virtual DbSet<DIO_CustomerCrossReference> DIO_CustomerCrossReference { get; set; }
        public virtual DbSet<DIO_CustomerMarkForStore> DIO_CustomerMarkForStore { get; set; }
        public virtual DbSet<DIO_CustomerPayment> DIO_CustomerPayment { get; set; }
        public virtual DbSet<DIO_CustomerPaymentDetail> DIO_CustomerPaymentDetail { get; set; }
        public virtual DbSet<DIO_CustomerPostingGroup> DIO_CustomerPostingGroup { get; set; }
        public virtual DbSet<DIO_CustomerRouting> DIO_CustomerRouting { get; set; }
        public virtual DbSet<DIO_CustomerRoutingDetail> DIO_CustomerRoutingDetail { get; set; }
        public virtual DbSet<DIO_CustomerSize> DIO_CustomerSize { get; set; }
        public virtual DbSet<DIO_CustomerStatement> DIO_CustomerStatement { get; set; }
        public virtual DbSet<DIO_CustomField> DIO_CustomField { get; set; }
        public virtual DbSet<DIO_CustomFieldForSmartTurn> DIO_CustomFieldForSmartTurn { get; set; }
        public virtual DbSet<DIO_CustomReport> DIO_CustomReport { get; set; }
        public virtual DbSet<DIO_Customs> DIO_Customs { get; set; }
        public virtual DbSet<DIO_DefaultPackSize> DIO_DefaultPackSize { get; set; }
        public virtual DbSet<DIO_DefaultShippingInfo> DIO_DefaultShippingInfo { get; set; }
        public virtual DbSet<DIO_Department> DIO_Department { get; set; }
        public virtual DbSet<DIO_Discount> DIO_Discount { get; set; }
        public virtual DbSet<DIO_Door> DIO_Door { get; set; }
        public virtual DbSet<DIO_DownloadUploadConfig> DIO_DownloadUploadConfig { get; set; }
        public virtual DbSet<DIO_EDIExportMappingType> DIO_EDIExportMappingType { get; set; }
        public virtual DbSet<DIO_EDIExportTrack> DIO_EDIExportTrack { get; set; }
        public virtual DbSet<DIO_EDIMappingType> DIO_EDIMappingType { get; set; }
        public virtual DbSet<DIO_EmailConfig> DIO_EmailConfig { get; set; }
        public virtual DbSet<DIO_EmailTemplate> DIO_EmailTemplate { get; set; }
        public virtual DbSet<DIO_Enum> DIO_Enum { get; set; }
        public virtual DbSet<DIO_EPCIS_AggregationEvent> DIO_EPCIS_AggregationEvent { get; set; }
        public virtual DbSet<DIO_EPCIS_BizTransaction> DIO_EPCIS_BizTransaction { get; set; }
        public virtual DbSet<DIO_EPCIS_ChildEPCs> DIO_EPCIS_ChildEPCs { get; set; }
        public virtual DbSet<DIO_EPCIS_CompanyMasterData> DIO_EPCIS_CompanyMasterData { get; set; }
        public virtual DbSet<DIO_EPCIS_DestinationList> DIO_EPCIS_DestinationList { get; set; }
        public virtual DbSet<DIO_EPCIS_Element_Attribute> DIO_EPCIS_Element_Attribute { get; set; }
        public virtual DbSet<DIO_EPCIS_Epc> DIO_EPCIS_Epc { get; set; }
        public virtual DbSet<DIO_EPCIS_Header> DIO_EPCIS_Header { get; set; }
        public virtual DbSet<DIO_EPCIS_ObjectEvent> DIO_EPCIS_ObjectEvent { get; set; }
        public virtual DbSet<DIO_EPCIS_SourceList> DIO_EPCIS_SourceList { get; set; }
        public virtual DbSet<DIO_EPCIS_TransactionEvent> DIO_EPCIS_TransactionEvent { get; set; }
        public virtual DbSet<DIO_EPCIS_Vocabulary> DIO_EPCIS_Vocabulary { get; set; }
        public virtual DbSet<DIO_EPCIS_Vocabulary_Element> DIO_EPCIS_Vocabulary_Element { get; set; }
        public virtual DbSet<DIO_ERP_Hub> DIO_ERP_Hub { get; set; }
        public virtual DbSet<DIO_ERP_Item> DIO_ERP_Item { get; set; }
        public virtual DbSet<DIO_ERP_QBSODetailAllowanceCharge> DIO_ERP_QBSODetailAllowanceCharge { get; set; }
        public virtual DbSet<DIO_ERP_SOHeaderAllowanceCharge> DIO_ERP_SOHeaderAllowanceCharge { get; set; }
        public virtual DbSet<DIO_ERP_Store> DIO_ERP_Store { get; set; }
        public virtual DbSet<DIO_ERP_System> DIO_ERP_System { get; set; }
        public virtual DbSet<DIO_ERP_Term> DIO_ERP_Term { get; set; }
        public virtual DbSet<DIO_ERP_TransportationProvider> DIO_ERP_TransportationProvider { get; set; }
        public virtual DbSet<DIO_ERP_Vendor> DIO_ERP_Vendor { get; set; }
        public virtual DbSet<DIO_Expenditure> DIO_Expenditure { get; set; }
        public virtual DbSet<DIO_ExternalInventory> DIO_ExternalInventory { get; set; }
        public virtual DbSet<DIO_ExternalService> DIO_ExternalService { get; set; }
        public virtual DbSet<DIO_ExternalServiceFunction> DIO_ExternalServiceFunction { get; set; }
        public virtual DbSet<DIO_ExternalServiceInput> DIO_ExternalServiceInput { get; set; }
        public virtual DbSet<DIO_ExternalServiceOutput> DIO_ExternalServiceOutput { get; set; }
        public virtual DbSet<DIO_FileTrackingInfo> DIO_FileTrackingInfo { get; set; }
        public virtual DbSet<DIO_Flag> DIO_Flag { get; set; }
        public virtual DbSet<DIO_FOBPayment> DIO_FOBPayment { get; set; }
        public virtual DbSet<DIO_FormConfig> DIO_FormConfig { get; set; }
        public virtual DbSet<DIO_FormMapping> DIO_FormMapping { get; set; }
        public virtual DbSet<DIO_Freight> DIO_Freight { get; set; }
        public virtual DbSet<DIO_FTPAccount> DIO_FTPAccount { get; set; }
        public virtual DbSet<DIO_FTPAccountNonEDI> DIO_FTPAccountNonEDI { get; set; }
        public virtual DbSet<DIO_GenerateAlternateItem> DIO_GenerateAlternateItem { get; set; }
        public virtual DbSet<DIO_Geography> DIO_Geography { get; set; }
        public virtual DbSet<DIO_GLAccount> DIO_GLAccount { get; set; }
        public virtual DbSet<DIO_GLEntry> DIO_GLEntry { get; set; }
        public virtual DbSet<DIO_GroupItem> DIO_GroupItem { get; set; }
        public virtual DbSet<DIO_HeartBeat> DIO_HeartBeat { get; set; }
        public virtual DbSet<DIO_Historical_Info> DIO_Historical_Info { get; set; }
        public virtual DbSet<DIO_HubAllowanceCharge> DIO_HubAllowanceCharge { get; set; }
        public virtual DbSet<DIO_HubBatch> DIO_HubBatch { get; set; }
        public virtual DbSet<DIO_HubClass> DIO_HubClass { get; set; }
        public virtual DbSet<DIO_HubContactInfo> DIO_HubContactInfo { get; set; }
        public virtual DbSet<DIO_HubCustomField> DIO_HubCustomField { get; set; }
        public virtual DbSet<DIO_HubDefaultValue> DIO_HubDefaultValue { get; set; }
        public virtual DbSet<DIO_HubEDIExportMapping> DIO_HubEDIExportMapping { get; set; }
        public virtual DbSet<DIO_HubEDIMapping> DIO_HubEDIMapping { get; set; }
        public virtual DbSet<DIO_HubFormMapping> DIO_HubFormMapping { get; set; }
        public virtual DbSet<DIO_HubFreight> DIO_HubFreight { get; set; }
        public virtual DbSet<DIO_HubItemAllowanceCharge> DIO_HubItemAllowanceCharge { get; set; }
        public virtual DbSet<DIO_HubItemSaleRep> DIO_HubItemSaleRep { get; set; }
        public virtual DbSet<DIO_HubItemStore> DIO_HubItemStore { get; set; }
        public virtual DbSet<DIO_HubReport> DIO_HubReport { get; set; }
        public virtual DbSet<DIO_HubReportField> DIO_HubReportField { get; set; }
        public virtual DbSet<DIO_HubSaleRep> DIO_HubSaleRep { get; set; }
        public virtual DbSet<DIO_HubWarehouseLevel> DIO_HubWarehouseLevel { get; set; }
        public virtual DbSet<DIO_ImportFileInfo> DIO_ImportFileInfo { get; set; }
        public virtual DbSet<DIO_ImportJournalLine> DIO_ImportJournalLine { get; set; }
        public virtual DbSet<DIO_InventoryAdviceConfig> DIO_InventoryAdviceConfig { get; set; }
        public virtual DbSet<DIO_InventoryAdviceDetail> DIO_InventoryAdviceDetail { get; set; }
        public virtual DbSet<DIO_InventoryAdviceHeader> DIO_InventoryAdviceHeader { get; set; }
        public virtual DbSet<DIO_InventoryAdviceLocation> DIO_InventoryAdviceLocation { get; set; }
        public virtual DbSet<DIO_InventoryCarton> DIO_InventoryCarton { get; set; }
        public virtual DbSet<DIO_InventoryCartonDimension> DIO_InventoryCartonDimension { get; set; }
        public virtual DbSet<DIO_InventoryCartonShippingAdvice> DIO_InventoryCartonShippingAdvice { get; set; }
        public virtual DbSet<DIO_InventoryLineItem> DIO_InventoryLineItem { get; set; }
        public virtual DbSet<DIO_InventoryLineItemShippingAdvice> DIO_InventoryLineItemShippingAdvice { get; set; }
        public virtual DbSet<DIO_InventoryLineItemShippingAdviceBatch> DIO_InventoryLineItemShippingAdviceBatch { get; set; }
        public virtual DbSet<DIO_InventoryLineItemShippingAdviceSerial> DIO_InventoryLineItemShippingAdviceSerial { get; set; }
        public virtual DbSet<DIO_InventoryPallet> DIO_InventoryPallet { get; set; }
        public virtual DbSet<DIO_InventoryPalletDimension> DIO_InventoryPalletDimension { get; set; }
        public virtual DbSet<DIO_InventoryPalletShippingAdvice> DIO_InventoryPalletShippingAdvice { get; set; }
        public virtual DbSet<DIO_InventoryReason> DIO_InventoryReason { get; set; }
        public virtual DbSet<DIO_InventoryRepackCarton> DIO_InventoryRepackCarton { get; set; }
        public virtual DbSet<DIO_InventoryStatus> DIO_InventoryStatus { get; set; }
        public virtual DbSet<DIO_InventoryValuationAudit> DIO_InventoryValuationAudit { get; set; }
        public virtual DbSet<DIO_InvoicePOFreight> DIO_InvoicePOFreight { get; set; }
        public virtual DbSet<DIO_InvoiceSOFreight> DIO_InvoiceSOFreight { get; set; }
        public virtual DbSet<DIO_InvoiceType> DIO_InvoiceType { get; set; }
        public virtual DbSet<DIO_ItemCustomField> DIO_ItemCustomField { get; set; }
        public virtual DbSet<DIO_ItemDateRangePrice> DIO_ItemDateRangePrice { get; set; }
        public virtual DbSet<DIO_ItemQuantityPrice> DIO_ItemQuantityPrice { get; set; }
        public virtual DbSet<DIO_ItemShippingAdvice> DIO_ItemShippingAdvice { get; set; }
        public virtual DbSet<DIO_IVABatch> DIO_IVABatch { get; set; }
        public virtual DbSet<DIO_KitDetail> DIO_KitDetail { get; set; }
        public virtual DbSet<DIO_LandedCostHeader> DIO_LandedCostHeader { get; set; }
        public virtual DbSet<DIO_LandedCostLineItem> DIO_LandedCostLineItem { get; set; }
        public virtual DbSet<DIO_LengthWidthUOM> DIO_LengthWidthUOM { get; set; }
        public virtual DbSet<DIO_LineItemBatch> DIO_LineItemBatch { get; set; }
        public virtual DbSet<DIO_LineItemDetailBatch> DIO_LineItemDetailBatch { get; set; }
        public virtual DbSet<DIO_LineItemSerial> DIO_LineItemSerial { get; set; }
        public virtual DbSet<DIO_LineItemStatus> DIO_LineItemStatus { get; set; }
        public virtual DbSet<DIO_LocationManagement> DIO_LocationManagement { get; set; }
        public virtual DbSet<DIO_LocationManagement_ReceivedDate> DIO_LocationManagement_ReceivedDate { get; set; }
        public virtual DbSet<DIO_LocationManagementDetail> DIO_LocationManagementDetail { get; set; }
        public virtual DbSet<DIO_LocationManagementDetailBatch> DIO_LocationManagementDetailBatch { get; set; }
        public virtual DbSet<DIO_LocationQualifier> DIO_LocationQualifier { get; set; }
        public virtual DbSet<DIO_LocationTransaction> DIO_LocationTransaction { get; set; }
        public virtual DbSet<DIO_LockFeatureTypeName> DIO_LockFeatureTypeName { get; set; }
        public virtual DbSet<DIO_LockTable> DIO_LockTable { get; set; }
        public virtual DbSet<DIO_LoginUser> DIO_LoginUser { get; set; }
        public virtual DbSet<DIO_MachineInfo> DIO_MachineInfo { get; set; }
        public virtual DbSet<DIO_MarkForStore> DIO_MarkForStore { get; set; }
        public virtual DbSet<DIO_MasterBOL> DIO_MasterBOL { get; set; }
        public virtual DbSet<DIO_MasterDataTemplate> DIO_MasterDataTemplate { get; set; }
        public virtual DbSet<DIO_MasterEvent> DIO_MasterEvent { get; set; }
        public virtual DbSet<DIO_MasterEventLineItem> DIO_MasterEventLineItem { get; set; }
        public virtual DbSet<DIO_MasterEventSO> DIO_MasterEventSO { get; set; }
        public virtual DbSet<DIO_MasterItemFCL> DIO_MasterItemFCL { get; set; }
        public virtual DbSet<DIO_MasterKit> DIO_MasterKit { get; set; }
        public virtual DbSet<DIO_ModelStock> DIO_ModelStock { get; set; }
        public virtual DbSet<DIO_Module> DIO_Module { get; set; }
        public virtual DbSet<DIO_ModuleFile> DIO_ModuleFile { get; set; }
        public virtual DbSet<DIO_ModuleFileBatch> DIO_ModuleFileBatch { get; set; }
        public virtual DbSet<DIO_MovingAverageQty> DIO_MovingAverageQty { get; set; }
        public virtual DbSet<DIO_nBatch> DIO_nBatch { get; set; }
        public virtual DbSet<DIO_nBatchItem> DIO_nBatchItem { get; set; }
        public virtual DbSet<DIO_nBOL> DIO_nBOL { get; set; }
        public virtual DbSet<DIO_nCarton> DIO_nCarton { get; set; }
        public virtual DbSet<DIO_nCustomerSO> DIO_nCustomerSO { get; set; }
        public virtual DbSet<DIO_nInventoryLineItemBatch> DIO_nInventoryLineItemBatch { get; set; }
        public virtual DbSet<DIO_nItemLocation> DIO_nItemLocation { get; set; }
        public virtual DbSet<DIO_NonEDIExportDisplayField> DIO_NonEDIExportDisplayField { get; set; }
        public virtual DbSet<DIO_NonEDIImportExportTemplate> DIO_NonEDIImportExportTemplate { get; set; }
        public virtual DbSet<DIO_nPallet> DIO_nPallet { get; set; }
        public virtual DbSet<DIO_nPO> DIO_nPO { get; set; }
        public virtual DbSet<DIO_nSerial> DIO_nSerial { get; set; }
        public virtual DbSet<DIO_nSOAllocatedLocation> DIO_nSOAllocatedLocation { get; set; }
        public virtual DbSet<DIO_OpenPack> DIO_OpenPack { get; set; }
        public virtual DbSet<DIO_OpenPackBatch> DIO_OpenPackBatch { get; set; }
        public virtual DbSet<DIO_OpenPackDetail> DIO_OpenPackDetail { get; set; }
        public virtual DbSet<DIO_OpenPackDetailBatch> DIO_OpenPackDetailBatch { get; set; }
        public virtual DbSet<DIO_OpenPackDetailSerial> DIO_OpenPackDetailSerial { get; set; }
        public virtual DbSet<DIO_OpenPackSerial> DIO_OpenPackSerial { get; set; }
        public virtual DbSet<DIO_OrderChangeAcknowledgmentCommission> DIO_OrderChangeAcknowledgmentCommission { get; set; }
        public virtual DbSet<DIO_OrderChangeAcknowledgmentDetail> DIO_OrderChangeAcknowledgmentDetail { get; set; }
        public virtual DbSet<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge> DIO_OrderChangeAcknowledgmentDetailAllowanceCharge { get; set; }
        public virtual DbSet<DIO_OrderChangeAcknowledgmentFreight> DIO_OrderChangeAcknowledgmentFreight { get; set; }
        public virtual DbSet<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader { get; set; }
        public virtual DbSet<DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge> DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge { get; set; }
        public virtual DbSet<DIO_OrderChangeRequestDetail> DIO_OrderChangeRequestDetail { get; set; }
        public virtual DbSet<DIO_OrderChangeRequestDetailAllowanceCharge> DIO_OrderChangeRequestDetailAllowanceCharge { get; set; }
        public virtual DbSet<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader { get; set; }
        public virtual DbSet<DIO_OrderChangeRequestHeaderAllowanceCharge> DIO_OrderChangeRequestHeaderAllowanceCharge { get; set; }
        public virtual DbSet<DIO_OrderStatusReport870Detail> DIO_OrderStatusReport870Detail { get; set; }
        public virtual DbSet<DIO_OrderStatusReport870Header> DIO_OrderStatusReport870Header { get; set; }
        public virtual DbSet<DIO_OrderType> DIO_OrderType { get; set; }
        public virtual DbSet<DIO_Owner> DIO_Owner { get; set; }
        public virtual DbSet<DIO_PackageType> DIO_PackageType { get; set; }
        public virtual DbSet<DIO_PackDetail> DIO_PackDetail { get; set; }
        public virtual DbSet<DIO_PackDetailCarton> DIO_PackDetailCarton { get; set; }
        public virtual DbSet<DIO_PackDetailItem> DIO_PackDetailItem { get; set; }
        public virtual DbSet<DIO_PackDetailItemBatch> DIO_PackDetailItemBatch { get; set; }
        public virtual DbSet<DIO_PackDetailItemSerial> DIO_PackDetailItemSerial { get; set; }
        public virtual DbSet<DIO_PackDetailPallet> DIO_PackDetailPallet { get; set; }
        public virtual DbSet<DIO_PackHeader> DIO_PackHeader { get; set; }
        public virtual DbSet<DIO_PackItem> DIO_PackItem { get; set; }
        public virtual DbSet<DIO_PackItemBatch> DIO_PackItemBatch { get; set; }
        public virtual DbSet<DIO_PackItemDetail> DIO_PackItemDetail { get; set; }
        public virtual DbSet<DIO_PackItemDetailLocation> DIO_PackItemDetailLocation { get; set; }
        public virtual DbSet<DIO_PackItemDetailLocationBatch> DIO_PackItemDetailLocationBatch { get; set; }
        public virtual DbSet<DIO_PackItemDetailLocationSerial> DIO_PackItemDetailLocationSerial { get; set; }
        public virtual DbSet<DIO_PackItemSerial> DIO_PackItemSerial { get; set; }
        public virtual DbSet<DIO_PackUser> DIO_PackUser { get; set; }
        public virtual DbSet<DIO_ParaACKCompare> DIO_ParaACKCompare { get; set; }
        public virtual DbSet<DIO_PassCode> DIO_PassCode { get; set; }
        public virtual DbSet<DIO_PassCodePermission> DIO_PassCodePermission { get; set; }
        public virtual DbSet<DIO_PastSaleInvoice> DIO_PastSaleInvoice { get; set; }
        public virtual DbSet<DIO_PaymentMethod> DIO_PaymentMethod { get; set; }
        public virtual DbSet<DIO_PaymentTerm> DIO_PaymentTerm { get; set; }
        public virtual DbSet<DIO_PickDetailBarcode> DIO_PickDetailBarcode { get; set; }
        public virtual DbSet<DIO_PickDetailCarton> DIO_PickDetailCarton { get; set; }
        public virtual DbSet<DIO_PickDetailItem> DIO_PickDetailItem { get; set; }
        public virtual DbSet<DIO_PickDetailItemBatch> DIO_PickDetailItemBatch { get; set; }
        public virtual DbSet<DIO_PickDetailItemSerial> DIO_PickDetailItemSerial { get; set; }
        public virtual DbSet<DIO_PickDetailPallet> DIO_PickDetailPallet { get; set; }
        public virtual DbSet<DIO_PickHeader> DIO_PickHeader { get; set; }
        public virtual DbSet<DIO_PickingList> DIO_PickingList { get; set; }
        public virtual DbSet<DIO_PickingListDetail> DIO_PickingListDetail { get; set; }
        public virtual DbSet<DIO_PickingListDetailBatch> DIO_PickingListDetailBatch { get; set; }
        public virtual DbSet<DIO_PickingListDetailSerial> DIO_PickingListDetailSerial { get; set; }
        public virtual DbSet<DIO_PickingProgress> DIO_PickingProgress { get; set; }
        public virtual DbSet<DIO_PIDeposit> DIO_PIDeposit { get; set; }
        public virtual DbSet<DIO_PODeposit> DIO_PODeposit { get; set; }
        public virtual DbSet<DIO_PODetailAllowanceCharge> DIO_PODetailAllowanceCharge { get; set; }
        public virtual DbSet<DIO_POFreight> DIO_POFreight { get; set; }
        public virtual DbSet<DIO_POHeaderAllowanceCharge> DIO_POHeaderAllowanceCharge { get; set; }
        public virtual DbSet<DIO_POInvoiceDetailAllowanceCharge> DIO_POInvoiceDetailAllowanceCharge { get; set; }
        public virtual DbSet<DIO_POInvoiceHeaderAllowanceCharge> DIO_POInvoiceHeaderAllowanceCharge { get; set; }
        public virtual DbSet<DIO_POPIDetail> DIO_POPIDetail { get; set; }
        public virtual DbSet<DIO_POPIHeader> DIO_POPIHeader { get; set; }
        public virtual DbSet<DIO_POReceiptConfirmationDetail> DIO_POReceiptConfirmationDetail { get; set; }
        public virtual DbSet<DIO_POReceiptConfirmationHeader> DIO_POReceiptConfirmationHeader { get; set; }
        public virtual DbSet<DIO_POSODetail> DIO_POSODetail { get; set; }
        public virtual DbSet<DIO_POSOHeader> DIO_POSOHeader { get; set; }
        public virtual DbSet<DIO_PriceChangeNote> DIO_PriceChangeNote { get; set; }
        public virtual DbSet<DIO_PrintTemplate> DIO_PrintTemplate { get; set; }
        public virtual DbSet<DIO_PrintTemplateHubVendor> DIO_PrintTemplateHubVendor { get; set; }
        public virtual DbSet<DIO_ProductActivityDetail> DIO_ProductActivityDetail { get; set; }
        public virtual DbSet<DIO_ProductActivityHeader> DIO_ProductActivityHeader { get; set; }
        public virtual DbSet<DIO_ProductActivityLineItem> DIO_ProductActivityLineItem { get; set; }
        public virtual DbSet<DIO_ProductActivityType> DIO_ProductActivityType { get; set; }
        public virtual DbSet<DIO_ProductCodes> DIO_ProductCodes { get; set; }
        public virtual DbSet<DIO_ProductPostingGroup> DIO_ProductPostingGroup { get; set; }
        public virtual DbSet<DIO_ProductTransferResaleDetail> DIO_ProductTransferResaleDetail { get; set; }
        public virtual DbSet<DIO_ProductTransferResaleHeader> DIO_ProductTransferResaleHeader { get; set; }
        public virtual DbSet<DIO_ProductTransferResaleLineItem> DIO_ProductTransferResaleLineItem { get; set; }
        public virtual DbSet<DIO_ProjectSales> DIO_ProjectSales { get; set; }
        public virtual DbSet<DIO_ProviderMethod> DIO_ProviderMethod { get; set; }
        public virtual DbSet<DIO_PTSASN> DIO_PTSASN { get; set; }
        public virtual DbSet<DIO_PTSASNSO> DIO_PTSASNSO { get; set; }
        public virtual DbSet<DIO_PTSASNSOPallet> DIO_PTSASNSOPallet { get; set; }
        public virtual DbSet<DIO_PTSCarton> DIO_PTSCarton { get; set; }
        public virtual DbSet<DIO_PTSLineItem> DIO_PTSLineItem { get; set; }
        public virtual DbSet<DIO_PTSLineItemBatch> DIO_PTSLineItemBatch { get; set; }
        public virtual DbSet<DIO_PTSLineItemSerial> DIO_PTSLineItemSerial { get; set; }
        public virtual DbSet<DIO_PTSPallet> DIO_PTSPallet { get; set; }
        public virtual DbSet<DIO_PurchaseInvoiceBatch> DIO_PurchaseInvoiceBatch { get; set; }
        public virtual DbSet<DIO_PurchaseInvoiceSerial> DIO_PurchaseInvoiceSerial { get; set; }
        public virtual DbSet<DIO_PurchaseTransitTime> DIO_PurchaseTransitTime { get; set; }
        public virtual DbSet<DIO_QBClass> DIO_QBClass { get; set; }
        public virtual DbSet<DIO_QBTaxCode> DIO_QBTaxCode { get; set; }
        public virtual DbSet<DIO_QBTemplate> DIO_QBTemplate { get; set; }
        public virtual DbSet<DIO_QuickBookAccount> DIO_QuickBookAccount { get; set; }
        public virtual DbSet<DIO_QuickBookAllowanceCharge> DIO_QuickBookAllowanceCharge { get; set; }
        public virtual DbSet<DIO_Raw_Option_9> DIO_Raw_Option_9 { get; set; }
        public virtual DbSet<DIO_Raw860> DIO_Raw860 { get; set; }
        public virtual DbSet<DIO_Raw860Detail> DIO_Raw860Detail { get; set; }
        public virtual DbSet<DIO_Raw943Carton> DIO_Raw943Carton { get; set; }
        public virtual DbSet<DIO_Raw943Header> DIO_Raw943Header { get; set; }
        public virtual DbSet<DIO_Raw943LineItem> DIO_Raw943LineItem { get; set; }
        public virtual DbSet<DIO_Raw943Pallet> DIO_Raw943Pallet { get; set; }
        public virtual DbSet<DIO_Raw943PO> DIO_Raw943PO { get; set; }
        public virtual DbSet<DIO_Raw947Header> DIO_Raw947Header { get; set; }
        public virtual DbSet<DIO_Raw947LineItem> DIO_Raw947LineItem { get; set; }
        public virtual DbSet<DIO_Raw997> DIO_Raw997 { get; set; }
        public virtual DbSet<DIO_RawAllowanceChargePIDetail> DIO_RawAllowanceChargePIDetail { get; set; }
        public virtual DbSet<DIO_RawAllowanceChargePIHeader> DIO_RawAllowanceChargePIHeader { get; set; }
        public virtual DbSet<DIO_RawAllowanceChargeSIDetail> DIO_RawAllowanceChargeSIDetail { get; set; }
        public virtual DbSet<DIO_RawAllowanceChargeSIHeader> DIO_RawAllowanceChargeSIHeader { get; set; }
        public virtual DbSet<DIO_RawASN> DIO_RawASN { get; set; }
        public virtual DbSet<DIO_RawASNPO> DIO_RawASNPO { get; set; }
        public virtual DbSet<DIO_RawASNPOPallet> DIO_RawASNPOPallet { get; set; }
        public virtual DbSet<DIO_RawASNSubLineItem> DIO_RawASNSubLineItem { get; set; }
        public virtual DbSet<DIO_RawCarton> DIO_RawCarton { get; set; }
        public virtual DbSet<DIO_RawInventoryAdviceDetail> DIO_RawInventoryAdviceDetail { get; set; }
        public virtual DbSet<DIO_RawInventoryAdviceHeader> DIO_RawInventoryAdviceHeader { get; set; }
        public virtual DbSet<DIO_RawLineItem> DIO_RawLineItem { get; set; }
        public virtual DbSet<DIO_RawOrderChangeAcknowledgmentDetail> DIO_RawOrderChangeAcknowledgmentDetail { get; set; }
        public virtual DbSet<DIO_RawOrderChangeAcknowledgmentHeader> DIO_RawOrderChangeAcknowledgmentHeader { get; set; }
        public virtual DbSet<DIO_RawOrgSOHeader> DIO_RawOrgSOHeader { get; set; }
        public virtual DbSet<DIO_RawPallet> DIO_RawPallet { get; set; }
        public virtual DbSet<DIO_RawPODetail> DIO_RawPODetail { get; set; }
        public virtual DbSet<DIO_RawPOHeader> DIO_RawPOHeader { get; set; }
        public virtual DbSet<DIO_RawPurchaseInvoiceDetail> DIO_RawPurchaseInvoiceDetail { get; set; }
        public virtual DbSet<DIO_RawPurchaseInvoiceHeader> DIO_RawPurchaseInvoiceHeader { get; set; }
        public virtual DbSet<DIO_RawRemittanceAdviceDetail> DIO_RawRemittanceAdviceDetail { get; set; }
        public virtual DbSet<DIO_RawRemittanceAdviceHeader> DIO_RawRemittanceAdviceHeader { get; set; }
        public virtual DbSet<DIO_RawRoutingInstructionDetail> DIO_RawRoutingInstructionDetail { get; set; }
        public virtual DbSet<DIO_RawRoutingInstructionHeader> DIO_RawRoutingInstructionHeader { get; set; }
        public virtual DbSet<DIO_RawSaleInvoiceDetail> DIO_RawSaleInvoiceDetail { get; set; }
        public virtual DbSet<DIO_RawSaleInvoiceHeader> DIO_RawSaleInvoiceHeader { get; set; }
        public virtual DbSet<DIO_RawSalesCatalogHeader> DIO_RawSalesCatalogHeader { get; set; }
        public virtual DbSet<DIO_RawSelling> DIO_RawSelling { get; set; }
        public virtual DbSet<DIO_RawSIDetail> DIO_RawSIDetail { get; set; }
        public virtual DbSet<DIO_RawSIHeader> DIO_RawSIHeader { get; set; }
        public virtual DbSet<DIO_RawSOASN> DIO_RawSOASN { get; set; }
        public virtual DbSet<DIO_RawSOASNSO> DIO_RawSOASNSO { get; set; }
        public virtual DbSet<DIO_RawSOASNSOPallet> DIO_RawSOASNSOPallet { get; set; }
        public virtual DbSet<DIO_RawSODetail> DIO_RawSODetail { get; set; }
        public virtual DbSet<DIO_RawSOHeader> DIO_RawSOHeader { get; set; }
        public virtual DbSet<DIO_RawWHShippingOrderDetail> DIO_RawWHShippingOrderDetail { get; set; }
        public virtual DbSet<DIO_RawWHShippingOrderHeader> DIO_RawWHShippingOrderHeader { get; set; }
        public virtual DbSet<DIO_RawWHStockOutDetail> DIO_RawWHStockOutDetail { get; set; }
        public virtual DbSet<DIO_RawWHStockOutHeader> DIO_RawWHStockOutHeader { get; set; }
        public virtual DbSet<DIO_ReadPOConfirmationDetail> DIO_ReadPOConfirmationDetail { get; set; }
        public virtual DbSet<DIO_ReadPOConfirmationHeader> DIO_ReadPOConfirmationHeader { get; set; }
        public virtual DbSet<DIO_ReasonAdjustment> DIO_ReasonAdjustment { get; set; }
        public virtual DbSet<DIO_ReceivingBatch> DIO_ReceivingBatch { get; set; }
        public virtual DbSet<DIO_ReceivingCarton> DIO_ReceivingCarton { get; set; }
        public virtual DbSet<DIO_ReceivingCartonItem> DIO_ReceivingCartonItem { get; set; }
        public virtual DbSet<DIO_ReceivingCartonItemBatch> DIO_ReceivingCartonItemBatch { get; set; }
        public virtual DbSet<DIO_ReceivingCartonItemSerial> DIO_ReceivingCartonItemSerial { get; set; }
        public virtual DbSet<DIO_ReceivingHeader> DIO_ReceivingHeader { get; set; }
        public virtual DbSet<DIO_ReceivingItem> DIO_ReceivingItem { get; set; }
        public virtual DbSet<DIO_ReceivingPallet> DIO_ReceivingPallet { get; set; }
        public virtual DbSet<DIO_ReceivingSerial> DIO_ReceivingSerial { get; set; }
        public virtual DbSet<DIO_ReceivingUser> DIO_ReceivingUser { get; set; }
        public virtual DbSet<DIO_Region> DIO_Region { get; set; }
        public virtual DbSet<DIO_ReminderReportQuery> DIO_ReminderReportQuery { get; set; }
        public virtual DbSet<DIO_RepackSerial> DIO_RepackSerial { get; set; }
        public virtual DbSet<DIO_RepackSerialDetail> DIO_RepackSerialDetail { get; set; }
        public virtual DbSet<DIO_RepackSerialItem> DIO_RepackSerialItem { get; set; }
        public virtual DbSet<DIO_ReplenishDetail> DIO_ReplenishDetail { get; set; }
        public virtual DbSet<DIO_ReplenishHeader> DIO_ReplenishHeader { get; set; }
        public virtual DbSet<DIO_ReportField> DIO_ReportField { get; set; }
        public virtual DbSet<DIO_ReportFile> DIO_ReportFile { get; set; }
        public virtual DbSet<DIO_ReportName> DIO_ReportName { get; set; }
        public virtual DbSet<DIO_ReportParameter> DIO_ReportParameter { get; set; }
        public virtual DbSet<DIO_RequestReferenceNumber> DIO_RequestReferenceNumber { get; set; }
        public virtual DbSet<DIO_RequestResultDetail> DIO_RequestResultDetail { get; set; }
        public virtual DbSet<DIO_RequestResultHeader> DIO_RequestResultHeader { get; set; }
        public virtual DbSet<DIO_ReserveSerial> DIO_ReserveSerial { get; set; }
        public virtual DbSet<DIO_ReturnReceipt> DIO_ReturnReceipt { get; set; }
        public virtual DbSet<DIO_ReturnReceiptBatch> DIO_ReturnReceiptBatch { get; set; }
        public virtual DbSet<DIO_ReturnReceiptDetail> DIO_ReturnReceiptDetail { get; set; }
        public virtual DbSet<DIO_ReturnReceiptSerial> DIO_ReturnReceiptSerial { get; set; }
        public virtual DbSet<DIO_ReturnShipment> DIO_ReturnShipment { get; set; }
        public virtual DbSet<DIO_ReturnShipmentBatch> DIO_ReturnShipmentBatch { get; set; }
        public virtual DbSet<DIO_ReturnShipmentDetail> DIO_ReturnShipmentDetail { get; set; }
        public virtual DbSet<DIO_ReturnShipmentSerial> DIO_ReturnShipmentSerial { get; set; }
        public virtual DbSet<DIO_RoutingByZipCode> DIO_RoutingByZipCode { get; set; }
        public virtual DbSet<DIO_RoutingCodeType> DIO_RoutingCodeType { get; set; }
        public virtual DbSet<DIO_RoutingRequestDetail> DIO_RoutingRequestDetail { get; set; }
        public virtual DbSet<DIO_RoutingRequestHeader> DIO_RoutingRequestHeader { get; set; }
        public virtual DbSet<DIO_SaleInvoiceBatch> DIO_SaleInvoiceBatch { get; set; }
        public virtual DbSet<DIO_SaleInvoiceSerial> DIO_SaleInvoiceSerial { get; set; }
        public virtual DbSet<DIO_SaleRep> DIO_SaleRep { get; set; }
        public virtual DbSet<DIO_SaleRepSODetail> DIO_SaleRepSODetail { get; set; }
        public virtual DbSet<DIO_SaleRequirement> DIO_SaleRequirement { get; set; }
        public virtual DbSet<DIO_SalesOrderReportInfo> DIO_SalesOrderReportInfo { get; set; }
        public virtual DbSet<DIO_SaleTransitTime> DIO_SaleTransitTime { get; set; }
        public virtual DbSet<DIO_Scale> DIO_Scale { get; set; }
        public virtual DbSet<DIO_ScaleSize> DIO_ScaleSize { get; set; }
        public virtual DbSet<DIO_ScanningConfiguration> DIO_ScanningConfiguration { get; set; }
        public virtual DbSet<DIO_SelectItemOTS_FIFO> DIO_SelectItemOTS_FIFO { get; set; }
        public virtual DbSet<DIO_Serial> DIO_Serial { get; set; }
        public virtual DbSet<DIO_SerialConfiguration> DIO_SerialConfiguration { get; set; }
        public virtual DbSet<DIO_ServerFile> DIO_ServerFile { get; set; }
        public virtual DbSet<DIO_ServiceProviderMethod> DIO_ServiceProviderMethod { get; set; }
        public virtual DbSet<DIO_ShippingAddressType> DIO_ShippingAddressType { get; set; }
        public virtual DbSet<DIO_ShippingInfo> DIO_ShippingInfo { get; set; }
        public virtual DbSet<DIO_ShipTo_QBCustomer_Job> DIO_ShipTo_QBCustomer_Job { get; set; }
        public virtual DbSet<DIO_ShipToQualifier> DIO_ShipToQualifier { get; set; }
        public virtual DbSet<DIO_SISODetail> DIO_SISODetail { get; set; }
        public virtual DbSet<DIO_SISOHeader> DIO_SISOHeader { get; set; }
        public virtual DbSet<DIO_Size> DIO_Size { get; set; }
        public virtual DbSet<DIO_SizeRun> DIO_SizeRun { get; set; }
        public virtual DbSet<DIO_SOCommission> DIO_SOCommission { get; set; }
        public virtual DbSet<DIO_SODetailAllowanceCharge> DIO_SODetailAllowanceCharge { get; set; }
        public virtual DbSet<DIO_SODetailPackage> DIO_SODetailPackage { get; set; }
        public virtual DbSet<DIO_SOFreight> DIO_SOFreight { get; set; }
        public virtual DbSet<DIO_SOHeaderAllowanceCharge> DIO_SOHeaderAllowanceCharge { get; set; }
        public virtual DbSet<DIO_SOInvoiceDetailAllowanceCharge> DIO_SOInvoiceDetailAllowanceCharge { get; set; }
        public virtual DbSet<DIO_SOInvoiceHeaderAllowanceCharge> DIO_SOInvoiceHeaderAllowanceCharge { get; set; }
        public virtual DbSet<DIO_SpecialHandling> DIO_SpecialHandling { get; set; }
        public virtual DbSet<DIO_SplitSOCriteria> DIO_SplitSOCriteria { get; set; }
        public virtual DbSet<DIO_State> DIO_State { get; set; }
        public virtual DbSet<DIO_StatusCode> DIO_StatusCode { get; set; }
        public virtual DbSet<DIO_StockInBatch> DIO_StockInBatch { get; set; }
        public virtual DbSet<DIO_StockInExpenditure> DIO_StockInExpenditure { get; set; }
        public virtual DbSet<DIO_StockInFreight> DIO_StockInFreight { get; set; }
        public virtual DbSet<DIO_StockInSerial> DIO_StockInSerial { get; set; }
        public virtual DbSet<DIO_StockOutBatch> DIO_StockOutBatch { get; set; }
        public virtual DbSet<DIO_StockOutSerial> DIO_StockOutSerial { get; set; }
        public virtual DbSet<DIO_Style> DIO_Style { get; set; }
        public virtual DbSet<DIO_SubLineItem> DIO_SubLineItem { get; set; }
        public virtual DbSet<DIO_SubReport> DIO_SubReport { get; set; }
        public virtual DbSet<DIO_SuggestionPrice> DIO_SuggestionPrice { get; set; }
        public virtual DbSet<DIO_TableImport> DIO_TableImport { get; set; }
        public virtual DbSet<DIO_Tax> DIO_Tax { get; set; }
        public virtual DbSet<DIO_TaxGroup> DIO_TaxGroup { get; set; }
        public virtual DbSet<DIO_TermBasisDate> DIO_TermBasisDate { get; set; }
        public virtual DbSet<DIO_TermsType> DIO_TermsType { get; set; }
        public virtual DbSet<DIO_ThirdPartyLogistic> DIO_ThirdPartyLogistic { get; set; }
        public virtual DbSet<DIO_TotalPastShipQty> DIO_TotalPastShipQty { get; set; }
        public virtual DbSet<DIO_TraceImportFile> DIO_TraceImportFile { get; set; }
        public virtual DbSet<DIO_TrackingInfoDetail> DIO_TrackingInfoDetail { get; set; }
        public virtual DbSet<DIO_TrackingInfoHeader> DIO_TrackingInfoHeader { get; set; }
        public virtual DbSet<DIO_TrackingOrderStatusDetail> DIO_TrackingOrderStatusDetail { get; set; }
        public virtual DbSet<DIO_TrackingOrderStatusHeader> DIO_TrackingOrderStatusHeader { get; set; }
        public virtual DbSet<DIO_TrackingTransactionTypeDetail> DIO_TrackingTransactionTypeDetail { get; set; }
        public virtual DbSet<DIO_TrackingTransactionTypeDetailProperty> DIO_TrackingTransactionTypeDetailProperty { get; set; }
        public virtual DbSet<DIO_TrackingTransactionTypeDetailPropertySample> DIO_TrackingTransactionTypeDetailPropertySample { get; set; }
        public virtual DbSet<DIO_TrackingTransactionTypeHeader> DIO_TrackingTransactionTypeHeader { get; set; }
        public virtual DbSet<DIO_TrackUserDoing> DIO_TrackUserDoing { get; set; }
        public virtual DbSet<DIO_Transaction> DIO_Transaction { get; set; }
        public virtual DbSet<DIO_TransactionDetail> DIO_TransactionDetail { get; set; }
        public virtual DbSet<DIO_TransactionDetailReport> DIO_TransactionDetailReport { get; set; }
        public virtual DbSet<DIO_TransactionSetPurpose> DIO_TransactionSetPurpose { get; set; }
        public virtual DbSet<DIO_TransferBatch> DIO_TransferBatch { get; set; }
        public virtual DbSet<DIO_TransferCarton> DIO_TransferCarton { get; set; }
        public virtual DbSet<DIO_TransferDetail> DIO_TransferDetail { get; set; }
        public virtual DbSet<DIO_TransferDocumentDetail> DIO_TransferDocumentDetail { get; set; }
        public virtual DbSet<DIO_TransferDocumentHeader> DIO_TransferDocumentHeader { get; set; }
        public virtual DbSet<DIO_TransferDocumentLineDetail> DIO_TransferDocumentLineDetail { get; set; }
        public virtual DbSet<DIO_TransferHeader> DIO_TransferHeader { get; set; }
        public virtual DbSet<DIO_TransferPallet> DIO_TransferPallet { get; set; }
        public virtual DbSet<DIO_TransferSerial> DIO_TransferSerial { get; set; }
        public virtual DbSet<DIO_TransportationMethod> DIO_TransportationMethod { get; set; }
        public virtual DbSet<DIO_TransportationProvider> DIO_TransportationProvider { get; set; }
        public virtual DbSet<DIO_TypeOfService> DIO_TypeOfService { get; set; }
        public virtual DbSet<DIO_UOMSet> DIO_UOMSet { get; set; }
        public virtual DbSet<DIO_UPSPackageType> DIO_UPSPackageType { get; set; }
        public virtual DbSet<DIO_UserDataPermission> DIO_UserDataPermission { get; set; }
        public virtual DbSet<DIO_VendorBatch> DIO_VendorBatch { get; set; }
        public virtual DbSet<DIO_VendorContactInfo> DIO_VendorContactInfo { get; set; }
        public virtual DbSet<DIO_VendorEDIExportMapping> DIO_VendorEDIExportMapping { get; set; }
        public virtual DbSet<DIO_VendorEDIMapping> DIO_VendorEDIMapping { get; set; }
        public virtual DbSet<DIO_VendorFreight> DIO_VendorFreight { get; set; }
        public virtual DbSet<DIO_VendorItemMasterItem> DIO_VendorItemMasterItem { get; set; }
        public virtual DbSet<DIO_VendorLedgerEntry> DIO_VendorLedgerEntry { get; set; }
        public virtual DbSet<DIO_VendorMarkForStore> DIO_VendorMarkForStore { get; set; }
        public virtual DbSet<DIO_VendorPaymentDetail> DIO_VendorPaymentDetail { get; set; }
        public virtual DbSet<DIO_VendorPostingGroup> DIO_VendorPostingGroup { get; set; }
        public virtual DbSet<DIO_VendorShippingInfo> DIO_VendorShippingInfo { get; set; }
        public virtual DbSet<DIO_VendorStatement> DIO_VendorStatement { get; set; }
        public virtual DbSet<DIO_WarehouseAllocatedSO> DIO_WarehouseAllocatedSO { get; set; }
        public virtual DbSet<DIO_WarehouseInPool> DIO_WarehouseInPool { get; set; }
        public virtual DbSet<DIO_WarehouseInventoryAdjustment> DIO_WarehouseInventoryAdjustment { get; set; }
        public virtual DbSet<DIO_WarehouseLevel> DIO_WarehouseLevel { get; set; }
        public virtual DbSet<DIO_WarehouseLevelDetail> DIO_WarehouseLevelDetail { get; set; }
        public virtual DbSet<DIO_WarehouseLevelTemplate> DIO_WarehouseLevelTemplate { get; set; }
        public virtual DbSet<DIO_WarehouseReceipt> DIO_WarehouseReceipt { get; set; }
        public virtual DbSet<DIO_WarehouseShipmentReport> DIO_WarehouseShipmentReport { get; set; }
        public virtual DbSet<DIO_WarehouseType> DIO_WarehouseType { get; set; }
        public virtual DbSet<DIO_WeightUOM> DIO_WeightUOM { get; set; }
        public virtual DbSet<DIO_WH947Header> DIO_WH947Header { get; set; }
        public virtual DbSet<DIO_WH947LineItem> DIO_WH947LineItem { get; set; }
        public virtual DbSet<DIO_WHOrderDetail> DIO_WHOrderDetail { get; set; }
        public virtual DbSet<DIO_WHOrderDetailBatch> DIO_WHOrderDetailBatch { get; set; }
        public virtual DbSet<DIO_WHOrderDetailSerial> DIO_WHOrderDetailSerial { get; set; }
        public virtual DbSet<DIO_WHOrderHeader> DIO_WHOrderHeader { get; set; }
        public virtual DbSet<DIO_WHRecipientNoticeDetail> DIO_WHRecipientNoticeDetail { get; set; }
        public virtual DbSet<DIO_WHRecipientNoticeHeader> DIO_WHRecipientNoticeHeader { get; set; }
        public virtual DbSet<DIO_WHShipAdvDRaw> DIO_WHShipAdvDRaw { get; set; }
        public virtual DbSet<DIO_WHShipAdvHRaw> DIO_WHShipAdvHRaw { get; set; }
        public virtual DbSet<DIO_WHShippingAdviceDetail> DIO_WHShippingAdviceDetail { get; set; }
        public virtual DbSet<DIO_WHShippingAdviceDetailBatch> DIO_WHShippingAdviceDetailBatch { get; set; }
        public virtual DbSet<DIO_WHShippingAdviceDetailCarton> DIO_WHShippingAdviceDetailCarton { get; set; }
        public virtual DbSet<DIO_WHShippingAdviceDetailPallet> DIO_WHShippingAdviceDetailPallet { get; set; }
        public virtual DbSet<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader { get; set; }
        public virtual DbSet<DIO_WHShippingOrderDetail> DIO_WHShippingOrderDetail { get; set; }
        public virtual DbSet<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader { get; set; }
        public virtual DbSet<DIO_WHStockIn> DIO_WHStockIn { get; set; }
        public virtual DbSet<DIO_WHStockInDetail> DIO_WHStockInDetail { get; set; }
        public virtual DbSet<DIO_WHStockOut> DIO_WHStockOut { get; set; }
        public virtual DbSet<DIO_WHStockOutDetail> DIO_WHStockOutDetail { get; set; }
        public virtual DbSet<DIO_WHSTRawReceiptAdviceCarton> DIO_WHSTRawReceiptAdviceCarton { get; set; }
        public virtual DbSet<DIO_WHSTRawReceiptAdviceHeader> DIO_WHSTRawReceiptAdviceHeader { get; set; }
        public virtual DbSet<DIO_WHSTRawReceiptAdviceLineItem> DIO_WHSTRawReceiptAdviceLineItem { get; set; }
        public virtual DbSet<DIO_WHSTRawReceiptAdviceLineItemBatch> DIO_WHSTRawReceiptAdviceLineItemBatch { get; set; }
        public virtual DbSet<DIO_WHSTRawReceiptAdviceLineItemSerial> DIO_WHSTRawReceiptAdviceLineItemSerial { get; set; }
        public virtual DbSet<DIO_WHSTRawReceiptAdvicePallet> DIO_WHSTRawReceiptAdvicePallet { get; set; }
        public virtual DbSet<DIO_WorkOrder> DIO_WorkOrder { get; set; }
        public virtual DbSet<DIO_WorkOrderDetails> DIO_WorkOrderDetails { get; set; }
        public virtual DbSet<DIO_WorkOrderDetails_Location> DIO_WorkOrderDetails_Location { get; set; }
        public virtual DbSet<DIO_WorkOrderInBatch> DIO_WorkOrderInBatch { get; set; }
        public virtual DbSet<DIO_WorkOrderInSerial> DIO_WorkOrderInSerial { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdviceCarton> DIO_WSTReceiptAdviceCarton { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdviceLineItem> DIO_WSTReceiptAdviceLineItem { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdviceLineItemBatch> DIO_WSTReceiptAdviceLineItemBatch { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdviceLineItemDetail> DIO_WSTReceiptAdviceLineItemDetail { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdviceLineItemSerial> DIO_WSTReceiptAdviceLineItemSerial { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdvicePallet> DIO_WSTReceiptAdvicePallet { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdvicePalletPO> DIO_WSTReceiptAdvicePalletPO { get; set; }
        public virtual DbSet<DIO_WSTReceiptAdvicePO> DIO_WSTReceiptAdvicePO { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdviceCarton> DIO_WSTShipmentAdviceCarton { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdviceLineItem> DIO_WSTShipmentAdviceLineItem { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdviceLineItemBatch> DIO_WSTShipmentAdviceLineItemBatch { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdviceLineItemDetail> DIO_WSTShipmentAdviceLineItemDetail { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdviceLineItemSerial> DIO_WSTShipmentAdviceLineItemSerial { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdvicePallet> DIO_WSTShipmentAdvicePallet { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdvicePalletPO> DIO_WSTShipmentAdvicePalletPO { get; set; }
        public virtual DbSet<DIO_WSTShipmentAdvicePO> DIO_WSTShipmentAdvicePO { get; set; }
        public virtual DbSet<DIO_XPObjectWeakRelationShip> DIO_XPObjectWeakRelationShip { get; set; }
        public virtual DbSet<DIOW_LocationItemPars> DIOW_LocationItemPars { get; set; }
        public virtual DbSet<DIOW_PalletInfo> DIOW_PalletInfo { get; set; }
        public virtual DbSet<DIS_Action> DIS_Action { get; set; }
        public virtual DbSet<DIS_ActionType> DIS_ActionType { get; set; }
        public virtual DbSet<DIS_ActionTypeAttribute> DIS_ActionTypeAttribute { get; set; }
        public virtual DbSet<DIS_ActionTypeParameter> DIS_ActionTypeParameter { get; set; }
        public virtual DbSet<DIS_Application> DIS_Application { get; set; }
        public virtual DbSet<DIS_ASN> DIS_ASN { get; set; }
        public virtual DbSet<DIS_ASNPO> DIS_ASNPO { get; set; }
        public virtual DbSet<DIS_ASNPOPallet> DIS_ASNPOPallet { get; set; }
        public virtual DbSet<DIS_ASNSO> DIS_ASNSO { get; set; }
        public virtual DbSet<DIS_ASNSOPallet> DIS_ASNSOPallet { get; set; }
        public virtual DbSet<DIS_Assembly> DIS_Assembly { get; set; }
        public virtual DbSet<DIS_BarGroup> DIS_BarGroup { get; set; }
        public virtual DbSet<DIS_Carton> DIS_Carton { get; set; }
        public virtual DbSet<DIS_CartonTransaction> DIS_CartonTransaction { get; set; }
        public virtual DbSet<DIS_CurrentUser> DIS_CurrentUser { get; set; }
        public virtual DbSet<DIS_Event> DIS_Event { get; set; }
        public virtual DbSet<DIS_EventActionAttribute> DIS_EventActionAttribute { get; set; }
        public virtual DbSet<DIS_EventActionAttributeUser> DIS_EventActionAttributeUser { get; set; }
        public virtual DbSet<DIS_EventExpression> DIS_EventExpression { get; set; }
        public virtual DbSet<DIS_EventExpressionAction> DIS_EventExpressionAction { get; set; }
        public virtual DbSet<DIS_EventType> DIS_EventType { get; set; }
        public virtual DbSet<DIS_Expression> DIS_Expression { get; set; }
        public virtual DbSet<DIS_Function> DIS_Function { get; set; }
        public virtual DbSet<DIS_FunctionTypeInfo> DIS_FunctionTypeInfo { get; set; }
        public virtual DbSet<DIS_Hub> DIS_Hub { get; set; }
        public virtual DbSet<DIS_HubItem> DIS_HubItem { get; set; }
        public virtual DbSet<DIS_LineItem> DIS_LineItem { get; set; }
        public virtual DbSet<DIS_LineItemDetail> DIS_LineItemDetail { get; set; }
        public virtual DbSet<DIS_MasterItem> DIS_MasterItem { get; set; }
        public virtual DbSet<DIS_MasterLocation> DIS_MasterLocation { get; set; }
        public virtual DbSet<DIS_Menu> DIS_Menu { get; set; }
        public virtual DbSet<DIS_MultiUser> DIS_MultiUser { get; set; }
        public virtual DbSet<DIS_Pallet> DIS_Pallet { get; set; }
        public virtual DbSet<DIS_PalletTransaction> DIS_PalletTransaction { get; set; }
        public virtual DbSet<DIS_PermissionAssignment> DIS_PermissionAssignment { get; set; }
        public virtual DbSet<DIS_PODetail> DIS_PODetail { get; set; }
        public virtual DbSet<DIS_POHeader> DIS_POHeader { get; set; }
        public virtual DbSet<DIS_PurchaseInvoiceDetail> DIS_PurchaseInvoiceDetail { get; set; }
        public virtual DbSet<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader { get; set; }
        public virtual DbSet<DIS_Role> DIS_Role { get; set; }
        public virtual DbSet<DIS_SaleInvoiceDetail> DIS_SaleInvoiceDetail { get; set; }
        public virtual DbSet<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader { get; set; }
        public virtual DbSet<DIS_SISO> DIS_SISO { get; set; }
        public virtual DbSet<DIS_SOAllocatedLocation> DIS_SOAllocatedLocation { get; set; }
        public virtual DbSet<DIS_SODetail> DIS_SODetail { get; set; }
        public virtual DbSet<DIS_SOHeader> DIS_SOHeader { get; set; }
        public virtual DbSet<DIS_TemplateParameter> DIS_TemplateParameter { get; set; }
        public virtual DbSet<DIS_TypeInfo> DIS_TypeInfo { get; set; }
        public virtual DbSet<DIS_UnitOfMeasure> DIS_UnitOfMeasure { get; set; }
        public virtual DbSet<DIS_UOMConversion> DIS_UOMConversion { get; set; }
        public virtual DbSet<DIS_User> DIS_User { get; set; }
        public virtual DbSet<DIS_UserRole> DIS_UserRole { get; set; }
        public virtual DbSet<DIS_Vendor> DIS_Vendor { get; set; }
        public virtual DbSet<DIS_VendorItem> DIS_VendorItem { get; set; }
        public virtual DbSet<DISOAllocationInfo> DISOAllocationInfoes { get; set; }
        public virtual DbSet<DISODAllocationInfo> DISODAllocationInfoes { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<Harmonize> Harmonizes { get; set; }
        public virtual DbSet<HazardClass> HazardClasses { get; set; }
        public virtual DbSet<InboundOutboundASNHeader> InboundOutboundASNHeaders { get; set; }
        public virtual DbSet<ItemDiscontinueDateType> ItemDiscontinueDateTypes { get; set; }
        public virtual DbSet<ItemInfo> ItemInfoes { get; set; }
        public virtual DbSet<LocationInfo> LocationInfoes { get; set; }
        public virtual DbSet<NMFC> NMFCs { get; set; }
        public virtual DbSet<PackingSpecification> PackingSpecifications { get; set; }
        public virtual DbSet<PODetailInfo> PODetailInfoes { get; set; }
        public virtual DbSet<SEQ_Group> SEQ_Group { get; set; }
        public virtual DbSet<SEQ_NO> SEQ_NO { get; set; }
        public virtual DbSet<SODetailInfo> SODetailInfoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_MessageInfo> tbl_MessageInfo { get; set; }
        public virtual DbSet<TestMultiUser> TestMultiUsers { get; set; }
        public virtual DbSet<TmpAdjustmentCarton> TmpAdjustmentCartons { get; set; }
        public virtual DbSet<TmpAdjustmentDetail> TmpAdjustmentDetails { get; set; }
        public virtual DbSet<TmpAdjustmentHeader> TmpAdjustmentHeaders { get; set; }
        public virtual DbSet<TmpAdjustmentPallet> TmpAdjustmentPallets { get; set; }
        public virtual DbSet<TmpTransferCarton> TmpTransferCartons { get; set; }
        public virtual DbSet<TmpTransferDetail> TmpTransferDetails { get; set; }
        public virtual DbSet<TmpTransferHeader> TmpTransferHeaders { get; set; }
        public virtual DbSet<TmpTransferPallet> TmpTransferPallets { get; set; }
        public virtual DbSet<UPCType> UPCTypes { get; set; }
        public virtual DbSet<XPObjectType> XPObjectTypes { get; set; }
        public virtual DbSet<XPWeakReference> XPWeakReferences { get; set; }
        public virtual DbSet<DIO_InventoryInquiryID> DIO_InventoryInquiryID { get; set; }
        public virtual DbSet<DIO_TotalPastShipQtyBK> DIO_TotalPastShipQtyBK { get; set; }
        public virtual DbSet<DIS_MasterItemAudit> DIS_MasterItemAudit { get; set; }
        public virtual DbSet<Tmp_DIO_AttributeType> Tmp_DIO_AttributeType { get; set; }

        private void AddEntity1(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DICustomerAllocationInfo>()
                .HasMany(e => e.DISOAllocationInfoes)
                .WithOptional(e => e.DICustomerAllocationInfo1)
                .HasForeignKey(e => e.DICustomerAllocationInfo);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.HUBNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.PACKCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.LADINGQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.WEIGHT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.WEIGHTUOM)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SCACCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.TRANSPORTATIONTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.CARRIERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPMENTSTATUSCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SERIALTRAILERNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.BOLNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.PRONUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.MANIFESTNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.LOADNUMBER)
                .IsUnicode(false);
        }

        private void AddEntity2(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPPEDTIME)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.FREIGHTMETHODPAYMENT)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.VENDORCODEDUNS)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.VENDOREMAILCONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTOLOCATIONNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTOQUALIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPFROMLOCATIONQUALIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPFROMNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.MASTERBILLOFLADING)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.PORTOFENTRY)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPMENTID)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.REMITTOCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.REMITTONAME)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.REMITTOADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.REMITTOCITY)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.REMITTOZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.REMITTOCOUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.VENDORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.VENDORCITY)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.VENDORSTATE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.VENDORZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.VENDORNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.VENDORADDRESS)
                .IsUnicode(false);
        }

        private void AddEntity3(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTONAME)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTOADDRESS1)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTOADDRESS2)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTOCITY)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTOSTATE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTOZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPTOCOUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPFROMNAME)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPFROMADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPFROMCITY)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPFROMSTATE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.SHIPFROMZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN>()
                .HasMany(e => e.DII_ASN_PO)
                .WithRequired(e => e.DII_ASN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DII_ASN_PO>()
                .Property(e => e.PONUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN_PO>()
                .Property(e => e.POLADINGQUANTITY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_ASN_PO>()
                .Property(e => e.POLADINGWEIGHT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_ASN_PO>()
                .Property(e => e.POLADINGVOLUME)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_ASN_PO>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DII_ASN_PO>()
                .HasMany(e => e.DII_PACK)
                .WithRequired(e => e.DII_ASN_PO)
                .WillCascadeOnDelete(false);

        }

        private void AddEntity4(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DII_ASN_PO>()
                .HasMany(e => e.DII_PALLET_PACK)
                .WithRequired(e => e.DII_ASN_PO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DII_Batch>()
                .HasMany(e => e.DIO_HubBatch)
                .WithOptional(e => e.DII_Batch)
                .HasForeignKey(e => e.BatchID);

            modelBuilder.Entity<DII_Batch>()
                .HasMany(e => e.DIO_ModuleFileBatch)
                .WithOptional(e => e.DII_Batch)
                .HasForeignKey(e => e.BatchID);

            modelBuilder.Entity<DII_Batch>()
                .HasMany(e => e.DIO_VendorBatch)
                .WithOptional(e => e.DII_Batch)
                .HasForeignKey(e => e.BatchID);

            modelBuilder.Entity<DII_INNER_PACK>()
                .Property(e => e.INNERPACKQUANTITY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_INNER_PACK>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK>()
                .Property(e => e.CONTAINERQUALIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK>()
                .Property(e => e.CARTONNUMBERDC)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK>()
                .Property(e => e.CARTONVOLUME)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_PACK>()
                .Property(e => e.CARTONWEIGHT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_PACK>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.SHIPPEDQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.ORDEREDQTY)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.MASTERPACK)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PACKSIZE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PRODUCTCODE1)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PRODUCTCODE2)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PRODUCTCODE3)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PRODUCTCODE4)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.ITEMSIZE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PACKSIZEUNIT)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PRODUCTQUALIFIER1)
                .IsUnicode(false);

        }

        private void AddEntity5(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PRODUCTQUALIFIER2)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PRODUCTQUALIFIER3)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.PRODUCTQUALIFIER4)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PACK_DETAIL>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PALLET_PACK>()
                .Property(e => e.CONTAINERQUALIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PALLET_PACK>()
                .Property(e => e.CONTAINERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PALLET_PACK>()
                .Property(e => e.CARTONNUMBERDC)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PALLET_PACK>()
                .Property(e => e.CARTONVOLUME)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_PALLET_PACK>()
                .Property(e => e.CARTONWEIGHT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DII_PALLET_PACK>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DII_PALLET_PACK>()
                .HasMany(e => e.DII_INNER_PACK)
                .WithRequired(e => e.DII_PALLET_PACK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.POQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.AvailableToShip)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.GroceryPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(19, 4);

        }

        private void AddEntity6(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_860Detail>()
                .Property(e => e.ExtendedLineAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Header>()
                .Property(e => e.TermDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Header>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Header>()
                .Property(e => e.TermDiscDaysDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Header>()
                .Property(e => e.TermDayOfMonth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Header>()
                .Property(e => e.AllowanceOrChargeAmount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Header>()
                .Property(e => e.AllowancePercent6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_860Header>()
                .HasMany(e => e.DIO_860Detail)
                .WithOptional(e => e.DIO_860Header)
                .HasForeignKey(e => e.C860HeaderID);

            modelBuilder.Entity<DIO_ACKCompareInfors>()
                .HasMany(e => e.DIO_ACKSODetail)
                .WithOptional(e => e.DIO_ACKCompareInfors)
                .HasForeignKey(e => e.ACKCompareID);

            modelBuilder.Entity<DIO_ACKSODetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_ACKSODetail>()
                .Property(e => e.ConfirmQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ACKSODetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_ACKSODetail>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_ACKSODetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ACKSODetail>()
                .Property(e => e.ShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ACKSODetail>()
                .HasMany(e => e.DIS_SODetail1)
                .WithOptional(e => e.DIO_ACKSODetail1)
                .HasForeignKey(e => e.ACKDetailID);

            modelBuilder.Entity<DIO_ACKSOHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ACKSOHeader>()
                .HasMany(e => e.DIO_ACKSODetail)
                .WithRequired(e => e.DIO_ACKSOHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ACKSOHeader>()
                .HasMany(e => e.DIO_WHStockOut)
                .WithOptional(e => e.DIO_ACKSOHeader)
                .HasForeignKey(e => e.ACKNo);

            modelBuilder.Entity<DIO_ACKType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ActivityCode>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ActivityCode>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Address>()
                .HasMany(e => e.DIO_CompanyInfo)
                .WithOptional(e => e.DIO_Address)
                .HasForeignKey(e => e.AddressBlockID);

            modelBuilder.Entity<DIO_Address>()
                .HasMany(e => e.DIO_CompanyInfo1)
                .WithOptional(e => e.DIO_Address1)
                .HasForeignKey(e => e.AddressID);

            modelBuilder.Entity<DIO_Address>()
                .HasMany(e => e.DIO_CompanyInfo2)
                .WithOptional(e => e.DIO_Address2)
                .HasForeignKey(e => e.CompanyAddressBlockForCustomerID);

            modelBuilder.Entity<DIO_Address>()
                .HasMany(e => e.DIO_CompanyInfo3)
                .WithOptional(e => e.DIO_Address3)
                .HasForeignKey(e => e.CompanyAddressForCustomerID);

            modelBuilder.Entity<DIO_Address>()
                .HasMany(e => e.DIO_CompanyInfo4)
                .WithOptional(e => e.DIO_Address4)
                .HasForeignKey(e => e.LegalAddressID);
        }

        private void AddEntity7(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_AdjustmentBatch>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentBatch>()
                .Property(e => e.WarehouseCount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AdjustmentCarton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.Onhand)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.ItemQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.ItemQtyInCarton)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.ItemQtyInPallet)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.WarehouseCount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.CountIndividual)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.CountQtyInCarton)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.CountQtyInPallet)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.Difference)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.DifferenceQtyCarton)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.DifferenceQtyPallet)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .Property(e => e.PreviousOnhand)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .HasMany(e => e.DIO_AdjustmentBatch)
                .WithRequired(e => e.DIO_AdjustmentDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AdjustmentDetail>()
                .HasMany(e => e.DIO_AdjustmentSerial)
                .WithRequired(e => e.DIO_AdjustmentDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AdjustmentHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AdjustmentHeader>()
                .HasMany(e => e.DIO_AdjustmentCarton)
                .WithRequired(e => e.DIO_AdjustmentHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AdjustmentHeader>()
                .HasMany(e => e.DIO_AdjustmentDetail)
                .WithRequired(e => e.DIO_AdjustmentHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AdjustmentHeader>()
                .HasMany(e => e.DIO_AdjustmentHeader1)
                .WithOptional(e => e.DIO_AdjustmentHeader2)
                .HasForeignKey(e => e.AdjustmentID);

            modelBuilder.Entity<DIO_AdjustmentHeader>()
                .HasMany(e => e.DIO_AdjustmentPallet)
                .WithRequired(e => e.DIO_AdjustmentHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AdjustmentPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AdjustmentSerial>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentSerial>()
                .Property(e => e.WarehouseCount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_AdjustmentSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AlertBox>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AlertBox>()
                .HasMany(e => e.DIO_AlertBoxViewHistory)
                .WithRequired(e => e.DIO_AlertBox)
                .HasForeignKey(e => e.AlertBoxID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AlertBoxViewHistory>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AllocatedPOSO>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_AllocationItem>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);
        }

        private void AddEntity8(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_AllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AllowanceChargeHandle>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ASNInvoice>()
                .HasMany(e => e.DIO_ASNInvoiceDetail)
                .WithOptional(e => e.DIO_ASNInvoice)
                .HasForeignKey(e => e.ASNInvoice);

            modelBuilder.Entity<DIO_ASNInvoiceDetail>()
                .Property(e => e.InvoiceQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ASNLabelTemplate>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AttributeGroup>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AttributeType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AttributeType>()
                .HasMany(e => e.DIO_AttributeGroup)
                .WithRequired(e => e.DIO_AttributeType)
                .HasForeignKey(e => e.AttributeTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AttributeType>()
                .HasMany(e => e.DIO_AttributeValue)
                .WithRequired(e => e.DIO_AttributeType)
                .HasForeignKey(e => e.AttributeTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AttributeValue>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIS_HubItem)
                .WithOptional(e => e.DIO_AttributeValue)
                .HasForeignKey(e => e.ColorID);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIS_HubItem1)
                .WithOptional(e => e.DIO_AttributeValue1)
                .HasForeignKey(e => e.SizeID);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.DIO_AttributeValue)
                .HasForeignKey(e => e.ColorID);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIS_MasterItem1)
                .WithOptional(e => e.DIO_AttributeValue1)
                .HasForeignKey(e => e.FabricID);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIS_MasterItem2)
                .WithOptional(e => e.DIO_AttributeValue2)
                .HasForeignKey(e => e.SizeID);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIO_MasterKit)
                .WithOptional(e => e.DIO_AttributeValue)
                .HasForeignKey(e => e.ChildColor);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIO_MasterKit1)
                .WithOptional(e => e.DIO_AttributeValue1)
                .HasForeignKey(e => e.ChildSize);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIO_SizeRun)
                .WithRequired(e => e.DIO_AttributeValue)
                .HasForeignKey(e => e.ChildID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIO_SizeRun1)
                .WithRequired(e => e.DIO_AttributeValue1)
                .HasForeignKey(e => e.ParentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIS_VendorItem)
                .WithOptional(e => e.DIO_AttributeValue)
                .HasForeignKey(e => e.ColorID);

            modelBuilder.Entity<DIO_AttributeValue>()
                .HasMany(e => e.DIS_VendorItem1)
                .WithOptional(e => e.DIO_AttributeValue1)
                .HasForeignKey(e => e.SizeID);

            modelBuilder.Entity<DIO_AutoReport>()
                .HasMany(e => e.DIO_AutoReportParameter1)
                .WithOptional(e => e.DIO_AutoReport1)
                .HasForeignKey(e => e.AutoReportNo);

            modelBuilder.Entity<DIO_AutoReport>()
                .HasMany(e => e.DIO_AutoReportParameter2)
                .WithOptional(e => e.DIO_AutoReport2)
                .HasForeignKey(e => e.SONo);

            modelBuilder.Entity<DIO_AutoReportEmail>()
                .HasMany(e => e.DIO_AutoReport)
                .WithOptional(e => e.DIO_AutoReportEmail)
                .HasForeignKey(e => e.SendToEmail);

            modelBuilder.Entity<DIO_AutoReportParameter>()
                .HasMany(e => e.DIO_AutoReport)
                .WithOptional(e => e.DIO_AutoReportParameter)
                .HasForeignKey(e => e.Parameters);

            modelBuilder.Entity<DIO_AutoReportTime>()
                .HasMany(e => e.DIO_AutoReport)
                .WithOptional(e => e.DIO_AutoReportTime)
                .HasForeignKey(e => e.Time);

            modelBuilder.Entity<DIO_AverageSalesOfLastYear>()
                .Property(e => e.MovingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BalanceSheet>()
                .Property(e => e.BeginningAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_BalanceSheet>()
                .Property(e => e.EndingAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_BankList>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);
        }

        private void AddEntity9(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_BankList>()
                .HasMany(e => e.DIO_CustomerPayment)
                .WithOptional(e => e.DIO_BankList)
                .HasForeignKey(e => e.BankNo);

            modelBuilder.Entity<DIO_BankList>()
                .HasMany(e => e.DIO_CustomerStatement)
                .WithOptional(e => e.DIO_BankList)
                .HasForeignKey(e => e.BankNo);

            modelBuilder.Entity<DIO_BasisUnitPrice>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.QtyInUsed)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.AllocatedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.IndividualQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.CartonQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.TmpQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.TmpIndividualQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.TmpCartonQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch>()
                .Property(e => e.NPSelectedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_AdjustmentBatch)
                .WithRequired(e => e.DIO_Batch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_Batch_ReceivedDate)
                .WithOptional(e => e.DIO_Batch)
                .HasForeignKey(e => e.Batch);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_LineItemDetailBatch)
                .WithOptional(e => e.DIO_Batch)
                .HasForeignKey(e => e.Batch);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_LocationManagementDetailBatch)
                .WithOptional(e => e.DIO_Batch)
                .HasForeignKey(e => e.Batch);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_nInventoryLineItemBatch)
                .WithOptional(e => e.DIO_Batch)
                .HasForeignKey(e => e.Batch);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_PackDetailItemBatch)
                .WithOptional(e => e.DIO_Batch)
                .HasForeignKey(e => e.PackDetailBatchID);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_LineItemBatch)
                .WithRequired(e => e.DIO_Batch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_OpenPackBatch)
                .WithRequired(e => e.DIO_Batch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_PackItemBatch)
                .WithRequired(e => e.DIO_Batch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_ReturnReceiptBatch)
                .WithRequired(e => e.DIO_Batch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_ReturnShipmentBatch)
                .WithRequired(e => e.DIO_Batch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Batch>()
                .HasMany(e => e.DIO_TransferBatch)
                .WithRequired(e => e.DIO_Batch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Batch_ReceivedDate>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch_ReceivedDate>()
                .Property(e => e.QuantityInBox)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch_ReceivedDate>()
                .Property(e => e.AllocatedIndividualQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Batch_ReceivedDate>()
                .Property(e => e.AllocatedInBoxQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BatchContainer>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BatchContainer>()
                .HasMany(e => e.DIO_IVABatch)
                .WithOptional(e => e.DIO_BatchContainer)
                .HasForeignKey(e => e.BatchContainer);

            modelBuilder.Entity<DIO_BillOfMaterial>()
                .Property(e => e.LabourCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BillOfMaterialDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BillToTransportation>()
                .HasMany(e => e.DIO_CarrierInfo)
                .WithOptional(e => e.DIO_BillToTransportation)
                .HasForeignKey(e => e.BillToTransportationID);

            modelBuilder.Entity<DIO_BillToTransportation>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .WithOptional(e => e.DIO_BillToTransportation)
                .HasForeignKey(e => e.BillToTransportation);

            modelBuilder.Entity<DIO_BillToTransportation>()
                .HasMany(e => e.DIS_Hub)
                .WithOptional(e => e.DIO_BillToTransportation)
                .HasForeignKey(e => e.BillToTransportation);

            modelBuilder.Entity<DIO_BillToTransportation>()
                .HasMany(e => e.DIS_Hub1)
                .WithOptional(e => e.DIO_BillToTransportation1)
                .HasForeignKey(e => e.FedexBillToTransportation);

            modelBuilder.Entity<DIO_BillToTransportation>()
                .HasMany(e => e.DIS_SOHeader)
                .WithOptional(e => e.DIO_BillToTransportation)
                .HasForeignKey(e => e.BillToTransportation);

            modelBuilder.Entity<DIO_BlanketPODetail>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketPODetail>()
                .Property(e => e.OrderedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketPODetail>()
                .Property(e => e.RemainingQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketPODetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketPODetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketPODetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketPODetail>()
                .Property(e => e.FCLQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketPOHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketPOHeader>()
                .HasMany(e => e.DIS_POHeader)
                .WithOptional(e => e.DIO_BlanketPOHeader)
                .HasForeignKey(e => e.BlanketPOContractNo);

            modelBuilder.Entity<DIO_BlanketSODetail>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketSODetail>()
                .Property(e => e.OrderedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketSODetail>()
                .Property(e => e.RemainingQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketSODetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketSODetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketSODetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketSODetail>()
                .Property(e => e.FCLQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BlanketSOHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(19, 4);
        }

        private void AddEntity10(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_BlanketSOHeader>()
                .HasMany(e => e.DIS_SOHeader)
                .WithOptional(e => e.DIO_BlanketSOHeader)
                .HasForeignKey(e => e.BlanketPOContractNo);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCarrierInfo>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BOLCustomerInfo>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_BOLCustomerInfo>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Brand>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_BrokerPayment>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BrokerPayment>()
                .Property(e => e.InvoiceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_BrokerPaymentDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CarrierAccounts>()
                .Property(e => e.ShipmentWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CategoryItemPolicy>()
                .Property(e => e.FromQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CategoryItemPolicy>()
                .Property(e => e.ToQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CategoryItemPolicy>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Channel>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_City>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_CompanyInfo>()
                .HasMany(e => e.DIO_CompanyService)
                .WithOptional(e => e.DIO_CompanyInfo)
                .HasForeignKey(e => e.CompanyInfoID);

            modelBuilder.Entity<DIO_Country>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Country>()
                .HasMany(e => e.DIO_Address)
                .WithOptional(e => e.DIO_Country)
                .HasForeignKey(e => e.CountryID);

            modelBuilder.Entity<DIO_Country>()
                .HasMany(e => e.DIO_Address1)
                .WithOptional(e => e.DIO_Country1)
                .HasForeignKey(e => e.CountryInfo);

            modelBuilder.Entity<DIO_Country>()
                .HasMany(e => e.DIO_City)
                .WithRequired(e => e.DIO_Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Country>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.DIO_Country)
                .HasForeignKey(e => e.MadeIn);

            modelBuilder.Entity<DIO_Country>()
                .HasMany(e => e.DIO_State)
                .WithRequired(e => e.DIO_Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Credit>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_CreditDebitDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CreditDebitDetail>()
                .HasMany(e => e.DIO_CreditDebitPayment)
                .WithOptional(e => e.DIO_CreditDebitDetail)
                .HasForeignKey(e => e.CreditDebitDetailID);

            modelBuilder.Entity<DIO_CreditDebitMemo>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CreditDebitMemo>()
                .Property(e => e.AmtToUse)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CreditDebitMemo>()
                .Property(e => e.RemainAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CreditDebitPayment>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CreditDebitPayment>()
                .Property(e => e.RemainAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Currency>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_Currency>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_BlanketPOHeader)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.BaseCurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_BlanketPOHeader1)
                .WithOptional(e => e.DIO_Currency1)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_BlanketSOHeader)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.BaseCurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_BlanketSOHeader1)
                .WithOptional(e => e.DIO_Currency1)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_CategoryItemPolicy)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyID);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_CreditDebitMemo)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.Currency);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_CustomerCategoryPrice)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyID);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_CustomerPayment)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_CustomerStatement)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_ItemDateRangePrice)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.Currency);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.BaseCurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader1)
                .WithOptional(e => e.DIO_Currency1)
                .HasForeignKey(e => e.Currency);
        }

        private void AddEntity11(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIO_SuggestionPrice)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyID);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIS_SaleInvoiceHeader)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIS_Hub)
                .WithRequired(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIS_POHeader)
                .WithOptional(e => e.DIO_Currency)
                .HasForeignKey(e => e.BaseCurrencyCode);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIS_POHeader1)
                .WithRequired(e => e.DIO_Currency1)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIS_SOHeader)
                .WithRequired(e => e.DIO_Currency)
                .HasForeignKey(e => e.BaseCurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIS_SOHeader1)
                .WithRequired(e => e.DIO_Currency1)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Currency>()
                .HasMany(e => e.DIS_Vendor)
                .WithRequired(e => e.DIO_Currency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_CustomerCategories>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_CustomerCategories>()
                .HasMany(e => e.DIO_CategoryItems)
                .WithOptional(e => e.DIO_CustomerCategories)
                .HasForeignKey(e => e.CustomerCategoryID);

            modelBuilder.Entity<DIO_CustomerCategories>()
                .HasMany(e => e.DIO_CustomerCategoryPrice)
                .WithOptional(e => e.DIO_CustomerCategories)
                .HasForeignKey(e => e.CustomerCategoriesID);

            modelBuilder.Entity<DIO_CustomerCategoryPrice>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerMarkForStore>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .Property(e => e.DebitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .Property(e => e.CreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .Property(e => e.INVCMNetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .Property(e => e.INVCMAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .Property(e => e.INVCMDiscAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .HasMany(e => e.DIO_CustomerPaymentDetail)
                .WithOptional(e => e.DIO_CustomerPayment)
                .HasForeignKey(e => e.CustomerPayementID);

            modelBuilder.Entity<DIO_CustomerPayment>()
                .HasMany(e => e.DIO_CustomerPaymentDetail1)
                .WithOptional(e => e.DIO_CustomerPayment1)
                .HasForeignKey(e => e.CustomerPaymentID);

            modelBuilder.Entity<DIO_CustomerPaymentDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPaymentDetail>()
                .Property(e => e.NetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPaymentDetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerPostingGroup>()
                .Property(e => e.UpdateDate)
                .IsFixedLength();

            modelBuilder.Entity<DIO_CustomerRouting>()
                .HasMany(e => e.DIO_CustomerRoutingDetail)
                .WithOptional(e => e.DIO_CustomerRouting)
                .HasForeignKey(e => e.CustomerRoutingID);

            modelBuilder.Entity<DIO_CustomerRoutingDetail>()
                .Property(e => e.HandlingUnitMin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerRoutingDetail>()
                .Property(e => e.HandlingUnitMax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerRoutingDetail>()
                .Property(e => e.CubeMin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerRoutingDetail>()
                .Property(e => e.CubeMax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerRoutingDetail>()
                .Property(e => e.WeightMax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerRoutingDetail>()
                .Property(e => e.WeightMin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerStatement>()
                .Property(e => e.DebitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerStatement>()
                .Property(e => e.CreditAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerStatement>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomerStatement>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_CustomReport>()
                .HasMany(e => e.DIO_CustomReport1)
                .WithOptional(e => e.DIO_CustomReport2)
                .HasForeignKey(e => e.ParentReportID);

            modelBuilder.Entity<DIO_CustomReport>()
                .HasMany(e => e.DIO_HubReportField)
                .WithOptional(e => e.DIO_CustomReport)
                .HasForeignKey(e => e.CustomReportID);

            modelBuilder.Entity<DIO_CustomReport>()
                .HasMany(e => e.DIO_ReportField)
                .WithOptional(e => e.DIO_CustomReport)
                .HasForeignKey(e => e.CustomReport);

            modelBuilder.Entity<DIO_CustomReport>()
                .HasMany(e => e.DIO_ReportField1)
                .WithOptional(e => e.DIO_CustomReport1)
                .HasForeignKey(e => e.CustomReportID);

            modelBuilder.Entity<DIO_CustomReport>()
                .HasMany(e => e.DIO_ReportParameter)
                .WithOptional(e => e.DIO_CustomReport)
                .HasForeignKey(e => e.ReportID);

            modelBuilder.Entity<DIO_Customs>()
                .Property(e => e.CustomsRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_Customs>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_DefaultPackSize>()
                .Property(e => e.PackQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_DefaultShippingInfo>()
                .HasMany(e => e.DIO_CustomerRoutingDetail)
                .WithOptional(e => e.DIO_DefaultShippingInfo)
                .HasForeignKey(e => e.ShipToConsolidorAddressID);

            modelBuilder.Entity<DIO_DefaultShippingInfo>()
                .HasMany(e => e.DIO_CustomerRoutingDetail1)
                .WithOptional(e => e.DIO_DefaultShippingInfo1)
                .HasForeignKey(e => e.ShipToStoreAddressID);

            modelBuilder.Entity<DIO_DefaultShippingInfo>()
                .HasMany(e => e.DIO_HubItemStore)
                .WithOptional(e => e.DIO_DefaultShippingInfo)
                .HasForeignKey(e => e.DefaultShippingInfo);
        }

        private void AddEntity12(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_Department>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Discount>()
                .Property(e => e.DiscountRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_Discount>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_EDIExportMappingType>()
                .HasMany(e => e.DIO_HubEDIExportMapping)
                .WithOptional(e => e.DIO_EDIExportMappingType)
                .HasForeignKey(e => e.EDIExportMappingTypeID);

            modelBuilder.Entity<DIO_EDIExportMappingType>()
                .HasMany(e => e.DIO_VendorEDIExportMapping)
                .WithOptional(e => e.DIO_EDIExportMappingType)
                .HasForeignKey(e => e.EDIExportMappingTypeID);

            modelBuilder.Entity<DIO_EDIMappingType>()
                .HasMany(e => e.DIO_HubEDIMapping)
                .WithOptional(e => e.DIO_EDIMappingType)
                .HasForeignKey(e => e.EDIMappingTypeID);

            modelBuilder.Entity<DIO_EDIMappingType>()
                .HasMany(e => e.DIO_VendorEDIMapping)
                .WithOptional(e => e.DIO_EDIMappingType)
                .HasForeignKey(e => e.EDIMappingTypeID);

            modelBuilder.Entity<DIO_EPCIS_AggregationEvent>()
                .HasMany(e => e.DIO_EPCIS_ChildEPCs)
                .WithOptional(e => e.DIO_EPCIS_AggregationEvent)
                .HasForeignKey(e => e.AggregationEvent);

            modelBuilder.Entity<DIO_EPCIS_Header>()
                .HasMany(e => e.DIO_EPCIS_AggregationEvent)
                .WithOptional(e => e.DIO_EPCIS_Header)
                .HasForeignKey(e => e.Header);

            modelBuilder.Entity<DIO_EPCIS_Header>()
                .HasMany(e => e.DIO_EPCIS_ObjectEvent)
                .WithOptional(e => e.DIO_EPCIS_Header)
                .HasForeignKey(e => e.Header);

            modelBuilder.Entity<DIO_EPCIS_Header>()
                .HasMany(e => e.DIO_EPCIS_TransactionEvent)
                .WithOptional(e => e.DIO_EPCIS_Header)
                .HasForeignKey(e => e.Header);

            modelBuilder.Entity<DIO_EPCIS_Header>()
                .HasMany(e => e.DIO_EPCIS_Vocabulary)
                .WithOptional(e => e.DIO_EPCIS_Header)
                .HasForeignKey(e => e.Header);

            modelBuilder.Entity<DIO_EPCIS_ObjectEvent>()
                .HasMany(e => e.DIO_EPCIS_BizTransaction)
                .WithOptional(e => e.DIO_EPCIS_ObjectEvent)
                .HasForeignKey(e => e.ObjectEvent);

            modelBuilder.Entity<DIO_EPCIS_ObjectEvent>()
                .HasMany(e => e.DIO_EPCIS_CompanyMasterData)
                .WithOptional(e => e.DIO_EPCIS_ObjectEvent)
                .HasForeignKey(e => e.ObjectEvent);

            modelBuilder.Entity<DIO_EPCIS_ObjectEvent>()
                .HasMany(e => e.DIO_EPCIS_DestinationList)
                .WithOptional(e => e.DIO_EPCIS_ObjectEvent)
                .HasForeignKey(e => e.ObjectEvent);

            modelBuilder.Entity<DIO_EPCIS_ObjectEvent>()
                .HasMany(e => e.DIO_EPCIS_Epc)
                .WithOptional(e => e.DIO_EPCIS_ObjectEvent)
                .HasForeignKey(e => e.ObjectEvent);

            modelBuilder.Entity<DIO_EPCIS_ObjectEvent>()
                .HasMany(e => e.DIO_EPCIS_SourceList)
                .WithOptional(e => e.DIO_EPCIS_ObjectEvent)
                .HasForeignKey(e => e.ObjectEvent);

            modelBuilder.Entity<DIO_EPCIS_TransactionEvent>()
                .HasMany(e => e.DIO_EPCIS_BizTransaction)
                .WithOptional(e => e.DIO_EPCIS_TransactionEvent)
                .HasForeignKey(e => e.TransactionEvent);

            modelBuilder.Entity<DIO_EPCIS_TransactionEvent>()
                .HasMany(e => e.DIO_EPCIS_Epc)
                .WithOptional(e => e.DIO_EPCIS_TransactionEvent)
                .HasForeignKey(e => e.TransactionEvent);

            modelBuilder.Entity<DIO_EPCIS_Vocabulary>()
                .HasMany(e => e.DIO_EPCIS_Vocabulary_Element)
                .WithOptional(e => e.DIO_EPCIS_Vocabulary)
                .HasForeignKey(e => e.Vocabulary);

            modelBuilder.Entity<DIO_EPCIS_Vocabulary_Element>()
                .HasMany(e => e.DIO_EPCIS_Element_Attribute)
                .WithOptional(e => e.DIO_EPCIS_Vocabulary_Element)
                .HasForeignKey(e => e.Element);

            modelBuilder.Entity<DIO_ERP_Hub>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ERP_Item>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ERP_QBSODetailAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ERP_SOHeaderAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ERP_Store>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ERP_System>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ERP_Term>()
                .Property(e => e.NetDay)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ERP_Term>()
                .Property(e => e.DiscPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_ERP_Term>()
                .Property(e => e.DiscIfPaidWithin)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_ERP_Term>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ERP_Term>()
                .HasMany(e => e.DIS_Hub)
                .WithOptional(e => e.DIO_ERP_Term)
                .HasForeignKey(e => e.HubTermID);

            modelBuilder.Entity<DIO_ERP_Term>()
                .HasMany(e => e.DIS_Vendor)
                .WithOptional(e => e.DIO_ERP_Term)
                .HasForeignKey(e => e.VendorTermID);

            modelBuilder.Entity<DIO_ERP_TransportationProvider>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ERP_Vendor>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Expenditure>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_Expenditure>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Expenditure>()
                .HasMany(e => e.DIO_StockInExpenditure)
                .WithRequired(e => e.DIO_Expenditure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.OnHand)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Open_Orders)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Bom_Configuration)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.ATS_Stock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.WIP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.ATS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Planned_WIP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Bom_Plan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.ATS_Plan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.In_Pick)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Booked)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Cancelled)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Shipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Returned)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Received)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Purchases)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Adjusted)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Bom_Used)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.On_Shipment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Sub_Order)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Sub_Pick)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Sub_Shipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.ATS_UnAssigned)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Safety_Stock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Min_Available_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Reorder_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Pack_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Line_Price)
                .HasPrecision(19, 4);
        }

        private void AddEntity13(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Retail_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Std_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Avg_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Last_Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Last_Rec_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Next_Eta_PO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Next_Eta_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Last_Book_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Last_Invoice_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.Average_Sales)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalInventory>()
                .Property(e => e.NAvailableQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ExternalService>()
                .HasMany(e => e.DIO_AutoFillAddressMapping)
                .WithOptional(e => e.DIO_ExternalService)
                .HasForeignKey(e => e.ExternalService);

            modelBuilder.Entity<DIO_ExternalService>()
                .HasMany(e => e.DIO_ExternalServiceFunction)
                .WithOptional(e => e.DIO_ExternalService)
                .HasForeignKey(e => e.ExternalService);

            modelBuilder.Entity<DIO_ExternalServiceFunction>()
                .HasMany(e => e.DIO_ExternalServiceInput)
                .WithOptional(e => e.DIO_ExternalServiceFunction)
                .HasForeignKey(e => e.Function);

            modelBuilder.Entity<DIO_ExternalServiceFunction>()
                .HasMany(e => e.DIO_ExternalServiceOutput)
                .WithOptional(e => e.DIO_ExternalServiceFunction)
                .HasForeignKey(e => e.Function);

            modelBuilder.Entity<DIO_FOBPayment>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_FOBPayment>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader)
                .WithOptional(e => e.DIO_FOBPayment)
                .HasForeignKey(e => e.FOBID);

            modelBuilder.Entity<DIO_FormMapping>()
                .HasMany(e => e.DIO_FormConfig)
                .WithOptional(e => e.DIO_FormMapping)
                .HasForeignKey(e => e.TableID);

            modelBuilder.Entity<DIO_FormMapping>()
                .HasMany(e => e.DIO_HubFormMapping)
                .WithOptional(e => e.DIO_FormMapping)
                .HasForeignKey(e => e.FormMappingID);

            modelBuilder.Entity<DIO_Freight>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_Freight>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Freight>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentFreight)
                .WithOptional(e => e.DIO_Freight)
                .HasForeignKey(e => e.Freight);

            modelBuilder.Entity<DIO_Freight>()
                .HasMany(e => e.DIO_HubFreight)
                .WithRequired(e => e.DIO_Freight)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Freight>()
                .HasMany(e => e.DIO_StockInFreight)
                .WithRequired(e => e.DIO_Freight)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Freight>()
                .HasMany(e => e.DIO_VendorFreight)
                .WithRequired(e => e.DIO_Freight)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_FTPAccount>()
                .Property(e => e.FTPServerType)
                .HasPrecision(5, 0);

            modelBuilder.Entity<DIO_FTPAccount>()
                .Property(e => e.FTPType)
                .HasPrecision(5, 0);

            modelBuilder.Entity<DIO_GLAccount>()
                .Property(e => e.Balance)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_CustomerPostingGroup)
                .WithRequired(e => e.DIO_GLAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_GLAccount1)
                .WithOptional(e => e.DIO_GLAccount2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_ImportJournalLine)
                .WithRequired(e => e.DIO_GLAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_ProductPostingGroup)
                .WithOptional(e => e.DIO_GLAccount)
                .HasForeignKey(e => e.COGSAccount);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_ProductPostingGroup1)
                .WithOptional(e => e.DIO_GLAccount1)
                .HasForeignKey(e => e.PurchaseAccount);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_ProductPostingGroup2)
                .WithOptional(e => e.DIO_GLAccount2)
                .HasForeignKey(e => e.PurchaseDiscAccount);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_ProductPostingGroup3)
                .WithOptional(e => e.DIO_GLAccount3)
                .HasForeignKey(e => e.PurchaseCreditMemoAccount);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_ProductPostingGroup4)
                .WithOptional(e => e.DIO_GLAccount4)
                .HasForeignKey(e => e.SalesAccount);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_ProductPostingGroup5)
                .WithOptional(e => e.DIO_GLAccount5)
                .HasForeignKey(e => e.SalesDiscAccount);

            modelBuilder.Entity<DIO_GLAccount>()
                .HasMany(e => e.DIO_ProductPostingGroup6)
                .WithOptional(e => e.DIO_GLAccount6)
                .HasForeignKey(e => e.SalesCreditMemoAccount);

            modelBuilder.Entity<DIO_GLEntry>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_GLEntry>()
                .Property(e => e.Debit)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_GLEntry>()
                .Property(e => e.Credit)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_GroupItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Historical_Info>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_HubAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_HubAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_HubClass>()
                .Property(e => e.HubClassCode)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_HubClass>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_HubContactInfo>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_HubFormMapping>()
                .HasMany(e => e.DIO_FormConfig)
                .WithOptional(e => e.DIO_HubFormMapping)
                .HasForeignKey(e => e.TableMappedID);

            modelBuilder.Entity<DIO_HubFreight>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_HubFreight>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_HubItemAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_HubItemAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_HubItemSaleRep>()
                .Property(e => e.CommissionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_HubSaleRep>()
                .Property(e => e.CommissionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ImportJournalLine>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_ImportJournalLine>()
                .Property(e => e.Debit)
                .HasPrecision(28, 4);
        }

        private void AddEntity14(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_ImportJournalLine>()
                .Property(e => e.Credit)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InventoryAdviceConfig>()
                .Property(e => e.LastFileNumber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceConfig>()
                .Property(e => e.FileNumberLength)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceConfig>()
                .HasMany(e => e.DIO_InventoryAdviceHeader)
                .WithOptional(e => e.DIO_InventoryAdviceConfig)
                .HasForeignKey(e => e.InventoryAdviceConfigID);

            modelBuilder.Entity<DIO_InventoryAdviceConfig>()
                .HasMany(e => e.DIO_WarehouseLevelTemplate)
                .WithOptional(e => e.DIO_InventoryAdviceConfig)
                .HasForeignKey(e => e.InventoryAdviceConfigID);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.HashTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.ExtendedLineAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.Backordered)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.OnOrder)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.NextAvailability)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.AdjustedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceDetail>()
                .Property(e => e.AvailableToSalesQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceHeader>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryAdviceHeader>()
                .Property(e => e.HashTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .Property(e => e.Volume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_AdjustmentCarton)
                .WithRequired(e => e.DIO_InventoryCarton)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_InventoryCartonShippingAdvice)
                .WithOptional(e => e.DIO_InventoryCarton)
                .HasForeignKey(e => e.InventoryCartonID);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_PackDetailCarton)
                .WithOptional(e => e.DIO_InventoryCarton)
                .HasForeignKey(e => e.InventoryCartonID);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_WHShippingAdviceDetailCarton)
                .WithOptional(e => e.DIO_InventoryCarton)
                .HasForeignKey(e => e.CartonID);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_WSTReceiptAdviceCarton)
                .WithOptional(e => e.DIO_InventoryCarton)
                .HasForeignKey(e => e.TmpInvCarton);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_InventoryRepackCarton)
                .WithRequired(e => e.DIO_InventoryCarton)
                .HasForeignKey(e => e.NewCartonNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_InventoryRepackCarton1)
                .WithRequired(e => e.DIO_InventoryCarton1)
                .HasForeignKey(e => e.OriginalCartonNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_PickDetailCarton)
                .WithRequired(e => e.DIO_InventoryCarton)
                .HasForeignKey(e => e.InventoryCartonNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.TmpAdjustmentCartons)
                .WithRequired(e => e.DIO_InventoryCarton)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.TmpTransferCartons)
                .WithRequired(e => e.DIO_InventoryCarton)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryCarton>()
                .HasMany(e => e.DIO_TransferCarton)
                .WithRequired(e => e.DIO_InventoryCarton)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryCartonDimension>()
                .Property(e => e.Length)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryCartonDimension>()
                .Property(e => e.Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryCartonDimension>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryCartonDimension>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryCartonShippingAdvice>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryCartonShippingAdvice>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryCartonShippingAdvice>()
                .HasMany(e => e.DIO_InventoryLineItemShippingAdvice)
                .WithOptional(e => e.DIO_InventoryCartonShippingAdvice)
                .HasForeignKey(e => e.InventoryCartonShippingAdviceNo);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.UOMRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.Volume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.NPUsedQuantityInTransaction)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.CountQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.ShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .Property(e => e.Difference)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItem>()
                .HasMany(e => e.DIO_InventoryLineItemShippingAdvice)
                .WithOptional(e => e.DIO_InventoryLineItem)
                .HasForeignKey(e => e.InventoryLineItemID);

            modelBuilder.Entity<DIO_InventoryLineItemShippingAdvice>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItemShippingAdvice>()
                .Property(e => e.CountQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItemShippingAdvice>()
                .Property(e => e.ShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItemShippingAdvice>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItemShippingAdvice>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItemShippingAdvice>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryLineItemShippingAdvice>()
                .HasMany(e => e.DIO_InventoryLineItemShippingAdviceBatch)
                .WithOptional(e => e.DIO_InventoryLineItemShippingAdvice)
                .HasForeignKey(e => e.InventoryLineItemShippingAdviceID);

            modelBuilder.Entity<DIO_InventoryLineItemShippingAdviceBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_AdjustmentPallet)
                .WithRequired(e => e.DIO_InventoryPallet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_InventoryLineItem)
                .WithOptional(e => e.DIO_InventoryPallet)
                .HasForeignKey(e => e.Pallet);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_InventoryPalletShippingAdvice)
                .WithOptional(e => e.DIO_InventoryPallet)
                .HasForeignKey(e => e.InventoryPalletID);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_InventoryPalletShippingAdvice1)
                .WithOptional(e => e.DIO_InventoryPallet1)
                .HasForeignKey(e => e.PalletID);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_PackDetailPallet)
                .WithOptional(e => e.DIO_InventoryPallet)
                .HasForeignKey(e => e.InventoryPalletID);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_WHShippingAdviceDetailPallet)
                .WithOptional(e => e.DIO_InventoryPallet)
                .HasForeignKey(e => e.PalletID);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePallet)
                .WithOptional(e => e.DIO_InventoryPallet)
                .HasForeignKey(e => e.TmpInvPallet);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_InventoryPallet1)
                .WithOptional(e => e.DIO_InventoryPallet2)
                .HasForeignKey(e => e.OriginalPallet);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_PickDetailPallet)
                .WithRequired(e => e.DIO_InventoryPallet)
                .HasForeignKey(e => e.InventoryPalletNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.TmpAdjustmentPallets)
                .WithRequired(e => e.DIO_InventoryPallet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.TmpTransferPallets)
                .WithRequired(e => e.DIO_InventoryPallet)
                .WillCascadeOnDelete(false);
        }

        private void AddEntity15(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_InventoryPallet>()
                .HasMany(e => e.DIO_TransferPallet)
                .WithRequired(e => e.DIO_InventoryPallet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_InventoryPalletDimension>()
                .Property(e => e.Length)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryPalletDimension>()
                .Property(e => e.Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryPalletDimension>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryPalletDimension>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryPalletShippingAdvice>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryPalletShippingAdvice>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryPalletShippingAdvice>()
                .HasMany(e => e.DIO_InventoryCartonShippingAdvice)
                .WithOptional(e => e.DIO_InventoryPalletShippingAdvice)
                .HasForeignKey(e => e.InventoryPalletShippingAdviceNo);

            modelBuilder.Entity<DIO_InventoryPalletShippingAdvice>()
                .HasMany(e => e.DIO_InventoryLineItemShippingAdvice)
                .WithOptional(e => e.DIO_InventoryPalletShippingAdvice)
                .HasForeignKey(e => e.InventoryPalletShippingAdviceNo);

            modelBuilder.Entity<DIO_InventoryReason>()
                .HasMany(e => e.DIO_InventoryCarton)
                .WithOptional(e => e.DIO_InventoryReason)
                .HasForeignKey(e => e.InventoryReason);

            modelBuilder.Entity<DIO_InventoryReason>()
                .HasMany(e => e.DIO_InventoryPallet)
                .WithOptional(e => e.DIO_InventoryReason)
                .HasForeignKey(e => e.InventoryReason);

            modelBuilder.Entity<DIO_InventoryReason>()
                .HasMany(e => e.DIO_WSTReceiptAdviceCarton)
                .WithOptional(e => e.DIO_InventoryReason)
                .HasForeignKey(e => e.InventoryReason);

            modelBuilder.Entity<DIO_InventoryReason>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePallet)
                .WithOptional(e => e.DIO_InventoryReason)
                .HasForeignKey(e => e.InventoryReason);

            modelBuilder.Entity<DIO_InventoryRepackCarton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_InventoryCarton)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_InventoryLineItem)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_InventoryPallet)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_LineItemBatch)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_LineItemSerial)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_LocationManagementDetail)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_Serial)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_WSTReceiptAdviceCarton)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItemBatch)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItemSerial)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryStatus>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePallet)
                .WithOptional(e => e.DIO_InventoryStatus)
                .HasForeignKey(e => e.InventoryStatus);

            modelBuilder.Entity<DIO_InventoryValuationAudit>()
                .Property(e => e.TransactionQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryValuationAudit>()
                .Property(e => e.IssuedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryValuationAudit>()
                .Property(e => e.TransactionPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryValuationAudit>()
                .Property(e => e.CalculatedCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryValuationAudit>()
                .Property(e => e.CumulativeQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryValuationAudit>()
                .Property(e => e.CumulativeValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_InventoryValuationAudit>()
                .HasMany(e => e.DIO_InventoryValuationAudit1)
                .WithOptional(e => e.DIO_InventoryValuationAudit2)
                .HasForeignKey(e => e.TransactionReference);

            modelBuilder.Entity<DIO_InvoicePOFreight>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InvoicePOFreight>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_InvoiceSOFreight>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_InvoiceSOFreight>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_InvoiceType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ItemDateRangePrice>()
                .Property(e => e.Price)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_ItemDateRangePrice>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ItemDateRangePrice>()
                .Property(e => e.Qty_From)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ItemDateRangePrice>()
                .Property(e => e.Qty_To)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ItemQuantityPrice>()
                .Property(e => e.FromQuanity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ItemQuantityPrice>()
                .Property(e => e.ToQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ItemQuantityPrice>()
                .Property(e => e.Price)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_ItemQuantityPrice>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ItemShippingAdvice>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ItemShippingAdvice>()
                .Property(e => e.CountQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ItemShippingAdvice>()
                .Property(e => e.ShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_IVABatch>()
                .Property(e => e.TransactionQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_IVABatch>()
                .Property(e => e.CumulativeQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_IVABatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_IVABatch>()
                .Property(e => e.TransQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_KitDetail>()
                .Property(e => e.KitQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_KitDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_KitDetail>()
                .Property(e => e.TimeImplement)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_KitDetail>()
                .HasMany(e => e.DIO_OpenPackDetail)
                .WithRequired(e => e.DIO_KitDetail)
                .WillCascadeOnDelete(false);
        }

        private void AddEntity16(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_KitDetail>()
                .HasMany(e => e.DIO_PackItemDetail)
                .WithRequired(e => e.DIO_KitDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_LandedCostHeader>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.CustomsAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.ExpenditureAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.DistributedAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.WarehouseCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.DiscountRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LandedCostLineItem>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LengthWidthUOM>()
                .Property(e => e.LenghtRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_LengthWidthUOM>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_LineItemBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_LineItemBatch>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LineItemBatch>()
                .Property(e => e.ScanQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LineItemBatch>()
                .Property(e => e.CountQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LineItemBatch>()
                .HasMany(e => e.DIO_nInventoryLineItemBatch)
                .WithOptional(e => e.DIO_LineItemBatch)
                .HasForeignKey(e => e.LineItemBatch);

            modelBuilder.Entity<DIO_LineItemDetailBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LineItemSerial>()
                .Property(e => e.CountQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LineItemStatus>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.Onhand)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.Allocated)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.OnOrder)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.InTransit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.Packed)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.IndividualItemQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.AllocatedForWO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.InProductionQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.ForecastLeadTime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.ForecastMinInventoryQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.NumberOfCartons)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.MovingAverageGrowthRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.MinPOQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.AllocatedForPackItem)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.SafetyStock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.MovingAverageAdjustment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.OnhandSmartTurn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .Property(e => e.AtpSmartTurn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement>()
                .HasMany(e => e.DIO_LocationManagement_ReceivedDate)
                .WithOptional(e => e.DIO_LocationManagement)
                .HasForeignKey(e => e.LocManagement);

            modelBuilder.Entity<DIO_LocationManagement>()
                .HasMany(e => e.DIO_LocationManagementDetail)
                .WithOptional(e => e.DIO_LocationManagement)
                .HasForeignKey(e => e.LocationManagement);

            modelBuilder.Entity<DIO_LocationManagement>()
                .HasMany(e => e.DIO_PackItemDetailLocation)
                .WithOptional(e => e.DIO_LocationManagement)
                .HasForeignKey(e => e.LocationManagement);

            modelBuilder.Entity<DIO_LocationManagement_ReceivedDate>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement_ReceivedDate>()
                .Property(e => e.IndividualQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement_ReceivedDate>()
                .Property(e => e.QuantityInBox)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement_ReceivedDate>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(19, 4);
        }

        private void AddEntity17(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_LocationManagement_ReceivedDate>()
                .Property(e => e.UsedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement_ReceivedDate>()
                .Property(e => e.UsedIndividualQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement_ReceivedDate>()
                .Property(e => e.UsedInBoxQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagement_ReceivedDate>()
                .HasMany(e => e.DIO_SelectItemOTS_FIFO)
                .WithOptional(e => e.DIO_LocationManagement_ReceivedDate)
                .HasForeignKey(e => e.dioLocReceivedDate);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.Onhand)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.Allocated)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.Packed)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.OnOrder)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.IndividualItemQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.AllocatedForWO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.InProductionQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .Property(e => e.TotalCartons)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetail>()
                .HasMany(e => e.DIO_LocationManagementDetailBatch)
                .WithOptional(e => e.DIO_LocationManagementDetail)
                .HasForeignKey(e => e.LocationManagementDetail);

            modelBuilder.Entity<DIO_LocationManagementDetailBatch>()
                .Property(e => e.Onhand)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetailBatch>()
                .Property(e => e.Allocated)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetailBatch>()
                .Property(e => e.Packed)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetailBatch>()
                .Property(e => e.OnOrder)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetailBatch>()
                .Property(e => e.IndividualItemQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetailBatch>()
                .Property(e => e.AllocatedForWO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationManagementDetailBatch>()
                .Property(e => e.InProductionQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_LocationQualifier>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_LocationTransaction>()
                .Property(e => e.Onhand)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_LocationTransaction>()
                .Property(e => e.TransactionQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_LocationTransaction>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_LocationTransaction>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_LocationTransaction>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_LockFeatureTypeName>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_LockTable>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_MarkForStore>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_MarkForStore>()
                .HasMany(e => e.DIO_CustomerMarkForStore)
                .WithRequired(e => e.DIO_MarkForStore)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_MarkForStore>()
                .HasMany(e => e.DIO_VendorMarkForStore)
                .WithRequired(e => e.DIO_MarkForStore)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_MasterBOL>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_MasterBOL>()
                .HasMany(e => e.DIO_ASNBOL)
                .WithOptional(e => e.DIO_MasterBOL)
                .HasForeignKey(e => e.MasterBOL);

            modelBuilder.Entity<DIO_MasterBOL>()
                .HasMany(e => e.DIO_BOLCarrierInfo)
                .WithOptional(e => e.DIO_MasterBOL)
                .HasForeignKey(e => e.BOLID);

            modelBuilder.Entity<DIO_MasterBOL>()
                .HasMany(e => e.DIO_BOLCustomerInfo)
                .WithOptional(e => e.DIO_MasterBOL)
                .HasForeignKey(e => e.BOLID);

            modelBuilder.Entity<DIO_MasterBOL>()
                .HasMany(e => e.DIO_MasterBOL1)
                .WithOptional(e => e.DIO_MasterBOL2)
                .HasForeignKey(e => e.MasterBOLID);

            modelBuilder.Entity<DIO_MasterEvent>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_MasterEventLineItem>()
                .Property(e => e.PickQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_MasterEventLineItem>()
                .Property(e => e.PickedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_MasterEventLineItem>()
                .Property(e => e.PackedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_MasterEventLineItem>()
                .Property(e => e.ShippedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_MasterEventLineItem>()
                .Property(e => e.ReturnQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_MasterEventLineItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_MasterEventSO>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_MasterEventSO>()
                .HasMany(e => e.DIO_MasterEventLineItem)
                .WithRequired(e => e.DIO_MasterEventSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_MasterItemFCL>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_MasterKit>()
                .Property(e => e.ItemCommissionRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_MasterKit>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_MasterKit>()
                .HasMany(e => e.DIO_KitDetail)
                .WithRequired(e => e.DIO_MasterKit)
                .HasForeignKey(e => e.MasterKitID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_MasterKit>()
                .HasMany(e => e.DIO_OpenPack)
                .WithRequired(e => e.DIO_MasterKit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_MasterKit>()
                .HasMany(e => e.DIO_PackItem)
                .WithRequired(e => e.DIO_MasterKit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ModelStock>()
                .Property(e => e.MinQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ModelStock>()
                .Property(e => e.MaxQty)
                .HasPrecision(18, 0);
        }

        private void AddEntity18(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_ModelStock>()
                .Property(e => e.MinCapacityQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ModelStock>()
                .Property(e => e.MaxCapacityQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ModelStock>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Module>()
                .HasMany(e => e.DIO_ModuleFile)
                .WithOptional(e => e.DIO_Module)
                .HasForeignKey(e => e.ModuleID);

            modelBuilder.Entity<DIO_ModuleFile>()
                .HasMany(e => e.DIO_ModuleFileBatch)
                .WithOptional(e => e.DIO_ModuleFile)
                .HasForeignKey(e => e.ModuleFileID);

            modelBuilder.Entity<DIO_nBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nBatchItem>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nBatchItem>()
                .Property(e => e.CountQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nBatchItem>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nBatchItem>()
                .Property(e => e.Difference)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nCustomerSO>()
                .HasMany(e => e.DIO_nSOAllocatedLocation)
                .WithOptional(e => e.DIO_nCustomerSO)
                .HasForeignKey(e => e.CustomerSO);

            modelBuilder.Entity<DIO_nInventoryLineItemBatch>()
                .Property(e => e.ShipmentQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nItemLocation>()
                .HasMany(e => e.DIO_nCustomerSO)
                .WithOptional(e => e.DIO_nItemLocation)
                .HasForeignKey(e => e.ItemLocation);

            modelBuilder.Entity<DIO_NonEDIImportExportTemplate>()
                .Property(e => e.LastFileNumber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_NonEDIImportExportTemplate>()
                .Property(e => e.FileNumberLength)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_NonEDIImportExportTemplate>()
                .HasMany(e => e.DIO_NonEDIExportDisplayField)
                .WithOptional(e => e.DIO_NonEDIImportExportTemplate)
                .HasForeignKey(e => e.NonEDIExportTemplate);

            modelBuilder.Entity<DIO_nSerial>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nSerial>()
                .Property(e => e.RequiredSerialQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nSerial>()
                .Property(e => e.RequiredSerialQuantityCurrentLevel)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_nSOAllocatedLocation>()
                .Property(e => e.AllocatingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OpenPack>()
                .Property(e => e.Onhand)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_OpenPack>()
                .Property(e => e.Allocated)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_OpenPack>()
                .Property(e => e.AvailableToOpen)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_OpenPack>()
                .Property(e => e.PackToBeOpened)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_OpenPack>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_OpenPack>()
                .HasMany(e => e.DIO_OpenPackBatch)
                .WithRequired(e => e.DIO_OpenPack)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_OpenPack>()
                .HasMany(e => e.DIO_OpenPackDetail)
                .WithRequired(e => e.DIO_OpenPack)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_OpenPack>()
                .HasMany(e => e.DIO_OpenPackSerial)
                .WithRequired(e => e.DIO_OpenPack)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_OpenPackBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_OpenPackBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_OpenPackDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_OpenPackDetail>()
                .Property(e => e.TotalQuantityOpened)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_OpenPackDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_OpenPackDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_OpenPackDetail>()
                .HasMany(e => e.DIO_OpenPackDetailSerial)
                .WithRequired(e => e.DIO_OpenPackDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_OpenPackDetailBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_OpenPackDetailBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_OpenPackDetailSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_OpenPackSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentCommission>()
                .Property(e => e.CommissionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentCommission>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.AllocationQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.CanceledQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.Size)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.MultPriceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.QtyLeftToRecieved)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.ItemOrderedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.InvoiceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.DropshipedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.GroceryPackWeigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.GroceryPackVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.QtyShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.QtyShippedBase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.QtyShippedByDropship)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.MasterKitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.MasterKitQtyShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.ChangedUnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.DiscountRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.TaxAfterDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.ItemChangedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.ItemCommissionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);
        }

        private void AddEntity19(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .Property(e => e.ItemACKQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetail>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentDetailAllowanceCharge)
                .WithOptional(e => e.DIO_OrderChangeAcknowledgmentDetail)
                .HasForeignKey(e => e.OrderChangeAcknowledgmentDetailID);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentDetailAllowanceCharge>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentFreight>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.OriginalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.TotalBeforeDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.TotalPaymentDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.TotalCommissionAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.RateFixPercentCommision)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.TermsDiscountPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .Property(e => e.TermsDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentCommission)
                .WithOptional(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .HasForeignKey(e => e.SONo);
        }

        private void AddEntity20(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentDetail)
                .WithOptional(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .HasForeignKey(e => e.OrderChangeAcknowledgmentHeader);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentFreight)
                .WithOptional(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .HasForeignKey(e => e.OrderChangeAcknowledgmentHeader);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeader>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge)
                .WithOptional(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .HasForeignKey(e => e.OrderChangeAcknowledgmentHeaderID);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeAcknowledgmentHeaderAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.OrderedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.MarkForStoreQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.POQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.PackSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.ExtendedLineAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.AvailableToShip)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.GroceryPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetail>()
                .HasMany(e => e.DIO_OrderChangeRequestDetailAllowanceCharge)
                .WithOptional(e => e.DIO_OrderChangeRequestDetail)
                .HasForeignKey(e => e.OrderChangeRequestDetailNo);

            modelBuilder.Entity<DIO_OrderChangeRequestDetailAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetailAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetailAllowanceCharge>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestDetailAllowanceCharge>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TotalExtendedLineAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TermDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TermDiscDaysDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TermDayOfMonth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .Property(e => e.PrePack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .HasMany(e => e.DIO_OrderChangeRequestDetail)
                .WithOptional(e => e.DIO_OrderChangeRequestHeader)
                .HasForeignKey(e => e.Header);

            modelBuilder.Entity<DIO_OrderChangeRequestHeader>()
                .HasMany(e => e.DIO_OrderChangeRequestHeaderAllowanceCharge)
                .WithOptional(e => e.DIO_OrderChangeRequestHeader)
                .HasForeignKey(e => e.OrderNo);

            modelBuilder.Entity<DIO_OrderChangeRequestHeaderAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderChangeRequestHeaderAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderStatusReport870Detail>()
                .Property(e => e.QtyShippedCanceled)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderStatusReport870Detail>()
                .Property(e => e.OrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderStatusReport870Detail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderStatusReport870Detail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderStatusReport870Detail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_OrderStatusReport870Detail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PackageType>()
                .Property(e => e.Length)
                .HasPrecision(19, 4);
        }

        private void AddEntity21(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_PackageType>()
                .Property(e => e.Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PackageType>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PackageType>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PackageType>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PackDetailItem>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PackDetailItemBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PackDetailPallet>()
                .HasMany(e => e.DIO_PackDetailCarton)
                .WithOptional(e => e.DIO_PackDetailPallet)
                .HasForeignKey(e => e.PackDetailPalletID);

            modelBuilder.Entity<DIO_PackItem>()
                .Property(e => e.MaximunPackQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItem>()
                .Property(e => e.PackQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItem>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PackItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PackItem>()
                .HasMany(e => e.DIO_PackItemBatch)
                .WithRequired(e => e.DIO_PackItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PackItem>()
                .HasMany(e => e.DIO_PackItemDetail)
                .WithRequired(e => e.DIO_PackItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PackItem>()
                .HasMany(e => e.DIO_PackItemSerial)
                .WithRequired(e => e.DIO_PackItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PackItemBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PackItemDetail>()
                .Property(e => e.QuantityPerPack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemDetail>()
                .Property(e => e.QuantityToPack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PackItemDetail>()
                .HasMany(e => e.DIO_PackItemDetailLocation)
                .WithRequired(e => e.DIO_PackItemDetail)
                .HasForeignKey(e => e.PackDetailItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PackItemDetailLocation>()
                .Property(e => e.Onhand)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemDetailLocation>()
                .Property(e => e.Allocated)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemDetailLocation>()
                .Property(e => e.AvailableToPack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemDetailLocation>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemDetailLocation>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PackItemDetailLocation>()
                .HasMany(e => e.DIO_PackItemDetailLocationSerial)
                .WithRequired(e => e.DIO_PackItemDetailLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PackItemDetailLocationBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PackItemDetailLocationBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PackItemDetailLocationSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PackItemSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ParaACKCompare>()
                .HasMany(e => e.DIO_ACKCompareInfors)
                .WithOptional(e => e.DIO_ParaACKCompare)
                .HasForeignKey(e => e.ParaACKCompareID);

            modelBuilder.Entity<DIO_PassCode>()
                .HasMany(e => e.DIO_PassCodePermission)
                .WithOptional(e => e.DIO_PassCode)
                .HasForeignKey(e => e.PassCodeID);

            modelBuilder.Entity<DIO_PastSaleInvoice>()
                .Property(e => e.TransactionNumber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PastSaleInvoice>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PastSaleInvoice>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PastSaleInvoice>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PaymentMethod>()
                .HasMany(e => e.DIO_CustomerPayment)
                .WithOptional(e => e.DIO_PaymentMethod)
                .HasForeignKey(e => e.PaymentMethod);

            modelBuilder.Entity<DIO_PaymentMethod>()
                .HasMany(e => e.DIO_CustomerStatement)
                .WithOptional(e => e.DIO_PaymentMethod)
                .HasForeignKey(e => e.PaymentMethod);

            modelBuilder.Entity<DIO_PaymentTerm>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PaymentTerm>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PickDetailCarton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PickDetailItem>()
                .Property(e => e.PickQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PickDetailItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PickDetailItem>()
                .Property(e => e.PackedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickDetailItem>()
                .Property(e => e.PackingQty)
                .HasPrecision(19, 4);
        }

        private void AddEntity22(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_PickDetailItem>()
                .HasMany(e => e.DIO_PickDetailItemBatch)
                .WithOptional(e => e.DIO_PickDetailItem)
                .HasForeignKey(e => e.PickDetailItemNo);

            modelBuilder.Entity<DIO_PickDetailItem>()
                .HasMany(e => e.DIO_PickDetailItemSerial)
                .WithOptional(e => e.DIO_PickDetailItem)
                .HasForeignKey(e => e.PickDetailItemNo);

            modelBuilder.Entity<DIO_PickDetailItemBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickDetailItemBatch>()
                .Property(e => e.PackedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickDetailPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PickHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PickHeader>()
                .HasMany(e => e.DIO_PickDetailBarcode)
                .WithOptional(e => e.DIO_PickHeader)
                .HasForeignKey(e => e.PickHeaderID);

            modelBuilder.Entity<DIO_PickHeader>()
                .HasMany(e => e.DIO_PickDetailCarton)
                .WithRequired(e => e.DIO_PickHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PickHeader>()
                .HasMany(e => e.DIO_PickDetailItem)
                .WithRequired(e => e.DIO_PickHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PickHeader>()
                .HasMany(e => e.DIO_PickDetailPallet)
                .WithRequired(e => e.DIO_PickHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PickHeader>()
                .HasMany(e => e.DIO_PickingProgress)
                .WithOptional(e => e.DIO_PickHeader)
                .HasForeignKey(e => e.PickHeaderNo);

            modelBuilder.Entity<DIO_PickHeader>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.DIO_PickHeader)
                .HasForeignKey(e => e.PickHeaderNo);

            modelBuilder.Entity<DIO_PickingList>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PickingList>()
                .HasMany(e => e.DIO_PickingListDetail)
                .WithRequired(e => e.DIO_PickingList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PickingListDetail>()
                .Property(e => e.Qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PickingListDetail>()
                .Property(e => e.PickedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PickingListDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PickingListDetail>()
                .Property(e => e.PackedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickingListDetail>()
                .Property(e => e.PickedIndividualQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickingListDetail>()
                .Property(e => e.PackingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickingListDetail>()
                .Property(e => e.PackingIndividualQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickingListDetail>()
                .Property(e => e.PackedIndividualQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickingListDetailBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickingListDetailBatch>()
                .Property(e => e.PickedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickingListDetailBatch>()
                .Property(e => e.PackedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PickingProgress>()
                .HasMany(e => e.DIO_PickDetailBarcode)
                .WithOptional(e => e.DIO_PickingProgress)
                .HasForeignKey(e => e.PickProgressID);

            modelBuilder.Entity<DIO_PIDeposit>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PIDeposit>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PODeposit>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PODeposit>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_PODetailAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PODetailAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PODetailAllowanceCharge>()
                .Property(e => e.Rate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PODetailAllowanceCharge>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PODetailAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_POFreight>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_POFreight>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_POHeaderAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_POHeaderAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_POHeaderAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_POInvoiceDetailAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_POInvoiceDetailAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_POInvoiceDetailAllowanceCharge>()
                .Property(e => e.Rate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_POInvoiceDetailAllowanceCharge>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_POInvoiceDetailAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_POInvoiceHeaderAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);
        }

        private void AddEntity23(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_POInvoiceHeaderAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_POInvoiceHeaderAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_POPIDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_POPIHeader>()
                .HasMany(e => e.DIO_POPIDetail)
                .WithOptional(e => e.DIO_POPIHeader)
                .HasForeignKey(e => e.POPIHeader);

            modelBuilder.Entity<DIO_POReceiptConfirmationHeader>()
                .Property(e => e.SizeInKB)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_POReceiptConfirmationHeader>()
                .HasMany(e => e.DIO_POReceiptConfirmationDetail)
                .WithOptional(e => e.DIO_POReceiptConfirmationHeader)
                .HasForeignKey(e => e.POReceiptConfirmationHeader);

            modelBuilder.Entity<DIO_POSODetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_POSOHeader>()
                .HasMany(e => e.DIO_POSODetail)
                .WithOptional(e => e.DIO_POSOHeader)
                .HasForeignKey(e => e.POSOHeader);

            modelBuilder.Entity<DIO_PrintTemplate>()
                .HasMany(e => e.DIO_PickDetailBarcode)
                .WithOptional(e => e.DIO_PrintTemplate)
                .HasForeignKey(e => e.PrintTemplateID);

            modelBuilder.Entity<DIO_PrintTemplate>()
                .HasMany(e => e.DIO_PrintTemplateHubVendor)
                .WithOptional(e => e.DIO_PrintTemplate)
                .HasForeignKey(e => e.PrintTempID);

            modelBuilder.Entity<DIO_ProductActivityDetail>()
                .HasMany(e => e.DIO_ProductActivityLineItem)
                .WithOptional(e => e.DIO_ProductActivityDetail)
                .HasForeignKey(e => e.ProductActivityDetail);

            modelBuilder.Entity<DIO_ProductActivityHeader>()
                .HasMany(e => e.DIO_ProductActivityDetail)
                .WithOptional(e => e.DIO_ProductActivityHeader)
                .HasForeignKey(e => e.ProductAcvityHeader);

            modelBuilder.Entity<DIO_ProductActivityLineItem>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductActivityLineItem>()
                .Property(e => e.UnitCostPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductActivityLineItem>()
                .Property(e => e.SpecialItemPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductActivityLineItem>()
                .Property(e => e.NetItemPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductActivityLineItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductActivityLineItem>()
                .Property(e => e.StoreQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductPostingGroup>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.DIO_ProductPostingGroup)
                .HasForeignKey(e => e.ProductPostingGroup);

            modelBuilder.Entity<DIO_ProductTransferResaleDetail>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductTransferResaleDetail>()
                .HasMany(e => e.DIO_ProductTransferResaleLineItem)
                .WithOptional(e => e.DIO_ProductTransferResaleDetail)
                .HasForeignKey(e => e.ProductTransferResaleDetail);

            modelBuilder.Entity<DIO_ProductTransferResaleHeader>()
                .HasMany(e => e.DIO_ProductTransferResaleDetail)
                .WithOptional(e => e.DIO_ProductTransferResaleHeader)
                .HasForeignKey(e => e.ProductTransferResaleHeader);

            modelBuilder.Entity<DIO_ProductTransferResaleLineItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductTransferResaleLineItem>()
                .Property(e => e.LineTotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProductTransferResaleLineItem>()
                .Property(e => e.SubmittedChargebackClaimAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProjectSales>()
                .Property(e => e.ProjectSalesQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProjectSales>()
                .Property(e => e.ProjectSalesQtyPerCustomerSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ProviderMethod>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PTSASN>()
                .Property(e => e.LadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PTSASN>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PTSASN>()
                .Property(e => e.Volume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PTSASN>()
                .Property(e => e.PalletLadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PTSASN>()
                .Property(e => e.ShipmentToTALASQ)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PTSASN>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PTSASNSO>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PTSASNSO>()
                .Property(e => e.SOLadingQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PTSASNSO>()
                .Property(e => e.SOLadingWeight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PTSASNSO>()
                .Property(e => e.SOLadingVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_PTSASNSOPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PTSCarton>()
                .Property(e => e.CartonQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PTSCarton>()
                .Property(e => e.FinishCartonQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PTSCarton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PTSCarton>()
                .HasMany(e => e.DIO_PickDetailCarton)
                .WithOptional(e => e.DIO_PTSCarton)
                .HasForeignKey(e => e.PTSCartonNo);

            modelBuilder.Entity<DIO_PTSCarton>()
                .HasMany(e => e.DIS_Carton)
                .WithOptional(e => e.DIO_PTSCarton)
                .HasForeignKey(e => e.PTSCartonNo);

            modelBuilder.Entity<DIO_PTSCarton>()
                .HasMany(e => e.DIO_PTSLineItem)
                .WithRequired(e => e.DIO_PTSCarton)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PTSLineItem>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PTSLineItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PTSLineItem>()
                .HasMany(e => e.DIO_PTSLineItemSerial)
                .WithRequired(e => e.DIO_PTSLineItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_PTSLineItemBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PTSLineItemBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PTSLineItemSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PurchaseInvoiceBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_PurchaseInvoiceBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PurchaseInvoiceSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_PurchaseTransitTime>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_QBClass>()
                .HasMany(e => e.DIO_QBClass1)
                .WithOptional(e => e.DIO_QBClass2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<DIO_QBClass>()
                .HasMany(e => e.DIS_Hub)
                .WithOptional(e => e.DIO_QBClass)
                .HasForeignKey(e => e.QBClassID);

            modelBuilder.Entity<DIO_QBClass>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.DIO_QBClass)
                .HasForeignKey(e => e.QBClass);

            modelBuilder.Entity<DIO_QBClass>()
                .HasMany(e => e.DIS_POHeader)
                .WithOptional(e => e.DIO_QBClass)
                .HasForeignKey(e => e.QBClassID);

            modelBuilder.Entity<DIO_QBClass>()
                .HasMany(e => e.DIS_SaleInvoiceHeader)
                .WithOptional(e => e.DIO_QBClass)
                .HasForeignKey(e => e.QBClassID);

            modelBuilder.Entity<DIO_QBClass>()
                .HasMany(e => e.DIS_SOHeader)
                .WithOptional(e => e.DIO_QBClass)
                .HasForeignKey(e => e.QBClassID);

            modelBuilder.Entity<DIO_QBClass>()
                .HasMany(e => e.DIS_Vendor)
                .WithOptional(e => e.DIO_QBClass)
                .HasForeignKey(e => e.QBClassID);

            modelBuilder.Entity<DIO_QBTemplate>()
                .HasMany(e => e.DIS_Hub)
                .WithOptional(e => e.DIO_QBTemplate)
                .HasForeignKey(e => e.QBSITemplateID);

            modelBuilder.Entity<DIO_QBTemplate>()
                .HasMany(e => e.DIS_Hub1)
                .WithOptional(e => e.DIO_QBTemplate1)
                .HasForeignKey(e => e.QBSOTemplateID);

            modelBuilder.Entity<DIO_QBTemplate>()
                .HasMany(e => e.DIS_Vendor)
                .WithOptional(e => e.DIO_QBTemplate)
                .HasForeignKey(e => e.QBTemplateID);

            modelBuilder.Entity<DIO_QuickBookAccount>()
                .HasMany(e => e.DIO_AdjustmentHeader)
                .WithOptional(e => e.DIO_QuickBookAccount)
                .HasForeignKey(e => e.QBAccountID);
        }

        private void AddEntity24(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_QuickBookAccount>()
                .HasMany(e => e.DIO_Discount)
                .WithOptional(e => e.DIO_QuickBookAccount)
                .HasForeignKey(e => e.QBAccountID);

            modelBuilder.Entity<DIO_QuickBookAccount>()
                .HasMany(e => e.DIO_OpenPack)
                .WithOptional(e => e.DIO_QuickBookAccount)
                .HasForeignKey(e => e.QBAccountID);

            modelBuilder.Entity<DIO_QuickBookAccount>()
                .HasMany(e => e.DIO_PackItem)
                .WithOptional(e => e.DIO_QuickBookAccount)
                .HasForeignKey(e => e.QBAccountID);

            modelBuilder.Entity<DIO_QuickBookAccount>()
                .HasMany(e => e.DIO_QuickBookAccount1)
                .WithOptional(e => e.DIO_QuickBookAccount2)
                .HasForeignKey(e => e.ParentAccountID);

            modelBuilder.Entity<DIO_QuickBookAccount>()
                .HasMany(e => e.DIO_ReasonAdjustment)
                .WithOptional(e => e.DIO_QuickBookAccount)
                .HasForeignKey(e => e.QBAccountID);

            modelBuilder.Entity<DIO_QuickBookAccount>()
                .HasMany(e => e.DIS_Hub)
                .WithOptional(e => e.DIO_QuickBookAccount)
                .HasForeignKey(e => e.QBAccountID);

            modelBuilder.Entity<DIO_QuickBookAccount>()
                .HasMany(e => e.DIS_Vendor)
                .WithOptional(e => e.DIO_QuickBookAccount)
                .HasForeignKey(e => e.QBAccountID);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TermDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TermDiscDaysDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TermDayOfMonth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowanceOrChargeAmount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowancePercent6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowanceOrChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowancePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowanceOrChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowancePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowanceOrChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowancePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowanceOrChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowancePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowanceOrChargeAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.AllowancePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.PrePack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.TotalExtendedLineAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860>()
                .Property(e => e.MarkForStoreQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.POQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.AvailableToShip)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.GroceryPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.ExtendedLineAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.GroceryPackWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.GroceryPackVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.MarkForStoreQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.PackSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.OrderedQty)
                .HasPrecision(19, 4);
        }

        private void AddEntity25(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeQty1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeQty2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.LineAllowanceOrChargeQty3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw860Detail>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943Header>()
                .Property(e => e.LadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943Header>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943Header>()
                .Property(e => e.PalletLadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943Header>()
                .Property(e => e.ShipmentTotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943Header>()
                .Property(e => e.TotalShippedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943LineItem>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943LineItem>()
                .Property(e => e.ShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943LineItem>()
                .Property(e => e.OrderedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943LineItem>()
                .Property(e => e.QtyShippedToDate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943LineItem>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943LineItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw943LineItem>()
                .Property(e => e.CommitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw947LineItem>()
                .Property(e => e.OnhandQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Raw947LineItem>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemAllowanceAmount1)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemAllowanceAmount2)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemAllowanceAmount3)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemAllowanceAmount4)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.LineItemAllowanceRate1)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.LineItemAllowanceRate2)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.LineItemAllowanceRate3)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.LineItemAllowanceRate4)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.LineItemAllowanceQty1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.LineItemAllowanceQty2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.LineItemAllowanceQty3)
                .HasPrecision(18, 0);
        }

        private void AddEntity26(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.LineItemAllowanceQty4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeAmount1)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargePercent1)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeAmount2)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargePercent2)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeAmount3)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargePercent3)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeAmount4)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargePercent4)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeRate1)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeRate2)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeRate3)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeRate4)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeQty1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeQty2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeQty3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawAllowanceChargePIDetail>()
                .Property(e => e.ItemChargeQty4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceChargeAmount1)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceChargeAmount2)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceChargeAmount3)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceChargeAmount4)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceChargeAmount5)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowanceAmount1)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowancePercent1)
                .IsFixedLength();

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowanceAmount2)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowancePercent2)
                .IsFixedLength();

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowanceAmount3)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowancePercent3)
                .IsFixedLength();

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowanceAmount4)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowancePercent4)
                .IsFixedLength();

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowanceAmount5)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowancePercent5)
                .IsFixedLength();

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowanceAmount6)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargePIHeader>()
                .Property(e => e.InvoiceAllowancePercent6)
                .IsFixedLength();

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemAllowanceAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemAllowanceAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemAllowanceAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemAllowanceAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.LineItemAllowanceRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.LineItemAllowanceRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.LineItemAllowanceRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.LineItemAllowanceRate4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.LineItemAllowanceQty1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.LineItemAllowanceQty2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.LineItemAllowanceQty3)
                .HasPrecision(19, 4);
        }

        private void AddEntity27(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.LineItemAllowanceQty4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeRate4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeQty1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeQty2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeQty3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIDetail>()
                .Property(e => e.ItemChargeQty4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargeAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceChargePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowancePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowancePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowancePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowancePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowancePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawAllowanceChargeSIHeader>()
                .Property(e => e.InvoiceAllowancePercent6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawASN>()
                .Property(e => e.LadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawASN>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawASN>()
                .Property(e => e.PalletLadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawASN>()
                .Property(e => e.ShipmentTotalVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawASN>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);
        }

        private void AddEntity28(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawASN>()
                .HasMany(e => e.DIO_RawASNPO)
                .WithRequired(e => e.DIO_RawASN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawASNPO>()
                .Property(e => e.POLadingVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawASNPO>()
                .Property(e => e.POLadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawASNPO>()
                .Property(e => e.POLadingWeight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawASNPO>()
                .HasMany(e => e.DIO_RawASNPOPallet)
                .WithRequired(e => e.DIO_RawASNPO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawASNSubLineItem>()
                .Property(e => e.SubLineItemQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawASNSubLineItem>()
                .Property(e => e.SubLineUnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceDetail>()
                .Property(e => e.ExtendedLineAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceDetail>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceDetail>()
                .Property(e => e.AdjustedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceDetail>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceHeader>()
                .Property(e => e.HashTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceHeader>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawInventoryAdviceHeader>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.TotalWeight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.ShippedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.OrderedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.QtyShippedToDate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.TotalVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity11)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice11)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity12)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice12)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity13)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice13)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity14)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice14)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity15)
                .HasPrecision(19, 4);
        }

        private void AddEntity29(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice15)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity16)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice16)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity17)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice17)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity18)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice18)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity19)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice19)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity20)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice20)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity22)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice22)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity23)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice23)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity24)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice24)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity25)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice25)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity26)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice26)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity27)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice27)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity28)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice28)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity29)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice29)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity31)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice31)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity32)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice32)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity33)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice33)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity34)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice34)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity35)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice35)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity36)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice36)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity37)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice37)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity38)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice38)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity39)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice39)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity40)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice40)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity41)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice41)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity42)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice42)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity43)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice43)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity44)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice44)
                .HasPrecision(19, 4);
        }

        private void AddEntity30(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity45)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice45)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity46)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice46)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity47)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice47)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity48)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice48)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity49)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice49)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineItemQuantity50)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .Property(e => e.SubLineUnitPrice50)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawLineItem>()
                .HasMany(e => e.DIO_RawASNSubLineItem)
                .WithOptional(e => e.DIO_RawLineItem)
                .HasForeignKey(e => e.RawLineItemID);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.ItemOrderedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.ItemChangedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.ChangedUnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.ItemTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.ItemACKQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentDetail>()
                .Property(e => e.QtyLeftToRecieved)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.TermsDiscountPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.TermsDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.AllowanceOrChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.AllowancePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.AllowanceOrChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.AllowancePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.AllowanceOrChargeAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.AllowancePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.AllowanceOrChargeAmount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.AllowancePercent6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.TotalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrderChangeAcknowledgmentHeader>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrgSOHeader>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrgSOHeader>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrgSOHeader>()
                .Property(e => e.LinePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawOrgSOHeader>()
                .Property(e => e.PrePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPallet>()
                .HasMany(e => e.DIO_RawASNPOPallet)
                .WithRequired(e => e.DIO_RawPallet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawPallet>()
                .HasMany(e => e.DIO_RawSOASNSOPallet)
                .WithRequired(e => e.DIO_RawPallet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.MultPriceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.Size)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.NoOfInnerPacks)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.QtyUnitOfMeasure)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.ExtendedLineAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineAllowanceOrChargePercent1)
                .HasPrecision(19, 4);
        }

        private void AddEntity31(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineAllowanceOrChargePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineAllowanceOrChargePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineAllowanceOrChargePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.LineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.GSTAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPODetail>()
                .Property(e => e.HSTSalesTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.TermDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.TermDiscDaysDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.TermDayOfMonth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowanceOrChargeAmount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowancePercent6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowanceOrChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowancePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowanceOrChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowancePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowanceOrChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowancePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowanceOrChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowancePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowanceOrChargeAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPOHeader>()
                .Property(e => e.AllowancePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.OriginalPOQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.InvoiceQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.QtyDifference)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ExtendLineAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemAllowanceAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemAllowancePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemAllowanceAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemAllowancePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemAllowanceAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemAllowancePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemAllowanceAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemAllowancePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.LineItemAllowanceRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.LineItemAllowanceRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.LineItemAllowanceRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.LineItemAllowanceRate4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.LineItemAllowanceQty1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.LineItemAllowanceQty2)
                .HasPrecision(19, 4);
        }

        private void AddEntity32(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.LineItemAllowanceQty3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.LineItemAllowanceQty4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemChargePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemChargePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemChargePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceDetail>()
                .Property(e => e.ItemChargePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalBeforeDiscount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalPaymentDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalPaymentAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TermDiscAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalBatchAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalInvAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalInvAmountSubjToTerms)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalInvAmountLessDiscount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalUnitShipped)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalWeight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.TotalNumberOfCase)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.NumberOfLineItem)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.GSTAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.HSTSalesTaxAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowanceAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowancePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowanceAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowancePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowanceAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowancePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowanceAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowancePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowanceAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowancePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowanceAmount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceAllowancePercent6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargeAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .Property(e => e.InvoiceChargePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .HasMany(e => e.DIO_RawAllowanceChargePIHeader)
                .WithRequired(e => e.DIO_RawPurchaseInvoiceHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawPurchaseInvoiceHeader>()
                .HasMany(e => e.DIO_RawPurchaseInvoiceDetail)
                .WithRequired(e => e.DIO_RawPurchaseInvoiceHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawRemittanceAdviceDetail>()
                .Property(e => e.INVCMNetAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawRemittanceAdviceDetail>()
                .Property(e => e.INVCMAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawRemittanceAdviceDetail>()
                .Property(e => e.INVCMDiscAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawRemittanceAdviceHeader>()
                .Property(e => e.CheckAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawRoutingInstructionDetail>()
                .Property(e => e.ScheduledQty)
                .HasPrecision(19, 4);
        }

        private void AddEntity33(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawRoutingInstructionDetail>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawRoutingInstructionDetail>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceDetail>()
                .Property(e => e.OriginalSOQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceDetail>()
                .Property(e => e.InvoiceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceDetail>()
                .Property(e => e.QtyDifference)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceDetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceDetail>()
                .Property(e => e.ExtendLineAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalBeforeDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalPaymentDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalPaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TermDiscAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalBatchAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalInvAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalInvAmountSubjToTerms)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalInvAmountLessDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalUnitShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.TotalNumberOfCase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.NumberOfLineItem)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.GSTAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSaleInvoiceHeader>()
                .Property(e => e.HSTSalesTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.PublishedPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.SuggestedRetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.MinimumQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.MaximumQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.MinimumOrderMultiple)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.Length)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.PackSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSalesCatalogHeader>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.OriginalSOQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.QtyInvoiced)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.QuantityDifference)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.InnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.PackSize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ExtendedLineAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemAllowanceAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemAllowancePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemAllowanceAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemAllowancePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemAllowanceAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemAllowancePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemAllowanceAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemAllowancePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.LineItemAllowanceRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.LineItemAllowanceRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.LineItemAllowanceRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.LineItemAllowanceRate4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.LineItemAllowanceQty1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.LineItemAllowanceQty2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.LineItemAllowanceQty3)
                .HasPrecision(19, 4);
        }

        private void AddEntity34(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.LineItemAllowanceQty4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemChargePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemChargePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemChargePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIDetail>()
                .Property(e => e.ItemChargePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalBacthAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TermsDiscPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TermsDiscAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalInvAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalInvAmountSubjToTerms)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalInvAmountLessDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargeAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargeAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalUnitShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.TotalNumberOfCases)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargeAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargeAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargeAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceChargePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowancePercent1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowancePercent2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowancePercent3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowancePercent4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowancePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowanceAmount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.InvoiceAllowancePercent6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.GSTAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSIHeader>()
                .Property(e => e.SalesTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.LadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.PalletLadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.ShipmentTotalVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.SOLadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.SOLadingWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.SOLadingVolumn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.TotalPOWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOASN>()
                .Property(e => e.TotalPOVolumn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOASN>()
                .HasMany(e => e.DIO_RawSOASNSO)
                .WithRequired(e => e.DIO_RawSOASN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawSOASNSO>()
                .Property(e => e.SOLadingVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOASNSO>()
                .Property(e => e.SOLadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSOASNSO>()
                .Property(e => e.SOLadingWeight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOASNSO>()
                .HasMany(e => e.DIO_RawSOASNSOPallet)
                .WithRequired(e => e.DIO_RawSOASNSO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.Qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);
        }

        private void AddEntity35(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.MultPriceQty)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.Size)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.Pack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.NoOfInnerPacks)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.QtyUnitOfMeasure)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.ExtendedLineAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount1)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent1)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount2)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent2)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount3)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent3)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount4)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent4)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate1)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate2)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate3)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate4)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemQuantity1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemQuantity2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemQuantity3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemQuantity4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.GSTAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.HSTSalesTaxAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.GroceryPackVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.GroceryPackWeigh)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemGroceryAllowanceRate5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.AvailabletoShipQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.ItemWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.ItemVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.ItemWidth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.ItemHeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.ItemDepth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.PriceMultiplier)
                .HasPrecision(19, 4);
        }

        private void AddEntity36(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeAmount10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargePercent10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeRate10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.LineAllowanceOrChargeQty10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSODetail>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TermDiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TermDiscDaysDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TermDayOfMonth)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount6)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent6)
                .HasPrecision(28, 2);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount1)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent1)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount2)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent2)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount3)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent3)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount4)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent4)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount5)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent5)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TotalDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TotalPOWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TotalPOVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.GSTAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.HSTTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.FreightTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.WarehouseTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent9)
                .HasPrecision(19, 4);
        }

        private void AddEntity37(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowanceOrChargeAmount10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.AllowancePercent10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.DiscountAmountHeader)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.TaxRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawSOHeader>()
                .HasMany(e => e.DIO_RawSODetail)
                .WithRequired(e => e.DIO_RawSOHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.MultPriceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.QtyUnitOfMeasure)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.InvoiceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.DropshipedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.GroceryPackWeigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.GroceryPackVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.QtyShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.QtyShippedByDropship)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.MasterKitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.MasterKitQtyShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.TaxAfterDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.ItemCommissionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.NoOfInnerPacks)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderDetail>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalPaymentDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TermDiscDayDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TermDiscAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalBeforeDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalCommissionAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.RateFixPercentCommision)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.NumberOfLineItem)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHShippingOrderHeader>()
                .Property(e => e.TotalShipmentWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.OpenQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.CancelQty)
                .HasPrecision(19, 4);
        }

        private void AddEntity38(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.OrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.ShipQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.ExchangeRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.PickQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.Extension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.OrderValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.DiscRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.Ratio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.OpenExtension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutDetail>()
                .Property(e => e.OpenValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Open_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Order_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Ship_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Exchange_Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Pick_Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Extension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Order_Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Disc_Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.Open_Extension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.OpenValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .Property(e => e.DiscRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RawWHStockOutHeader>()
                .HasMany(e => e.DIO_RawWHStockOutDetail)
                .WithOptional(e => e.DIO_RawWHStockOutHeader)
                .HasForeignKey(e => e.RawWHStockOutHeaderID);

            modelBuilder.Entity<DIO_ReadPOConfirmationHeader>()
                .Property(e => e.SizeInKB)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReadPOConfirmationHeader>()
                .HasMany(e => e.DIO_ReadPOConfirmationDetail)
                .WithOptional(e => e.DIO_ReadPOConfirmationHeader)
                .HasForeignKey(e => e.ReadPOConfirmationHeader);

            modelBuilder.Entity<DIO_ReasonAdjustment>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReceivingBatch>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingBatch>()
                .Property(e => e.WarehouseCount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingCartonItem>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingCartonItem>()
                .Property(e => e.ReceiveQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingCartonItemBatch>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingCartonItemBatch>()
                .Property(e => e.WarehouseCount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingCartonItemSerial>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingCartonItemSerial>()
                .Property(e => e.WarehouseCount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingItem>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingSerial>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReceivingSerial>()
                .Property(e => e.WarehouseCount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReplenishHeader>()
                .HasMany(e => e.DIO_ReplenishDetail)
                .WithOptional(e => e.DIO_ReplenishHeader)
                .HasForeignKey(e => e.ReplenishHeader);

            modelBuilder.Entity<DIO_ReportField>()
                .HasMany(e => e.DIO_HubReportField)
                .WithOptional(e => e.DIO_ReportField)
                .HasForeignKey(e => e.ReportField);

            modelBuilder.Entity<DIO_ReportField>()
                .HasMany(e => e.DIO_HubReportField1)
                .WithOptional(e => e.DIO_ReportField1)
                .HasForeignKey(e => e.ReportFieldID);

            modelBuilder.Entity<DIO_ReportName>()
                .HasMany(e => e.DIO_ReportFile)
                .WithOptional(e => e.DIO_ReportName)
                .HasForeignKey(e => e.ReportNameID);

            modelBuilder.Entity<DIO_ReportName>()
                .HasMany(e => e.DIO_SubReport)
                .WithOptional(e => e.DIO_ReportName)
                .HasForeignKey(e => e.ReportNameID);

            modelBuilder.Entity<DIO_RequestReferenceNumber>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReserveSerial>()
                .HasMany(e => e.DIO_nSerial)
                .WithOptional(e => e.DIO_ReserveSerial)
                .HasForeignKey(e => e.ReservedSerial);

            modelBuilder.Entity<DIO_ReturnReceipt>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReturnReceipt>()
                .HasMany(e => e.DIO_ReturnReceiptDetail)
                .WithRequired(e => e.DIO_ReturnReceipt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ReturnReceiptBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ReturnReceiptBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReturnReceiptDetail>()
                .Property(e => e.ReturnQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ReturnReceiptDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReturnReceiptDetail>()
                .HasMany(e => e.DIO_ReturnReceiptBatch)
                .WithRequired(e => e.DIO_ReturnReceiptDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ReturnReceiptDetail>()
                .HasMany(e => e.DIO_ReturnReceiptSerial)
                .WithRequired(e => e.DIO_ReturnReceiptDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ReturnReceiptSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReturnShipment>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReturnShipment>()
                .HasMany(e => e.DIO_ReturnShipmentDetail)
                .WithRequired(e => e.DIO_ReturnShipment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ReturnShipmentBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ReturnShipmentBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReturnShipmentDetail>()
                .Property(e => e.ReturnQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_ReturnShipmentDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ReturnShipmentDetail>()
                .Property(e => e.ReturnFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReturnShipmentDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_ReturnShipmentDetail>()
                .HasMany(e => e.DIO_ReturnShipmentBatch)
                .WithRequired(e => e.DIO_ReturnShipmentDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ReturnShipmentDetail>()
                .HasMany(e => e.DIO_ReturnShipmentSerial)
                .WithRequired(e => e.DIO_ReturnShipmentDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_ReturnShipmentSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_RoutingCodeType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_RoutingRequestDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RoutingRequestDetail>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RoutingRequestDetail>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_RoutingRequestDetail>()
                .Property(e => e.Ext_Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SaleInvoiceBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);
        }

        private void AddEntity39(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_SaleInvoiceBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SaleInvoiceSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SaleRep>()
                .HasMany(e => e.DIO_HubItemSaleRep)
                .WithOptional(e => e.DIO_SaleRep)
                .HasForeignKey(e => e.SaleRep);

            modelBuilder.Entity<DIO_SaleRep>()
                .HasMany(e => e.DIO_SaleRepSODetail)
                .WithOptional(e => e.DIO_SaleRep)
                .HasForeignKey(e => e.SaleRep);

            modelBuilder.Entity<DIO_SaleRepSODetail>()
                .Property(e => e.CommissionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SaleRepSODetail>()
                .Property(e => e.CommissionAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SaleRequirement>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SaleTransitTime>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SelectItemOTS_FIFO>()
                .Property(e => e.SelectedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_Serial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_AdjustmentSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_OpenPackDetailSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_OpenPackSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_PackDetailItemSerial)
                .WithOptional(e => e.DIO_Serial)
                .HasForeignKey(e => e.PackDetailSerialID);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_PackItemDetailLocationSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_PackItemSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_PTSLineItemSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_PurchaseInvoiceSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_ReturnReceiptSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_ReturnShipmentSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_SaleInvoiceSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_Serial1)
                .WithOptional(e => e.DIO_Serial2)
                .HasForeignKey(e => e.Parent);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_StockInSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_StockOutSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_Serial>()
                .HasMany(e => e.DIO_TransferSerial)
                .WithRequired(e => e.DIO_Serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_SerialConfiguration>()
                .Property(e => e.LastNumber)
                .HasPrecision(10, 0);

            modelBuilder.Entity<DIO_SerialConfiguration>()
                .Property(e => e.MaxNumber)
                .HasPrecision(10, 0);

            modelBuilder.Entity<DIO_SerialConfiguration>()
                .Property(e => e.IncrementNumber)
                .HasPrecision(10, 0);

            modelBuilder.Entity<DIO_ServiceProviderMethod>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ServiceProviderMethod>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentDetail)
                .WithOptional(e => e.DIO_ServiceProviderMethod)
                .HasForeignKey(e => e.ShippingSpeed);

            modelBuilder.Entity<DIO_ServiceProviderMethod>()
                .HasMany(e => e.DIO_WHShippingOrderDetail)
                .WithOptional(e => e.DIO_ServiceProviderMethod)
                .HasForeignKey(e => e.ShippingSpeed);

            modelBuilder.Entity<DIO_ServiceProviderMethod>()
                .HasMany(e => e.DIS_SODetail)
                .WithOptional(e => e.DIO_ServiceProviderMethod)
                .HasForeignKey(e => e.ShippingSpeed);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_ACKSOHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_ACKSOHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketPOHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketPOHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketPOHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketPOHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.StoreNo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketSOHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketSOHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketSOHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketSOHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_BlanketSOHeader4)
                .WithOptional(e => e.DIO_ShippingInfo4)
                .HasForeignKey(e => e.StoreNo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_ERP_Store)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.StoreNo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_MasterBOL)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_MasterBOL1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipFromID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_MasterBOL2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.FreightBillToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.HubShippingInfoShipTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShippingInfoBillTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShippingInfoMarkForStoreNo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader4)
                .WithOptional(e => e.DIO_ShippingInfo4)
                .HasForeignKey(e => e.ShippingInfoShipFrom);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeRequestDetail)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ManufactureAddress);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeRequestDetail1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.MarkForStore);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.BuyerAddress);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ManufactureAddress);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.MarkForStore);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader4)
                .WithOptional(e => e.DIO_ShippingInfo4)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader5)
                .WithOptional(e => e.DIO_ShippingInfo5)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderStatusReport870Header)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_OrderStatusReport870Header1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_ProductActivityHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_ProductActivityHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_PTSASN)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.RemitToAddressID);
        }

        private void AddEntity40(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_PTSASN1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.BillToAddressID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_PTSASN2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipFromAddressID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_PTSASN3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipToAddressID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_PurchaseTransitTime)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_Raw943Header)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_Raw943Header1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipToAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_RawOrderChangeAcknowledgmentHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_RawOrderChangeAcknowledgmentHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShippingInfoBillTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_RawOrderChangeAcknowledgmentHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShippingInfoMarkForStore);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_RawOrderChangeAcknowledgmentHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipToAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_ReturnReceipt)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_ReturnShipment)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_SaleTransitTime)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_SaleTransitTime1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHRecipientNoticeHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShippingInfoID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHShippingOrderHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHShippingOrderHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHShippingOrderHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShippingInfoBillTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHShippingOrderHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHShippingOrderHeader4)
                .WithOptional(e => e.DIO_ShippingInfo4)
                .HasForeignKey(e => e.StoreNo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.RemitToAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipFromAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipToAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePalletPO)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePalletPO1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.MarkForStoreId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePO)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePO1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.MarkForStoreId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.RemitToAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipFromAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipToAddressId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTShipmentAdvicePalletPO)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTShipmentAdvicePalletPO1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.MarkForStoreId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTShipmentAdvicePO)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WSTShipmentAdvicePO1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.MarkForStoreId);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_Hub)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.HubShippingInfo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_POHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_POHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SaleInvoiceHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFrom);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SOHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.FreightBillToID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.BillToAddressID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_ASN1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.RemitToAddressID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_ASN2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipFromAddressID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_ASN3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipToAddressID);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_POHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.BillToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_POHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.StoreNo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SaleInvoiceHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.RemitTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SaleInvoiceHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.BillTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SaleInvoiceHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipTo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SOHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.BillToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SOHeader2)
                .WithOptional(e => e.DIO_ShippingInfo2)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SOHeader3)
                .WithOptional(e => e.DIO_ShippingInfo3)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIS_SOHeader4)
                .WithOptional(e => e.DIO_ShippingInfo4)
                .HasForeignKey(e => e.StoreNo);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHOrderHeader)
                .WithOptional(e => e.DIO_ShippingInfo)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_ShippingInfo>()
                .HasMany(e => e.DIO_WHOrderHeader1)
                .WithOptional(e => e.DIO_ShippingInfo1)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIO_ShipToQualifier>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader)
                .WithOptional(e => e.DIO_ShipToQualifier)
                .HasForeignKey(e => e.ShipToQualifier);

            modelBuilder.Entity<DIO_SISODetail>()
                .Property(e => e.InvoicedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SizeRun>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_SizeRun>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SOCommission>()
                .Property(e => e.CommissionRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SOCommission>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SODetailAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);
        }

        private void AddEntity41(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_SODetailAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SODetailAllowanceCharge>()
                .Property(e => e.Rate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SODetailAllowanceCharge>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_SODetailAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SODetailPackage>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SODetailPackage>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SOFreight>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SOFreight>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SOHeaderAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SOHeaderAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SOHeaderAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SOInvoiceDetailAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SOInvoiceDetailAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SOInvoiceDetailAllowanceCharge>()
                .Property(e => e.Rate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SOInvoiceDetailAllowanceCharge>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_SOInvoiceDetailAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SOInvoiceHeaderAllowanceCharge>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SOInvoiceHeaderAllowanceCharge>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SOInvoiceHeaderAllowanceCharge>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_SpecialHandling>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_State>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_State>()
                .HasMany(e => e.DIO_CustomerRoutingDetail)
                .WithOptional(e => e.DIO_State)
                .HasForeignKey(e => e.ShipFromStateID);

            modelBuilder.Entity<DIO_State>()
                .HasMany(e => e.DIO_CustomerRoutingDetail1)
                .WithOptional(e => e.DIO_State1)
                .HasForeignKey(e => e.ShipToStateID);

            modelBuilder.Entity<DIO_StatusCode>()
                .Property(e => e.StatusCode)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_StatusCode>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_StockInBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_StockInBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_StockInExpenditure>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_StockInExpenditure>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_StockInFreight>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_StockInFreight>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_StockInSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_StockOutBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_StockOutBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_StockOutBatch>()
                .Property(e => e.TmpReturnedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_StockOutBatch>()
                .Property(e => e.ReturnedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_StockOutSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Style>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Style>()
                .HasMany(e => e.DIO_Style1)
                .WithOptional(e => e.DIO_Style2)
                .HasForeignKey(e => e.GlobalStyle);

            modelBuilder.Entity<DIO_Style>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.DIO_Style)
                .HasForeignKey(e => e.GlobalStyle);

            modelBuilder.Entity<DIO_SubLineItem>()
                .Property(e => e.SubLineItemQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SubLineItem>()
                .Property(e => e.SubLineUnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SuggestionPrice>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SuggestionPrice>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SuggestionPrice>()
                .Property(e => e.MSRP)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_SuggestionPrice>()
                .Property(e => e.WholeSalePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_SuggestionPrice>()
                .Property(e => e.WholeSalesPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_TableImport>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Tax>()
                .Property(e => e.TaxRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_Tax>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_Tax>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .WithOptional(e => e.DIO_Tax)
                .HasForeignKey(e => e.FixTaxID);

            modelBuilder.Entity<DIO_Tax>()
                .HasMany(e => e.DIO_TaxGroup)
                .WithOptional(e => e.DIO_Tax)
                .HasForeignKey(e => e.ChildTax);

            modelBuilder.Entity<DIO_Tax>()
                .HasMany(e => e.DIO_TaxGroup1)
                .WithOptional(e => e.DIO_Tax1)
                .HasForeignKey(e => e.ParentTax);

            modelBuilder.Entity<DIO_Tax>()
                .HasMany(e => e.DIS_POHeader)
                .WithOptional(e => e.DIO_Tax)
                .HasForeignKey(e => e.FixTaxID);

            modelBuilder.Entity<DIO_Tax>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader)
                .WithOptional(e => e.DIO_Tax)
                .HasForeignKey(e => e.FixTaxID);

            modelBuilder.Entity<DIO_Tax>()
                .HasMany(e => e.DIS_SaleInvoiceHeader)
                .WithOptional(e => e.DIO_Tax)
                .HasForeignKey(e => e.FixTaxID);

            modelBuilder.Entity<DIO_Tax>()
                .HasMany(e => e.DIS_SOHeader)
                .WithOptional(e => e.DIO_Tax)
                .HasForeignKey(e => e.FixTaxID);

            modelBuilder.Entity<DIO_TermBasisDate>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TermsType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_ThirdPartyLogistic>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TrackingOrderStatusDetail>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_TrackingOrderStatusHeader>()
                .HasMany(e => e.DIO_TrackingOrderStatusDetail)
                .WithOptional(e => e.DIO_TrackingOrderStatusHeader)
                .HasForeignKey(e => e.C_TrackingOrderStatusHeaderNo);

            modelBuilder.Entity<DIO_TrackingTransactionTypeDetailProperty>()
                .HasMany(e => e.DIO_TrackingTransactionTypeDetailPropertySample)
                .WithOptional(e => e.DIO_TrackingTransactionTypeDetailProperty)
                .HasForeignKey(e => e.TrackingTransactionTypeDetailPropertyID);

            modelBuilder.Entity<DIO_TrackingTransactionTypeHeader>()
                .HasMany(e => e.DIO_TrackingInfoHeader)
                .WithOptional(e => e.DIO_TrackingTransactionTypeHeader)
                .HasForeignKey(e => e.TrackingTransactionTypeHeaderID);

            modelBuilder.Entity<DIO_TrackingTransactionTypeHeader>()
                .HasMany(e => e.DIO_TrackingTransactionTypeDetail)
                .WithOptional(e => e.DIO_TrackingTransactionTypeHeader)
                .HasForeignKey(e => e.TrackingTransactionTypeHeaderID);

            modelBuilder.Entity<DIO_TransactionSetPurpose>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransferBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_TransferBatch>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransferCarton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransferDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_TransferDetail>()
                .Property(e => e.QtyBase)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_TransferDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_TransferDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);
        }

        private void AddEntity42(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_TransferDetail>()
                .HasMany(e => e.DIO_TransferBatch)
                .WithRequired(e => e.DIO_TransferDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_TransferDetail>()
                .HasMany(e => e.DIO_TransferSerial)
                .WithRequired(e => e.DIO_TransferDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_TransferDocumentDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_TransferDocumentDetail>()
                .Property(e => e.QtyBase)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_TransferDocumentDetail>()
                .Property(e => e.TransferedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_TransferDocumentDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_TransferDocumentDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransferDocumentDetail>()
                .Property(e => e.StockInQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_TransferDocumentDetail>()
                .Property(e => e.StockOutQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_TransferDocumentDetail>()
                .HasMany(e => e.DIO_TransferDocumentLineDetail)
                .WithOptional(e => e.DIO_TransferDocumentDetail)
                .HasForeignKey(e => e.TransferDocumentDetail);

            modelBuilder.Entity<DIO_TransferDocumentHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransferDocumentHeader>()
                .HasMany(e => e.DIO_TransferDocumentDetail)
                .WithRequired(e => e.DIO_TransferDocumentHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_TransferDocumentHeader>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader)
                .WithOptional(e => e.DIO_TransferDocumentHeader)
                .HasForeignKey(e => e.TransferDocument);

            modelBuilder.Entity<DIO_TransferDocumentLineDetail>()
                .Property(e => e.ReceivedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_TransferDocumentLineDetail>()
                .Property(e => e.ShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_TransferHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransferHeader>()
                .HasMany(e => e.DIO_TransferCarton)
                .WithRequired(e => e.DIO_TransferHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_TransferHeader>()
                .HasMany(e => e.DIO_TransferDetail)
                .WithRequired(e => e.DIO_TransferHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_TransferHeader>()
                .HasMany(e => e.DIO_TransferPallet)
                .WithRequired(e => e.DIO_TransferHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_TransferPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransferSerial>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransportationMethod>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransportationMethod>()
                .HasMany(e => e.DIO_Raw943Header)
                .WithOptional(e => e.DIO_TransportationMethod)
                .HasForeignKey(e => e.TransportMethodId);

            modelBuilder.Entity<DIO_TransportationMethod>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader)
                .WithOptional(e => e.DIO_TransportationMethod)
                .HasForeignKey(e => e.TransportMethodID);

            modelBuilder.Entity<DIO_TransportationMethod>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader)
                .WithOptional(e => e.DIO_TransportationMethod)
                .HasForeignKey(e => e.TransportMethodId);

            modelBuilder.Entity<DIO_TransportationMethod>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader)
                .WithOptional(e => e.DIO_TransportationMethod)
                .HasForeignKey(e => e.TransportMethodId);

            modelBuilder.Entity<DIO_TransportationMethod>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.DIO_TransportationMethod)
                .HasForeignKey(e => e.TransportMethodID);

            modelBuilder.Entity<DIO_TransportationMethod>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.DIO_TransportationMethod)
                .HasForeignKey(e => e.TransportationMethod);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIO_AppointmentSecurityLog)
                .WithOptional(e => e.DIO_TransportationProvider)
                .HasForeignKey(e => e.CarrierID);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIO_CarrierInfo)
                .WithOptional(e => e.DIO_TransportationProvider)
                .HasForeignKey(e => e.Carrier);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIO_CustomerRoutingDetail)
                .WithOptional(e => e.DIO_TransportationProvider)
                .HasForeignKey(e => e.CarrierID);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIO_ERP_TransportationProvider)
                .WithRequired(e => e.DIO_TransportationProvider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIO_OrderStatusReport870Detail)
                .WithOptional(e => e.DIO_TransportationProvider)
                .HasForeignKey(e => e.ProviderID);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader)
                .WithOptional(e => e.DIO_TransportationProvider)
                .HasForeignKey(e => e.CarrierID);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader)
                .WithOptional(e => e.DIO_TransportationProvider)
                .HasForeignKey(e => e.ProviderId);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader)
                .WithOptional(e => e.DIO_TransportationProvider)
                .HasForeignKey(e => e.ProviderId);

            modelBuilder.Entity<DIO_TransportationProvider>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.DIO_TransportationProvider)
                .HasForeignKey(e => e.ProviderID);

            modelBuilder.Entity<DIO_TypeOfService>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_TypeOfService>()
                .Property(e => e.MinShipWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_TypeOfService>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.DIO_TypeOfService)
                .HasForeignKey(e => e.TypeOfService);

            modelBuilder.Entity<DIO_TypeOfService>()
                .HasMany(e => e.DIS_POHeader)
                .WithOptional(e => e.DIO_TypeOfService)
                .HasForeignKey(e => e.TypeOfService);

            modelBuilder.Entity<DIO_UOMSet>()
                .HasMany(e => e.DIS_SaleInvoiceDetail)
                .WithOptional(e => e.DIO_UOMSet)
                .HasForeignKey(e => e.UOMSetID);

            modelBuilder.Entity<DIO_UOMSet>()
                .HasMany(e => e.DIS_SODetail)
                .WithOptional(e => e.DIO_UOMSet)
                .HasForeignKey(e => e.UOMSetID);

            modelBuilder.Entity<DIO_UOMSet>()
                .HasMany(e => e.DIS_UOMConversion)
                .WithOptional(e => e.DIO_UOMSet)
                .HasForeignKey(e => e.UOMSetID);

            modelBuilder.Entity<DIO_UPSPackageType>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.DIO_UPSPackageType)
                .HasForeignKey(e => e.UPSPackageType);

            modelBuilder.Entity<DIO_VendorContactInfo>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_VendorFreight>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_VendorFreight>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_VendorItemMasterItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_VendorLedgerEntry>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<DIO_VendorLedgerEntry>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_VendorLedgerEntry>()
                .Property(e => e.Debit)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_VendorLedgerEntry>()
                .Property(e => e.Credit)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_VendorMarkForStore>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_VendorPaymentDetail>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_VendorPaymentDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_VendorPostingGroup>()
                .Property(e => e.UpdateDate)
                .IsFixedLength();

            modelBuilder.Entity<DIO_VendorPostingGroup>()
                .HasMany(e => e.DIO_VendorLedgerEntry)
                .WithRequired(e => e.DIO_VendorPostingGroup)
                .HasForeignKey(e => e.VendorPostingGroupCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_VendorShippingInfo>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_VendorShippingInfo>()
                .HasMany(e => e.DIO_PurchaseTransitTime)
                .WithOptional(e => e.DIO_VendorShippingInfo)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIO_VendorStatement>()
                .Property(e => e.DebitAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_VendorStatement>()
                .Property(e => e.CreditAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_VendorStatement>()
                .Property(e => e.Balance)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_VendorStatement>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_VendorStatement>()
                .HasMany(e => e.DIO_VendorPaymentDetail)
                .WithOptional(e => e.DIO_VendorStatement)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DIO_WarehouseAllocatedSO>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WarehouseAllocatedSO>()
                .Property(e => e.RequestQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WarehouseInPool>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WarehouseInventoryAdjustment>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WarehouseReceipt>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WarehouseShipmentReport>()
                .Property(e => e.FreightCharges)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WarehouseShipmentReport>()
                .Property(e => e.ContainerQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WarehouseShipmentReport>()
                .Property(e => e.UnitPerCase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WarehouseType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WeightUOM>()
                .Property(e => e.WeightRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WeightUOM>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WH947LineItem>()
                .Property(e => e.OnhandQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WH947LineItem>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WH947LineItem>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHOrderDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHOrderDetail>()
                .Property(e => e.StockOutQty)
                .HasPrecision(18, 0);

        }

        private void AddEntity43(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_WHOrderDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WHOrderDetail>()
                .Property(e => e.PackedToShipQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHOrderDetail>()
                .Property(e => e.TempPackedToShipQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHOrderDetail>()
                .HasMany(e => e.DIO_SelectItemOTS_FIFO)
                .WithOptional(e => e.DIO_WHOrderDetail)
                .HasForeignKey(e => e.dioWHOrderDetail);

            modelBuilder.Entity<DIO_WHOrderDetailBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHOrderDetailBatch>()
                .Property(e => e.StockOutQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHOrderHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WHOrderHeader>()
                .HasMany(e => e.DIO_PTSCarton)
                .WithRequired(e => e.DIO_WHOrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHOrderHeader>()
                .HasMany(e => e.DIO_WHOrderDetail)
                .WithRequired(e => e.DIO_WHOrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHRecipientNoticeDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHRecipientNoticeDetail>()
                .Property(e => e.StockInQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHRecipientNoticeDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WHRecipientNoticeDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHRecipientNoticeDetail>()
                .Property(e => e.OrderedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHRecipientNoticeHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WHRecipientNoticeHeader>()
                .Property(e => e.TotalQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHRecipientNoticeHeader>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHRecipientNoticeHeader>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHRecipientNoticeHeader>()
                .HasMany(e => e.DIO_WHRecipientNoticeDetail)
                .WithRequired(e => e.DIO_WHRecipientNoticeHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHShipAdvDRaw>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShipAdvDRaw>()
                .Property(e => e.QtyOrdered)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShipAdvDRaw>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShipAdvDRaw>()
                .Property(e => e.ShippedQtyLot)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShipAdvDRaw>()
                .Property(e => e.QtyDiff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShipAdvHRaw>()
                .Property(e => e.TotalQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShipAdvHRaw>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShipAdvHRaw>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShipAdvHRaw>()
                .Property(e => e.TotalLadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.OrderQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.ShippedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.ShipmentQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.NPSelectedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.PalletLadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.ShipWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.OrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.QtyDiff)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.QtyOrdered)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetail>()
                .Property(e => e.ShippedQtyLot)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceDetailBatch>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceHeader>()
                .Property(e => e.TotalQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceHeader>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceHeader>()
                .Property(e => e.TotalLadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceHeader>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingAdviceHeader>()
                .HasMany(e => e.DIO_WHShippingAdviceDetail)
                .WithOptional(e => e.DIO_WHShippingAdviceHeader)
                .HasForeignKey(e => e.WHShippingAdviceHeaderID);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.InnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.ShippedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.GroceryPackWeigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.GroceryPackVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.ShippingQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SOShippedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderDetail>()
                .Property(e => e.SOOriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.TermDiscDayDue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.TermDiscAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.RateFixPercentCommision)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.TotalOrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.TotalShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.TotalShipmentWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHShippingOrderHeader>()
                .Property(e => e.TotalOrderAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockIn>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockIn>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockIn>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WHStockIn>()
                .Property(e => e.TotalQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockIn>()
                .HasMany(e => e.DIO_ReturnReceipt)
                .WithRequired(e => e.DIO_WHStockIn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHStockIn>()
                .HasMany(e => e.DIO_StockInFreight)
                .WithRequired(e => e.DIO_WHStockIn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHStockIn>()
                .HasMany(e => e.DIO_WHStockInDetail)
                .WithRequired(e => e.DIO_WHStockIn)
                .WillCascadeOnDelete(false);
        }

        private void AddEntity44(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.ReturnQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.CustomsAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.ExpenditureAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.DistributedAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.WarehouseCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.DiscountRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.ItemPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .Property(e => e.STTotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockInDetail>()
                .HasMany(e => e.DIO_StockInSerial)
                .WithRequired(e => e.DIO_WHStockInDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHStockOut>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WHStockOut>()
                .Property(e => e.ShippedValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockOut>()
                .Property(e => e.HandlingCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockOut>()
                .Property(e => e.ShippingCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockOut>()
                .Property(e => e.OtherCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockOut>()
                .HasMany(e => e.DIO_ReturnShipment)
                .WithRequired(e => e.DIO_WHStockOut)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHStockOut>()
                .HasMany(e => e.DIS_ASN1)
                .WithOptional(e => e.DIO_WHStockOut1)
                .HasForeignKey(e => e.STShipmentID);

            modelBuilder.Entity<DIO_WHStockOut>()
                .HasMany(e => e.DIO_WHStockOutDetail)
                .WithRequired(e => e.DIO_WHStockOut)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHStockOutDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHStockOutDetail>()
                .Property(e => e.ReturnQuantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIO_WHStockOutDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_WHStockOutDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockOutDetail>()
                .Property(e => e.ShippedValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockOutDetail>()
                .Property(e => e.TempReturnedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHStockOutDetail>()
                .HasMany(e => e.DIO_StockOutSerial)
                .WithRequired(e => e.DIO_WHStockOutDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceHeader>()
                .Property(e => e.TotalQuantityReceived)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceHeader>()
                .Property(e => e.TotalCartons)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceHeader>()
                .Property(e => e.TotalLineNumber)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamaged)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamagedUnitType)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyshippedfortheLot_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyshippedfortheLot_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyshippedfortheLot_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyshippedfortheLot_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamaged1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamagedUnitType1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamaged2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamagedUnitType2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamaged3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamagedUnitType3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamaged4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamagedUnitType4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamaged5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.QtyDamagedUnitType5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.InnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.Cartons)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItem>()
                .Property(e => e.LineItemNumbers)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItemBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WHSTRawReceiptAdviceLineItemBatch>()
                .Property(e => e.CartonQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WorkOrder>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WorkOrder>()
                .Property(e => e.ActualQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WorkOrder>()
                .HasMany(e => e.DIO_WorkOrder1)
                .WithOptional(e => e.DIO_WorkOrder2)
                .HasForeignKey(e => e.WorkOrderParentID);

            modelBuilder.Entity<DIO_WorkOrderDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WorkOrderDetails>()
                .Property(e => e.ActualQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WorkOrderDetails_Location>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WorkOrderInBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceCarton>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceCarton>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceCarton>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceCarton>()
                .Property(e => e.FreightCharges)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceCarton>()
                .Property(e => e.HandlingCharges)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceCarton>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem)
                .WithOptional(e => e.DIO_WSTReceiptAdviceCarton)
                .HasForeignKey(e => e.ReceiptAdviceCartonId);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.LadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.WeightUOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.CalculatedWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.VolumeUOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.ReceiptTotalUnitShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.FreightChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .Property(e => e.TotalReceivedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .HasMany(e => e.DIO_WSTReceiptAdviceCarton)
                .WithOptional(e => e.DIO_WSTReceiptAdviceHeader)
                .HasForeignKey(e => e.ReceiptAdviceHeaderId);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePallet)
                .WithOptional(e => e.DIO_WSTReceiptAdviceHeader)
                .HasForeignKey(e => e.ReceiptAdviceHeaderId);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePO)
                .WithOptional(e => e.DIO_WSTReceiptAdviceHeader)
                .HasForeignKey(e => e.ReceiptAdviceHeaderId);

            modelBuilder.Entity<DIO_WSTReceiptAdviceHeader>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader1)
                .WithOptional(e => e.DIO_WSTReceiptAdviceHeader1)
                .HasForeignKey(e => e.WarehouseReceiptAdviceID);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.Length)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.OrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.CommitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.PackedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.InvoiceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.ReceivedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.OriginalQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.ShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.QtyShippedToDate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.UPSWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.UPSHeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.UPSLength)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.UPSWidth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.CommitUOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.UOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.InnerPack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.TotalCartons)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.TotalQuantityReceived)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .Property(e => e.TotalUnitsShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItemBatch)
                .WithOptional(e => e.DIO_WSTReceiptAdviceLineItem)
                .HasForeignKey(e => e.ReceiptAdviceLineItemId);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItemDetail)
                .WithOptional(e => e.DIO_WSTReceiptAdviceLineItem)
                .HasForeignKey(e => e.ReceiptAdviceLineItemId);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItem>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItemSerial)
                .WithOptional(e => e.DIO_WSTReceiptAdviceLineItem)
                .HasForeignKey(e => e.ReceiptAdviceLineItemId);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItemBatch>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTReceiptAdviceLineItemDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceCarton>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceCarton>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceCarton>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceCarton>()
                .Property(e => e.FreightCharges)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceCarton>()
                .Property(e => e.HandlingCharges)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceCarton>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItem)
                .WithOptional(e => e.DIO_WSTShipmentAdviceCarton)
                .HasForeignKey(e => e.ShipmentAdviceCartonId);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.LadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.WeightUOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.CalculatedWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.VolumeUOMRate)
                .HasPrecision(19, 4);
        }

        private void AddEntity45(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.ShipmentTotalUnitShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.FreightChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .Property(e => e.TotalShippedQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader)
                .WithOptional(e => e.DIO_WSTShipmentAdviceHeader)
                .HasForeignKey(e => e.ShipmentID);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.DIO_WSTShipmentAdviceHeader)
                .HasForeignKey(e => e.WHShipmentAdviceID);

            modelBuilder.Entity<DIO_WSTShipmentAdviceHeader>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader)
                .WithOptional(e => e.DIO_WSTShipmentAdviceHeader)
                .HasForeignKey(e => e.WarehouseShipmentAdviceID);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.Length)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.OrderQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.CommitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.PackedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.InvoiceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.ReceivedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.ReceivingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.TmpReceivedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.ShippedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.QtyShippedToDate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.UPSWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.UPSHeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.UPSLength)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.UPSWidth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.CommitUOMRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .Property(e => e.TotalCarton)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItemBatch)
                .WithOptional(e => e.DIO_WSTShipmentAdviceLineItem)
                .HasForeignKey(e => e.ShipmentAdviceLineItemId);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItemDetail)
                .WithOptional(e => e.DIO_WSTShipmentAdviceLineItem)
                .HasForeignKey(e => e.ShipmentAdviceLineItemId);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItem>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItemSerial)
                .WithOptional(e => e.DIO_WSTShipmentAdviceLineItem)
                .HasForeignKey(e => e.ShipmentAdviceLineItemId);

            modelBuilder.Entity<DIO_WSTShipmentAdviceLineItemDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIO_XPObjectWeakRelationShip>()
                .Property(e => e.ParentAssemblyFullName)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_XPObjectWeakRelationShip>()
                .Property(e => e.ChildAssemblyFullName)
                .IsUnicode(false);

            modelBuilder.Entity<DIO_XPObjectWeakRelationShip>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIOW_LocationItemPars>()
                .Property(e => e.Restock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIOW_LocationItemPars>()
                .Property(e => e.MaxCapacity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIOW_LocationItemPars>()
                .Property(e => e.ModelStock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_Action>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Action>()
                .HasMany(e => e.DIS_EventExpressionAction)
                .WithRequired(e => e.DIS_Action)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_ActionType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ActionType>()
                .HasMany(e => e.DIS_Action)
                .WithRequired(e => e.DIS_ActionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_ActionType>()
                .HasMany(e => e.DIS_ActionTypeAttribute)
                .WithRequired(e => e.DIS_ActionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_ActionType>()
                .HasMany(e => e.DIS_ActionTypeParameter)
                .WithRequired(e => e.DIS_ActionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_ActionTypeAttribute>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ActionTypeAttribute>()
                .HasMany(e => e.DIS_EventActionAttribute)
                .WithRequired(e => e.DIS_ActionTypeAttribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_ActionTypeParameter>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Application>()
                .Property(e => e.AppName)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Application>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.LadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.BolNumber)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.Volume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.PalletLadingQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.ShipmentToTALASQ)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CalculatedWeight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CalculatedVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.FreightChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.TotalPOWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.TotalPOVolumn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.SOLadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.SOLadingWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.SOLadingVolumn)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.TotalWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.TotalVolume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.TotalLadingQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIO_ASNBOL)
                .WithOptional(e => e.DIS_ASN)
                .HasForeignKey(e => e.ASN);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIO_Historical_Info)
                .WithOptional(e => e.DIS_ASN)
                .HasForeignKey(e => e.ASN);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIO_Historical_Info1)
                .WithOptional(e => e.DIS_ASN1)
                .HasForeignKey(e => e.ASNNo);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIO_PackDetail)
                .WithOptional(e => e.DIS_ASN)
                .HasForeignKey(e => e.ASNID);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIO_PackHeader)
                .WithOptional(e => e.DIS_ASN)
                .HasForeignKey(e => e.ASNID);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIO_PickHeader1)
                .WithOptional(e => e.DIS_ASN1)
                .HasForeignKey(e => e.ASNNo);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIO_WHOrderHeader)
                .WithOptional(e => e.DIS_ASN)
                .HasForeignKey(e => e.ASNSOs);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIO_WHStockOut)
                .WithOptional(e => e.DIS_ASN)
                .HasForeignKey(e => e.ASNNO);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIS_ASN1)
                .WithOptional(e => e.DIS_ASN2)
                .HasForeignKey(e => e.MasterASNID);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIS_ASN11)
                .WithOptional(e => e.DIS_ASN3)
                .HasForeignKey(e => e.OutboundASNNo);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader1)
                .WithOptional(e => e.DIS_ASN1)
                .HasForeignKey(e => e.ASNNo);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.InboundOutboundASNHeaders)
                .WithOptional(e => e.DIS_ASN)
                .HasForeignKey(e => e.InboundASNHeaderNo);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.InboundOutboundASNHeaders1)
                .WithOptional(e => e.DIS_ASN1)
                .HasForeignKey(e => e.OutboundASNHeaderNo);

            modelBuilder.Entity<DIS_ASN>()
                .HasMany(e => e.DIS_SaleInvoiceHeader)
                .WithOptional(e => e.DIS_ASN)
                .HasForeignKey(e => e.ASNSONo);

            modelBuilder.Entity<DIS_ASNPO>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ASNPOPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ASNSO>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ASNSO>()
                .Property(e => e.SOLadingQuantity)
                .HasPrecision(18, 0);
        }

        private void AddEntity46(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_ASNSO>()
                .Property(e => e.SOLadingWeight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_ASNSO>()
                .Property(e => e.SOLadingVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_ASNSO>()
                .Property(e => e.SOLadingHeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASNSO>()
                .Property(e => e.NumberOfBox)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_ASNSOPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_ASNSOPallet>()
                .HasMany(e => e.DIO_PackDetail)
                .WithOptional(e => e.DIS_ASNSOPallet)
                .HasForeignKey(e => e.PalletID);

            modelBuilder.Entity<DIS_Assembly>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Assembly>()
                .HasMany(e => e.DIS_TypeInfo)
                .WithOptional(e => e.DIS_Assembly)
                .HasForeignKey(e => e.AssemblyID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DIS_BarGroup>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_BarGroup>()
                .HasMany(e => e.DIS_Menu)
                .WithOptional(e => e.DIS_BarGroup)
                .HasForeignKey(e => e.BarGroupId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DIS_Carton>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_Carton>()
                .Property(e => e.Volume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_Carton>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_Carton>()
                .Property(e => e.FreightCharges)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_Carton>()
                .Property(e => e.HandlingCharges)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_Carton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Carton>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_Carton>()
                .Property(e => e.NumberOfUnits)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_Carton>()
                .HasMany(e => e.DIO_PackDetail)
                .WithOptional(e => e.DIS_Carton)
                .HasForeignKey(e => e.CartonID);

            modelBuilder.Entity<DIS_Carton>()
                .HasMany(e => e.DIS_LineItem)
                .WithOptional(e => e.DIS_Carton)
                .HasForeignKey(e => e.ShipmentAdviceCartonId);

            modelBuilder.Entity<DIS_Carton>()
                .HasMany(e => e.DIS_LineItem1)
                .WithOptional(e => e.DIS_Carton1)
                .HasForeignKey(e => e.WSTShipmentAdviceCartonID);

            modelBuilder.Entity<DIS_Carton>()
                .HasMany(e => e.DIS_CartonTransaction)
                .WithRequired(e => e.DIS_Carton)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Carton>()
                .HasMany(e => e.DIS_LineItem2)
                .WithOptional(e => e.DIS_Carton2)
                .HasForeignKey(e => e.CartonNo);

            modelBuilder.Entity<DIS_CartonTransaction>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_CurrentUser>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Event>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Event>()
                .HasMany(e => e.DIS_EventExpression)
                .WithRequired(e => e.DIS_Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_EventActionAttribute>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_EventActionAttributeUser>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_EventExpression>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_EventExpression>()
                .HasMany(e => e.DIS_EventExpressionAction)
                .WithRequired(e => e.DIS_EventExpression)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_EventExpressionAction>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_EventExpressionAction>()
                .HasMany(e => e.DIS_EventActionAttribute)
                .WithRequired(e => e.DIS_EventExpressionAction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_EventType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_EventType>()
                .HasMany(e => e.DIS_Event)
                .WithRequired(e => e.DIS_EventType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Expression>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Function>()
                .Property(e => e.FunctionName)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Function>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Function>()
                .Property(e => e.GUIItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Function>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Function>()
                .HasMany(e => e.DIO_PassCodePermission)
                .WithOptional(e => e.DIS_Function)
                .HasForeignKey(e => e.FunctionID);

            modelBuilder.Entity<DIS_Function>()
                .HasMany(e => e.DIS_FunctionTypeInfo)
                .WithOptional(e => e.DIS_Function)
                .HasForeignKey(e => e.FunctionID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DIS_Function>()
                .HasMany(e => e.DIS_PermissionAssignment)
                .WithOptional(e => e.DIS_Function)
                .HasForeignKey(e => e.FunctionID);

            modelBuilder.Entity<DIS_FunctionTypeInfo>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Hub>()
                .Property(e => e.PercentOverShip)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_Hub>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Hub>()
                .Property(e => e.HubBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_Hub>()
                .Property(e => e.CreditLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_ChangeHubCriteria)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.HubID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_ChangeHubCriteria1)
                .WithOptional(e => e.DIS_Hub1)
                .HasForeignKey(e => e.NewHubID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_CustomerCrossReference)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.CurrentHubID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_CustomerCrossReference1)
                .WithOptional(e => e.DIS_Hub1)
                .HasForeignKey(e => e.NewHubID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_CustomerMarkForStore)
                .WithRequired(e => e.DIS_Hub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_ERP_Hub)
                .WithRequired(e => e.DIS_Hub)
                .HasForeignKey(e => e.OMSHubID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_HubFreight)
                .WithRequired(e => e.DIS_Hub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_HubReportField)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.Hub);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_HubReportField1)
                .WithOptional(e => e.DIS_Hub1)
                .HasForeignKey(e => e.HubID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.Hub);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_PickingList)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.Hub);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_RoutingByZipCode)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.Hub);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_ShippingInfo1)
                .WithOptional(e => e.DIS_Hub1)
                .HasForeignKey(e => e.HubID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIO_ShipTo_QBCustomer_Job)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.Hub);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIS_Hub1)
                .WithOptional(e => e.DIS_Hub2)
                .HasForeignKey(e => e.ParentHubID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIS_PODetail)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.SubCustomerID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIS_SODetail)
                .WithOptional(e => e.DIS_Hub)
                .HasForeignKey(e => e.SubCustomerID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIS_MasterLocation1)
                .WithOptional(e => e.DIS_Hub1)
                .HasForeignKey(e => e.HubID);

            modelBuilder.Entity<DIS_Hub>()
                .HasMany(e => e.DIS_SOHeader)
                .WithRequired(e => e.DIS_Hub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.Price)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.PublishedPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.SuggestedRetailPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.ItemQtyPerMasterCarton)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.ItemQtyPerInnerCarton)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.ItemQtyPerPallet)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.Length)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.ReportQuota846)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.MinStock846)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.Pack)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.Default846Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.DefaultQty846)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.ThresHold)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.AllowedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.AvailableForPurchase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.MinSell)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .Property(e => e.MaxSell)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_HubItem>()
                .HasMany(e => e.DIO_HubItemStore)
                .WithOptional(e => e.DIS_HubItem)
                .HasForeignKey(e => e.HubItem);
        }

        private void AddEntity47(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.CommitQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.CommitUOMRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.QtyShippedToDate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.Volume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.InvoiceQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.ReceivedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.PackedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity11)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice11)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity12)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice12)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity13)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice13)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity14)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice14)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity15)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice15)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity16)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice16)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity17)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice17)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity18)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice18)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity19)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice19)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity20)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice20)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity22)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice22)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity23)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice23)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity24)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice24)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity25)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice25)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity26)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice26)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity27)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice27)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity28)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice28)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity29)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice29)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice30)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity31)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice31)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity32)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice32)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity33)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice33)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity34)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice34)
                .HasPrecision(19, 4);

        }

        private void AddEntity48(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity35)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice35)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity36)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice36)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity37)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice37)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity38)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice38)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity39)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice39)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity40)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice40)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity41)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice41)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity42)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice42)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity43)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice43)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity44)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice44)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity45)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice45)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity46)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice46)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity47)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice47)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity48)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice48)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity49)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice49)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineItemQuantity50)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.SubLineUnitPrice50)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.UPSWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.UPSHeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.UPSLength)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.UPSWidth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.PickedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.CustomsValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .Property(e => e.BatchQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItem>()
                .HasMany(e => e.DIO_LineItemBatch)
                .WithOptional(e => e.DIS_LineItem)
                .HasForeignKey(e => e.ASNLineItemID);

            modelBuilder.Entity<DIS_LineItem>()
                .HasMany(e => e.DIS_LineItemDetail)
                .WithOptional(e => e.DIS_LineItem)
                .HasForeignKey(e => e.LineItem);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .HasMany(e => e.DIO_ASNInvoiceDetail)
                .WithOptional(e => e.DIS_LineItemDetail)
                .HasForeignKey(e => e.LineItemDetail);

            modelBuilder.Entity<DIS_LineItemDetail>()
                .HasMany(e => e.DIO_LineItemDetailBatch)
                .WithOptional(e => e.DIS_LineItemDetail)
                .HasForeignKey(e => e.LineItemDetail);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Density)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Depth)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Diameter)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Gauge)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Length)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Width)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Height)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Volume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.LCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.PalletTie)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.PalletTier)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.SizeValue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.LengthBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.WidthBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.HeightBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.WeightBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.VolumeBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.MaxQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.MinQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.QuotaCategory)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ItemCommissionRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ItemQtyPerMasterCarton)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ItemQtyPerInnerCarton)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ItemQtyPerPallet)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.MSRP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CartonWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.UPSWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.UPSHeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.UPSLength)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.UPSWidth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.MovingAverageGrowthRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ForecastMinInventoryQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.MinPOQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomsValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Qty_Unit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.MaxReplPerBox)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.TotalSeasonAvailable)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.Adjustment)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CalculatedInStock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.TotalShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.TotalCancelled)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);
        }

        private void AddEntity49(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ED_Length)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ED_Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ED_Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ED_Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.ED_Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CQ_20FLC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CQ_40FLC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CQ_40HQ)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .Property(e => e.CQ_45FLC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_ACKSODetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterItemID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_ACKSODetail1)
                .WithOptional(e => e.DIS_MasterItem1)
                .HasForeignKey(e => e.ItemSubtituteID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_AdjustmentDetail)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_AllocatedPOSO)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterItemIDPO);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_AllocatedPOSO1)
                .WithOptional(e => e.DIS_MasterItem1)
                .HasForeignKey(e => e.MasterItemIDSO);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_AutoReport)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterItem);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_Batch)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_BillOfMaterialDetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.ComponentItemID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_InventoryLineItem)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_ItemDateRangePrice)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_ItemQuantityPrice)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_KitDetail)
                .WithRequired(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.ChildItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_KitDetail1)
                .WithRequired(e => e.DIS_MasterItem1)
                .HasForeignKey(e => e.MasterKitID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_LocationManagementDetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.ItemBase);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_MasterEventLineItem)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasOptional(e => e.DIO_MasterKit)
                .WithRequired(e => e.DIS_MasterItem);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_nSerial)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterItem);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_OpenPack)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentDetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterItemID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentDetail1)
                .WithOptional(e => e.DIS_MasterItem1)
                .HasForeignKey(e => e.MasterKitID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_OrderChangeRequestDetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterItem);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_PickDetailItem)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_PTSLineItem)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_RawWHShippingOrderDetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterItem);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_ReturnReceiptDetail)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_ReturnShipmentDetail)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_VendorItemMasterItem)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterItem);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_VendorItemMasterItem1)
                .WithRequired(e => e.DIS_MasterItem1)
                .HasForeignKey(e => e.MasterItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_WHRecipientNoticeDetail)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_WHStockInDetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.DocMasterItemID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_WHStockInDetail1)
                .WithRequired(e => e.DIS_MasterItem1)
                .HasForeignKey(e => e.MasterItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIO_WHStockOutDetail)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIS_MasterItem1)
                .WithOptional(e => e.DIS_MasterItem2)
                .HasForeignKey(e => e.ParentItemID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIS_SaleInvoiceDetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.IndividualItemID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIS_SODetail)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.MasterKitID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIS_SOHeader)
                .WithOptional(e => e.DIS_MasterItem)
                .HasForeignKey(e => e.ItemBaseID);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIS_PODetail)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIS_PurchaseInvoiceDetail)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIS_SaleInvoiceDetail1)
                .WithRequired(e => e.DIS_MasterItem1)
                .HasForeignKey(e => e.MasterItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.DIS_SODetail1)
                .WithRequired(e => e.DIS_MasterItem1)
                .HasForeignKey(e => e.MasterItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterItem>()
                .HasMany(e => e.TmpAdjustmentDetails)
                .WithRequired(e => e.DIS_MasterItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_AssignLocation)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.LocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_Batch)
                .WithRequired(e => e.DIS_MasterLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_BlanketPOHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_InventoryCarton)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.OriginalMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_InventoryCarton1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.MasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_InventoryCartonShippingAdvice)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_InventoryCartonShippingAdvice1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.OriginalMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_InventoryPallet)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.OriginalMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_InventoryPallet1)
                .WithRequired(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.MasterLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_InventoryPalletShippingAdvice)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_InventoryPalletShippingAdvice1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.OriginalMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_nSerial)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocation);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_OpenPack)
                .WithRequired(e => e.DIS_MasterLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_OpenPackDetail)
                .WithRequired(e => e.DIS_MasterLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PackDetail)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ShippingLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PackItem)
                .WithRequired(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PackItemDetailLocation)
                .WithRequired(e => e.DIS_MasterLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PickDetailBarcode)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.LocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PickDetailCarton)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PickDetailItem)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PickDetailItem1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.FromLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PickDetailPallet)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PickHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.Destination);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PickingListDetail)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PickingListDetail1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.MasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_PurchaseTransitTime)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_ReceivingHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_ReturnReceipt)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ShipFromCode);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_ReturnShipment)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_RoutingByZipCode)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocation);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferCarton)
                .WithRequired(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToMasterLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferCarton1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferDetail)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferDetail1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferDocumentDetail)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferDocumentDetail1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.ToMasterLocationID);
        }

        private void AddEntity50(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferDocumentLineDetail)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromMasterLocation);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferDocumentLineDetail1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.ToMasterLocation);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferPallet)
                .WithRequired(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToMasterLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_TransferPallet1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WH947Header)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocation);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHRecipientNoticeHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHShippingOrderDetail)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHShippingOrderDetail1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.ToMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHShippingOrderHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHShippingOrderHeader1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.ToMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHStockIn)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHStockIn1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.ToMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHStockOut)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WHStockOut1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.ToMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WorkOrder)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.LocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WorkOrderDetails)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.LocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WSTReceiptAdviceCarton)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.Location);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.Location);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ItemLocation);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WSTReceiptAdvicePallet)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.Location);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.LocationId);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIOW_LocationItemPars)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.LocID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_Carton)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocation);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_CartonTransaction)
                .WithRequired(e => e.DIS_MasterLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_Hub)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_HubItem)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.DefaultLocation);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_POHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_SaleInvoiceDetail)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.BinID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_SaleInvoiceDetail1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.WarehouseID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_SaleInvoiceHeader)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.AssignWarehouseID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_MasterLocation1)
                .WithOptional(e => e.DIS_MasterLocation2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_PalletTransaction)
                .WithRequired(e => e.DIS_MasterLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_POHeader1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.ShipToCode);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_SaleInvoiceDetail2)
                .WithOptional(e => e.DIS_MasterLocation2)
                .HasForeignKey(e => e.MasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_SOAllocatedLocation)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.MasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_SOAllocatedLocation1)
                .WithOptional(e => e.DIS_MasterLocation1)
                .HasForeignKey(e => e.OldMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.TmpTransferCartons)
                .WithRequired(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToMasterLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.TmpTransferDetails)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.TmpTransferPallets)
                .WithRequired(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.ToMasterLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.TmpTransferHeaders)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.FromMasterLocationID);

            modelBuilder.Entity<DIS_MasterLocation>()
                .HasMany(e => e.DIS_VendorItem)
                .WithOptional(e => e.DIS_MasterLocation)
                .HasForeignKey(e => e.DefaultLocation);

            modelBuilder.Entity<DIS_Menu>()
                .Property(e => e.MenuName)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Menu>()
                .Property(e => e.BarItemImage)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Menu>()
                .Property(e => e.GUIItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Menu>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Menu>()
                .HasMany(e => e.DIO_PassCodePermission)
                .WithOptional(e => e.DIS_Menu)
                .HasForeignKey(e => e.MenuID);

            modelBuilder.Entity<DIS_Menu>()
                .HasMany(e => e.DIS_FunctionTypeInfo)
                .WithOptional(e => e.DIS_Menu)
                .HasForeignKey(e => e.MenuID);

            modelBuilder.Entity<DIS_Menu>()
                .HasMany(e => e.DIS_Menu1)
                .WithOptional(e => e.DIS_Menu2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<DIS_Menu>()
                .HasMany(e => e.DIS_PermissionAssignment)
                .WithOptional(e => e.DIS_Menu)
                .HasForeignKey(e => e.MenuID);

            modelBuilder.Entity<DIS_MultiUser>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Pallet>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_Pallet>()
                .Property(e => e.FreightCharges)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_Pallet>()
                .Property(e => e.HandlingCharges)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_Pallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Pallet>()
                .HasMany(e => e.DIS_PalletTransaction)
                .WithRequired(e => e.DIS_Pallet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_PalletTransaction>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_PermissionAssignment>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.Qty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.QtyReceived)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.MultPriceQty)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.ExtendedLineAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.TaxAfterDiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.DiscountRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.Pack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemUnitPrice1)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemUnitPrice2)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemUnitPrice3)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemUnitPrice4)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemUnitPrice5)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemUnitPrice6)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemUnitPrice7)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.SubLineItemUnitPrice8)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.NPSOOrderQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.InvoiceToDate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.NPQuantityToCreateRA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.AdvicedToDate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .Property(e => e.FCLQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PODetail>()
                .HasMany(e => e.DIO_PODetailAllowanceCharge)
                .WithRequired(e => e.DIS_PODetail)
                .WillCascadeOnDelete(false);

        }

        private void AddEntity51(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_PODetail>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItemDetail)
                .WithOptional(e => e.DIS_PODetail)
                .HasForeignKey(e => e.PODetail);

            modelBuilder.Entity<DIS_PODetail>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItemDetail)
                .WithOptional(e => e.DIS_PODetail)
                .HasForeignKey(e => e.PODetail);

            modelBuilder.Entity<DIS_PODetail>()
                .HasMany(e => e.DIS_LineItemDetail)
                .WithOptional(e => e.DIS_PODetail)
                .HasForeignKey(e => e.PODetail);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.POAcknowledgmentType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.TotalBeforeDiscount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.TotalPaymentDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.TermDiscAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.TotalDeposit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_POHeader>()
                .HasMany(e => e.DIO_POFreight)
                .WithRequired(e => e.DIS_POHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_POHeader>()
                .HasMany(e => e.DIO_POHeaderAllowanceCharge)
                .WithRequired(e => e.DIS_POHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_POHeader>()
                .HasMany(e => e.DIO_POPIHeader)
                .WithOptional(e => e.DIS_POHeader)
                .HasForeignKey(e => e.POHeaderNo);

            modelBuilder.Entity<DIS_POHeader>()
                .HasMany(e => e.DIOW_PalletInfo)
                .WithOptional(e => e.DIS_POHeader)
                .HasForeignKey(e => e.POHeaderID);

            modelBuilder.Entity<DIS_POHeader>()
                .HasMany(e => e.DIS_PODetail)
                .WithRequired(e => e.DIS_POHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_POHeader>()
                .HasMany(e => e.DIS_PurchaseInvoiceHeader)
                .WithRequired(e => e.DIS_POHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.TaxAfterDiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.ReceiveWithoutUnReceipt)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .Property(e => e.DiscountRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .HasMany(e => e.DIO_POInvoiceDetailAllowanceCharge)
                .WithRequired(e => e.DIS_PurchaseInvoiceDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .HasMany(e => e.DIO_POPIDetail)
                .WithOptional(e => e.DIS_PurchaseInvoiceDetail)
                .HasForeignKey(e => e.PIDetailNo);

            modelBuilder.Entity<DIS_PurchaseInvoiceDetail>()
                .HasMany(e => e.DIO_PurchaseInvoiceSerial)
                .WithRequired(e => e.DIS_PurchaseInvoiceDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TotalBeforeDiscount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TotalPaymentDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TotalPaymentAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TermDiscDayDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TermDiscAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TotalAllowanceAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TotalChargeAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TotalTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TotalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .Property(e => e.TotalDeposit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .HasMany(e => e.DIO_InvoicePOFreight)
                .WithRequired(e => e.DIS_PurchaseInvoiceHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .HasMany(e => e.DIO_POInvoiceHeaderAllowanceCharge)
                .WithRequired(e => e.DIS_PurchaseInvoiceHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .HasMany(e => e.DIO_POPIHeader)
                .WithOptional(e => e.DIS_PurchaseInvoiceHeader)
                .HasForeignKey(e => e.PIHeaderNo);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .HasMany(e => e.DIO_VendorPaymentDetail)
                .WithOptional(e => e.DIS_PurchaseInvoiceHeader)
                .HasForeignKey(e => e.InvoiceNo);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader)
                .WithOptional(e => e.DIS_PurchaseInvoiceHeader)
                .HasForeignKey(e => e.PurchaseInvoiceHeaderNo);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.DIS_PurchaseInvoiceHeader)
                .HasForeignKey(e => e.PINo);

            modelBuilder.Entity<DIS_PurchaseInvoiceHeader>()
                .HasMany(e => e.DIS_PurchaseInvoiceDetail)
                .WithRequired(e => e.DIS_PurchaseInvoiceHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Role>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Role>()
                .HasMany(e => e.DIS_PermissionAssignment)
                .WithOptional(e => e.DIS_Role)
                .HasForeignKey(e => e.RoleID);

            modelBuilder.Entity<DIS_Role>()
                .HasMany(e => e.DIS_UserRole)
                .WithRequired(e => e.DIS_Role)
                .HasForeignKey(e => e.RoleID);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.TaxAfterDiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.DiscountRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.ReceiveWithoutUnReceipt)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.ItemQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.QtyDifference)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.ExtendLineAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .HasMany(e => e.DIO_ASNInvoiceDetail)
                .WithOptional(e => e.DIS_SaleInvoiceDetail)
                .HasForeignKey(e => e.SaleInvoiceDetail);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .HasMany(e => e.DIO_SaleInvoiceSerial)
                .WithRequired(e => e.DIS_SaleInvoiceDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .HasMany(e => e.DIO_SISODetail)
                .WithOptional(e => e.DIS_SaleInvoiceDetail)
                .HasForeignKey(e => e.SIDetailNo);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .HasMany(e => e.DIO_SOInvoiceDetailAllowanceCharge)
                .WithRequired(e => e.DIS_SaleInvoiceDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SaleInvoiceDetail>()
                .HasMany(e => e.DIO_SubLineItem)
                .WithOptional(e => e.DIS_SaleInvoiceDetail)
                .HasForeignKey(e => e.SIDetailNo);
        }

        private void AddEntity52(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TotalBeforeDiscount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TotalPaymentDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TotalPaymentAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TermDiscDayDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TermDiscAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.DiscountAmountHeader)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TotalFreight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.TotalTaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIO_ASNInvoice)
                .WithOptional(e => e.DIS_SaleInvoiceHeader)
                .HasForeignKey(e => e.InvoiceNo);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIO_BrokerPayment)
                .WithOptional(e => e.DIS_SaleInvoiceHeader)
                .HasForeignKey(e => e.SalesInvoiceID);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIO_CustomerPaymentDetail)
                .WithOptional(e => e.DIS_SaleInvoiceHeader)
                .HasForeignKey(e => e.InvoiceNo);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIO_InvoiceSOFreight)
                .WithRequired(e => e.DIS_SaleInvoiceHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIO_SISOHeader)
                .WithOptional(e => e.DIS_SaleInvoiceHeader)
                .HasForeignKey(e => e.SIHeaderNo);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIO_SOInvoiceHeaderAllowanceCharge)
                .WithRequired(e => e.DIS_SaleInvoiceHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIS_SaleInvoiceDetail)
                .WithRequired(e => e.DIS_SaleInvoiceHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIS_SaleInvoiceHeader1)
                .WithOptional(e => e.DIS_SaleInvoiceHeader2)
                .HasForeignKey(e => e.MasterSI);

            modelBuilder.Entity<DIS_SaleInvoiceHeader>()
                .HasMany(e => e.DIS_SISO)
                .WithOptional(e => e.DIS_SaleInvoiceHeader)
                .HasForeignKey(e => e.SINo);

            modelBuilder.Entity<DIS_SOAllocatedLocation>()
                .Property(e => e.AllocatedQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SOAllocatedLocation>()
                .Property(e => e.CommitQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SOAllocatedLocation>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.TaxRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.TaxAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.TaxAfterDiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.UOMRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.MultPriceQty)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.QtyLeftToShipped)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.QtyShipped)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.RetailPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.Amount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.DiscountRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.Pack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.NoOfInnerPack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.ItemCommissionRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.MasterKitQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.MasterKitQtyShipped)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.OriginalQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineItemQuantity1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineUnitPrice1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineItemQuantity2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineUnitPrice2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineItemQuantity3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineUnitPrice3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineItemQuantity4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineUnitPrice4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineItemQuantity5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineUnitPrice5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineItemQuantity6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineUnitPrice6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineItemQuantity7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineUnitPrice7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineItemQuantity8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SubLineUnitPrice8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.GroceryPackVolume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.GroceryPackWeigh)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.InvoiceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.TempInvoiceQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.DropshipQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.DropshipedQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.QtyShippedByDropship)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.QtyShippedBase)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.Size)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.AllocationQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CanceledQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.Quantity940)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.PickQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.FCLQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SKU_Allocated)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.SKU_Allocated_Tmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);
        }

        private void AddEntity53(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .Property(e => e.ACKQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SODetail>()
                .HasMany(e => e.DIO_ACKSODetail)
                .WithOptional(e => e.DIS_SODetail)
                .HasForeignKey(e => e.SODetail);

            modelBuilder.Entity<DIS_SODetail>()
                .HasMany(e => e.DIO_ERP_QBSODetailAllowanceCharge)
                .WithRequired(e => e.DIS_SODetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SODetail>()
                .HasMany(e => e.DIO_SaleRepSODetail)
                .WithOptional(e => e.DIS_SODetail)
                .HasForeignKey(e => e.SODetail);

            modelBuilder.Entity<DIS_SODetail>()
                .HasMany(e => e.DIO_SODetailAllowanceCharge)
                .WithRequired(e => e.DIS_SODetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SODetail>()
                .HasMany(e => e.DIO_WHShippingAdviceDetail)
                .WithOptional(e => e.DIS_SODetail)
                .HasForeignKey(e => e.SODetail);

            modelBuilder.Entity<DIS_SODetail>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItemDetail)
                .WithOptional(e => e.DIS_SODetail)
                .HasForeignKey(e => e.SODetail);

            modelBuilder.Entity<DIS_SODetail>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItemDetail)
                .WithOptional(e => e.DIS_SODetail)
                .HasForeignKey(e => e.SODetail);

            modelBuilder.Entity<DIS_SODetail>()
                .HasMany(e => e.DIS_LineItemDetail)
                .WithOptional(e => e.DIS_SODetail)
                .HasForeignKey(e => e.SODetail);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.ExchangeRateAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.DueDateCalculation)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TermDiscPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TermDiscDayDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TermDiscAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TotalBeforeDiscount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TotalPaymentDue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TotalCommissionAmount)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.RateFixPercentCommision)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TotalAllowance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.OriginalDiscountAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TotalPOWeight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.WarehouseTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.DiscountAmountHeader)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_4)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_5)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_6)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_7)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_8)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_9)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.CustomField_Decimal_10)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .Property(e => e.TotalPaymentAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_ERP_SOHeaderAllowanceCharge)
                .WithRequired(e => e.DIS_SOHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentHeader)
                .WithOptional(e => e.DIS_SOHeader)
                .HasForeignKey(e => e.SOHeaderNo);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader)
                .WithOptional(e => e.DIS_SOHeader)
                .HasForeignKey(e => e.SOHeader);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_OrderChangeRequestHeader1)
                .WithOptional(e => e.DIS_SOHeader1)
                .HasForeignKey(e => e.SONo);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_SISOHeader)
                .WithOptional(e => e.DIS_SOHeader)
                .HasForeignKey(e => e.SOHeaderNo);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_SOFreight)
                .WithRequired(e => e.DIS_SOHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_SOHeaderAllowanceCharge)
                .WithRequired(e => e.DIS_SOHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_WHOrderHeader)
                .WithRequired(e => e.DIS_SOHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader)
                .WithOptional(e => e.DIS_SOHeader)
                .HasForeignKey(e => e.SOHeader);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIO_WorkOrder)
                .WithOptional(e => e.DIS_SOHeader)
                .HasForeignKey(e => e.SaleOrderID);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIS_SaleInvoiceHeader)
                .WithRequired(e => e.DIS_SOHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIS_SODetail)
                .WithRequired(e => e.DIS_SOHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIS_SOHeader1)
                .WithOptional(e => e.DIS_SOHeader2)
                .HasForeignKey(e => e.OriginalParentSoID);

            modelBuilder.Entity<DIS_SOHeader>()
                .HasMany(e => e.DIS_SOHeader11)
                .WithOptional(e => e.DIS_SOHeader3)
                .HasForeignKey(e => e.ParentSoID);

            modelBuilder.Entity<DIS_TemplateParameter>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_TemplateParameter>()
                .HasMany(e => e.DIS_ActionTypeParameter)
                .WithRequired(e => e.DIS_TemplateParameter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_TypeInfo>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_TypeInfo>()
                .HasMany(e => e.DIS_FunctionTypeInfo)
                .WithOptional(e => e.DIS_TypeInfo)
                .HasForeignKey(e => e.TypeInfoID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DIS_TypeInfo>()
                .HasMany(e => e.DIS_Menu)
                .WithOptional(e => e.DIS_TypeInfo)
                .HasForeignKey(e => e.TypeInfoID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_ACKSODetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_ACKSODetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_AllocatedPOSO)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_BlanketPODetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UnitOfMeasureID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_BlanketPODetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_BlanketSODetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UnitOfMeasureID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_BlanketSODetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_BrokerPaymentDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_DefaultPackSize)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryAdviceDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryCarton)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryCarton1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryCartonDimension)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryCartonDimension1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryCartonShippingAdvice)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeUOM);
        }

        private void AddEntity54(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryCartonShippingAdvice1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryLineItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UnitOfMeasure);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryLineItem1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UnitOfMeasureBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryLineItem2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryLineItem3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryLineItemShippingAdvice)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UnitOfMeasure);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryLineItemShippingAdvice1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UnitOfMeasureBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryLineItemShippingAdvice2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryLineItemShippingAdvice3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryPallet)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryPallet1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryPalletDimension)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_InventoryPalletDimension1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_LandedCostLineItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_LandedCostLineItem1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_nSerial)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_OrderChangeAcknowledgmentDetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_OrderChangeRequestDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_OrderStatusReport870Detail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_PackageType)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.LengthUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_PackageType1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_PTSASN)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_PTSASN1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_RawWHShippingOrderDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_RepackSerialDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.OldParentUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_RepackSerialDetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.ParentUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_RepackSerialDetail2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.UOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_RoutingRequestDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_RoutingRequestDetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_Serial)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_SODetailPackage)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_UOMSet)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.BaseUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_UOMSet1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.DefaultPOUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_UOMSet2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.DefaultShippingUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_UOMSet3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.DefaultSOUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WH947LineItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.TotalLadingQtyUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.TotalVolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.TotalWeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHShippingAdviceHeader3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.WeightUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHShippingOrderDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHShippingOrderDetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHShippingOrderDetail2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.WeightUOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHStockInDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UnitOfMeasureID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHStockInDetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WHStockOutDetail)
                .WithRequired(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.ShipmentUnitOfMeasure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceCarton)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceCarton1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceHeader1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.CommitBaseUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.CommitUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.OrderUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.PackUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem4)
                .WithOptional(e => e.DIS_UnitOfMeasure4)
                .HasForeignKey(e => e.ShippedUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem5)
                .WithOptional(e => e.DIS_UnitOfMeasure5)
                .HasForeignKey(e => e.UOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem6)
                .WithOptional(e => e.DIS_UnitOfMeasure6)
                .HasForeignKey(e => e.VolumnUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTReceiptAdviceLineItem7)
                .WithOptional(e => e.DIS_UnitOfMeasure7)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceCarton)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceCarton1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceHeader1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.CommitBaseUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItem1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.CommitUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItem2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.OrderUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItem3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.PackUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItem4)
                .WithOptional(e => e.DIS_UnitOfMeasure4)
                .HasForeignKey(e => e.ShippedUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItem5)
                .WithOptional(e => e.DIS_UnitOfMeasure5)
                .HasForeignKey(e => e.VolumnUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIO_WSTShipmentAdviceLineItem6)
                .WithOptional(e => e.DIS_UnitOfMeasure6)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.HeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_ASN1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.TotalLadingQtyUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_ASN2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.TotalVolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_ASN3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.TotalWeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_ASN4)
                .WithOptional(e => e.DIS_UnitOfMeasure4)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_ASN5)
                .WithOptional(e => e.DIS_UnitOfMeasure5)
                .HasForeignKey(e => e.VolumeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_Carton)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumeCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_Carton1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_Hub)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.LengthUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_Hub1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMWeightID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_HubItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.HeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_HubItem1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.LengthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_HubItem2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.VolumeCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_HubItem3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.WeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_HubItem4)
                .WithOptional(e => e.DIS_UnitOfMeasure4)
                .HasForeignKey(e => e.WidthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_HubItem5)
                .WithOptional(e => e.DIS_UnitOfMeasure5)
                .HasForeignKey(e => e.UnitOfMeasureID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_LineItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.VolumnUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_LineItem1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.WeightUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_LineItem2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.CommitUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_LineItem3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.CommitBaseUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_LineItem4)
                .WithOptional(e => e.DIS_UnitOfMeasure4)
                .HasForeignKey(e => e.PackUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.CartonWeightCode);
        }

        private void AddEntity55(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.CQ_20FLCCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.CQ_40FLCCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.CQ_40HQCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem4)
                .WithOptional(e => e.DIS_UnitOfMeasure4)
                .HasForeignKey(e => e.CQ_45FLCCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem5)
                .WithOptional(e => e.DIS_UnitOfMeasure5)
                .HasForeignKey(e => e.ED_UOMHeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem6)
                .WithOptional(e => e.DIS_UnitOfMeasure6)
                .HasForeignKey(e => e.ED_UOMLengthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem7)
                .WithOptional(e => e.DIS_UnitOfMeasure7)
                .HasForeignKey(e => e.ED_UOMVolumeCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem8)
                .WithOptional(e => e.DIS_UnitOfMeasure8)
                .HasForeignKey(e => e.ED_UOMWeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem9)
                .WithOptional(e => e.DIS_UnitOfMeasure9)
                .HasForeignKey(e => e.ED_UOMWidthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem10)
                .WithOptional(e => e.DIS_UnitOfMeasure10)
                .HasForeignKey(e => e.UPSHeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem11)
                .WithOptional(e => e.DIS_UnitOfMeasure11)
                .HasForeignKey(e => e.UPSLengthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem12)
                .WithOptional(e => e.DIS_UnitOfMeasure12)
                .HasForeignKey(e => e.UPSWeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem13)
                .WithOptional(e => e.DIS_UnitOfMeasure13)
                .HasForeignKey(e => e.UPSWidthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem14)
                .WithOptional(e => e.DIS_UnitOfMeasure14)
                .HasForeignKey(e => e.HeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem15)
                .WithOptional(e => e.DIS_UnitOfMeasure15)
                .HasForeignKey(e => e.LeadTimeUnit);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem16)
                .WithOptional(e => e.DIS_UnitOfMeasure16)
                .HasForeignKey(e => e.LengthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem17)
                .WithOptional(e => e.DIS_UnitOfMeasure17)
                .HasForeignKey(e => e.LengthBaseCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem18)
                .WithOptional(e => e.DIS_UnitOfMeasure18)
                .HasForeignKey(e => e.UnitOfMeasureID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem19)
                .WithOptional(e => e.DIS_UnitOfMeasure19)
                .HasForeignKey(e => e.VolumeCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem20)
                .WithOptional(e => e.DIS_UnitOfMeasure20)
                .HasForeignKey(e => e.WeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem21)
                .WithOptional(e => e.DIS_UnitOfMeasure21)
                .HasForeignKey(e => e.WeightBaseCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem22)
                .WithOptional(e => e.DIS_UnitOfMeasure22)
                .HasForeignKey(e => e.WidthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_MasterItem23)
                .WithOptional(e => e.DIS_UnitOfMeasure23)
                .HasForeignKey(e => e.SizeUOM);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_PODetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_PODetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_PurchaseInvoiceDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_PurchaseInvoiceDetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_SaleInvoiceDetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMID);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_SODetail)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.UOMCodeBase);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_SODetail1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_VendorItem)
                .WithOptional(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.HeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_VendorItem1)
                .WithOptional(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.LengthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_VendorItem2)
                .WithOptional(e => e.DIS_UnitOfMeasure2)
                .HasForeignKey(e => e.VolumeCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_VendorItem3)
                .WithOptional(e => e.DIS_UnitOfMeasure3)
                .HasForeignKey(e => e.WeightCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_VendorItem4)
                .WithOptional(e => e.DIS_UnitOfMeasure4)
                .HasForeignKey(e => e.WidthCode);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_UOMConversion)
                .WithRequired(e => e.DIS_UnitOfMeasure)
                .HasForeignKey(e => e.BaseUOM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_UOMConversion1)
                .WithRequired(e => e.DIS_UnitOfMeasure1)
                .HasForeignKey(e => e.UOMConversionCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_UnitOfMeasure>()
                .HasMany(e => e.DIS_VendorItem5)
                .WithOptional(e => e.DIS_UnitOfMeasure5)
                .HasForeignKey(e => e.UnitOfMeasureID);

            modelBuilder.Entity<DIS_UOMConversion>()
                .Property(e => e.UOMRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_UOMConversion>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_User>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_AssignCustomer)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_AssignItem)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_AssignLocation)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_AssignReport)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_AssignVendor)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_PackHeader)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.CreatedUserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_PackUser)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_PickDetailCarton)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.PickedUserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_PickDetailItem)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.PickedUserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_PickDetailPallet)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.PickedUserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_PickHeader)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.CreatedUserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIO_PickingProgress)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIS_ASNSOPallet)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.PackedUserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIS_Carton)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.PackedUserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIS_CurrentUser)
                .WithRequired(e => e.DIS_User)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIS_EventActionAttributeUser)
                .WithOptional(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIS_MultiUser)
                .WithRequired(e => e.DIS_User)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_User>()
                .HasMany(e => e.DIS_UserRole)
                .WithRequired(e => e.DIS_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<DIS_UserRole>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Vendor>()
                .Property(e => e.VENMINORDERVALUE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_Vendor>()
                .Property(e => e.PREORDERVALUE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_Vendor>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_Vendor>()
                .Property(e => e.VendorBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_Vendor>()
                .HasMany(e => e.DIO_Batch)
                .WithOptional(e => e.DIS_Vendor)
                .HasForeignKey(e => e.Vendor);

            modelBuilder.Entity<DIS_Vendor>()
                .HasMany(e => e.DIO_ERP_Vendor)
                .WithRequired(e => e.DIS_Vendor)
                .HasForeignKey(e => e.OMSVendorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Vendor>()
                .HasMany(e => e.DIO_ReceivingHeader)
                .WithOptional(e => e.DIS_Vendor)
                .HasForeignKey(e => e.Vendor);

            modelBuilder.Entity<DIS_Vendor>()
                .HasMany(e => e.DIO_VendorFreight)
                .WithRequired(e => e.DIS_Vendor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Vendor>()
                .HasMany(e => e.DIO_VendorMarkForStore)
                .WithRequired(e => e.DIS_Vendor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_Vendor>()
                .HasMany(e => e.DIS_POHeader)
                .WithRequired(e => e.DIS_Vendor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.Price)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.LCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.MinQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.MinOrderValue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.MaxQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.MaxOrderValue)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.Percentage)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.Length)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.Weight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.Width)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.Height)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.Volume)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.MovingAverageGrowthRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .Property(e => e.ForecastMinInventoryQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DIS_VendorItem>()
                .HasMany(e => e.DIO_VendorItemMasterItem)
                .WithRequired(e => e.DIS_VendorItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DISOAllocationInfo>()
                .HasMany(e => e.DISODAllocationInfoes)
                .WithOptional(e => e.DISOAllocationInfo1)
                .HasForeignKey(e => e.DISOAllocationInfo);

            modelBuilder.Entity<DISODAllocationInfo>()
                .HasMany(e => e.DIO_nSOAllocatedLocation)
                .WithOptional(e => e.DISODAllocationInfo1)
                .HasForeignKey(e => e.DISODAllocationInfo);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<Harmonize>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Harmonize>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.Harmonize)
                .HasForeignKey(e => e.Harmonize1);

            modelBuilder.Entity<Harmonize>()
                .HasMany(e => e.DIS_MasterItem1)
                .WithOptional(e => e.Harmonize3)
                .HasForeignKey(e => e.Harmonize2);
        }

        private void AddEntity56(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HazardClass>()
                .Property(e => e.HazardClassCode)
                .IsUnicode(false);

            modelBuilder.Entity<HazardClass>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<HazardClass>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.HazardClass1)
                .HasForeignKey(e => e.HazardClass);

            modelBuilder.Entity<ItemDiscontinueDateType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ItemDiscontinueDateType>()
                .HasMany(e => e.DIS_HubItem)
                .WithOptional(e => e.ItemDiscontinueDateType1)
                .HasForeignKey(e => e.ItemDiscontinueDateType);

            modelBuilder.Entity<ItemDiscontinueDateType>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.ItemDiscontinueDateType1)
                .HasForeignKey(e => e.ItemDiscontinueDateType);

            modelBuilder.Entity<ItemInfo>()
                .HasMany(e => e.PODetailInfoes)
                .WithOptional(e => e.ItemInfo1)
                .HasForeignKey(e => e.C_ItemInfo);

            modelBuilder.Entity<ItemInfo>()
                .HasMany(e => e.PODetailInfoes1)
                .WithOptional(e => e.ItemInfo2)
                .HasForeignKey(e => e.ItemInfo);

            modelBuilder.Entity<ItemInfo>()
                .HasMany(e => e.SODetailInfoes)
                .WithOptional(e => e.ItemInfo1)
                .HasForeignKey(e => e.C_ItemInfo);

            modelBuilder.Entity<ItemInfo>()
                .HasMany(e => e.SODetailInfoes1)
                .WithOptional(e => e.ItemInfo2)
                .HasForeignKey(e => e.ItemInfo);

            modelBuilder.Entity<NMFC>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<NMFC>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.NMFC1)
                .HasForeignKey(e => e.NMFC);

            modelBuilder.Entity<PackingSpecification>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PackingSpecification>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.PackingSpecification1)
                .HasForeignKey(e => e.PackingSpecification);

            modelBuilder.Entity<SEQ_NO>()
                .Property(e => e.TranType)
                .IsUnicode(false);

            modelBuilder.Entity<SEQ_NO>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<SEQ_NO>()
                .Property(e => e.YearSeparate)
                .IsUnicode(false);

            modelBuilder.Entity<SEQ_NO>()
                .Property(e => e.MonthSeparate)
                .IsUnicode(false);

            modelBuilder.Entity<SEQ_NO>()
                .HasMany(e => e.SEQ_Group)
                .WithRequired(e => e.SEQ_NO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SODetailInfo>()
                .HasMany(e => e.LocationInfoes)
                .WithOptional(e => e.SODetailInfo1)
                .HasForeignKey(e => e.C_SODetailInfo);

            modelBuilder.Entity<SODetailInfo>()
                .HasMany(e => e.LocationInfoes1)
                .WithOptional(e => e.SODetailInfo2)
                .HasForeignKey(e => e.SODetailInfo);

            modelBuilder.Entity<tbl_MessageInfo>()
                .Property(e => e.DestinationID)
                .IsUnicode(false);

            modelBuilder.Entity<TmpAdjustmentCarton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TmpAdjustmentDetail>()
                .Property(e => e.IndividualItemQty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TmpAdjustmentDetail>()
                .Property(e => e.Onhand)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TmpAdjustmentDetail>()
                .Property(e => e.WarehouseCount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TmpAdjustmentDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<TmpAdjustmentHeader>()
                .HasMany(e => e.TmpAdjustmentCartons)
                .WithRequired(e => e.TmpAdjustmentHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TmpAdjustmentHeader>()
                .HasMany(e => e.TmpAdjustmentDetails)
                .WithRequired(e => e.TmpAdjustmentHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TmpAdjustmentHeader>()
                .HasMany(e => e.TmpAdjustmentHeader1)
                .WithOptional(e => e.TmpAdjustmentHeader2)
                .HasForeignKey(e => e.AdjustmentID);

            modelBuilder.Entity<TmpAdjustmentHeader>()
                .HasMany(e => e.TmpAdjustmentPallets)
                .WithRequired(e => e.TmpAdjustmentHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TmpAdjustmentPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TmpTransferCarton>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<TmpTransferDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TmpTransferDetail>()
                .Property(e => e.QtyBase)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TmpTransferDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<TmpTransferHeader>()
                .Property(e => e.ShipmentMethod)
                .IsUnicode(false);

            modelBuilder.Entity<TmpTransferHeader>()
                .Property(e => e.ShipmentAgent)
                .IsUnicode(false);

            modelBuilder.Entity<TmpTransferHeader>()
                .HasMany(e => e.TmpTransferCartons)
                .WithRequired(e => e.TmpTransferHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TmpTransferHeader>()
                .HasMany(e => e.TmpTransferDetails)
                .WithRequired(e => e.TmpTransferHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TmpTransferHeader>()
                .HasMany(e => e.TmpTransferPallets)
                .WithRequired(e => e.TmpTransferHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TmpTransferPallet>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UPCType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<UPCType>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.UPCType1)
                .HasForeignKey(e => e.UPCType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.DIO_InventoryCarton)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.DIO_InventoryLineItem)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.DIO_PTSASN)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.DIO_Style)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.DIS_ASN)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.DIS_Carton)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.DIS_LineItem)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.DIS_MasterItem)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.XPWeakReferences)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.TargetType);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Density)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Depth)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Diameter)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Gauge)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Length)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Weight)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Width)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Height)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Volume)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.UnitPrice)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.LCost)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.LengthBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.WidthBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.HeightBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.WeightBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<DIS_MasterItemAudit>()
                .Property(e => e.VolumeBaseRate)
                .HasPrecision(28, 4);

            modelBuilder.Entity<Tmp_DIO_AttributeType>()
                .Property(e => e.pl_LockedBy)
                .IsUnicode(false);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            AddEntity1(modelBuilder);
            AddEntity2(modelBuilder);
            AddEntity3(modelBuilder);
            AddEntity4(modelBuilder);
            AddEntity5(modelBuilder);
            AddEntity6(modelBuilder);
            AddEntity7(modelBuilder);
            AddEntity8(modelBuilder);
            AddEntity9(modelBuilder);
            AddEntity10(modelBuilder);
            AddEntity11(modelBuilder);
            AddEntity12(modelBuilder);
            AddEntity13(modelBuilder);
            AddEntity14(modelBuilder);
            AddEntity15(modelBuilder);
            AddEntity16(modelBuilder);
            AddEntity17(modelBuilder);
            AddEntity18(modelBuilder);
            AddEntity19(modelBuilder);
            AddEntity20(modelBuilder);
            AddEntity21(modelBuilder);
            AddEntity22(modelBuilder);
            AddEntity23(modelBuilder);
            AddEntity24(modelBuilder);
            AddEntity25(modelBuilder);
            AddEntity26(modelBuilder);
            AddEntity27(modelBuilder);
            AddEntity28(modelBuilder);
            AddEntity29(modelBuilder);
            AddEntity30(modelBuilder);
            AddEntity31(modelBuilder);
            AddEntity32(modelBuilder);
            AddEntity33(modelBuilder);
            AddEntity34(modelBuilder);
            AddEntity35(modelBuilder);
            AddEntity36(modelBuilder);
            AddEntity37(modelBuilder);
            AddEntity38(modelBuilder);
            AddEntity39(modelBuilder);
            AddEntity40(modelBuilder);
            AddEntity41(modelBuilder);
            AddEntity42(modelBuilder);
            AddEntity43(modelBuilder);
            AddEntity44(modelBuilder);
            AddEntity45(modelBuilder);
            AddEntity46(modelBuilder);
            AddEntity47(modelBuilder);
            AddEntity48(modelBuilder);
            AddEntity49(modelBuilder);
            AddEntity50(modelBuilder);
            AddEntity51(modelBuilder);
            AddEntity52(modelBuilder);
            AddEntity53(modelBuilder);
            AddEntity54(modelBuilder);
            AddEntity55(modelBuilder);
            AddEntity56(modelBuilder);
        }
    }
}
