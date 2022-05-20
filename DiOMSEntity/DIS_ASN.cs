namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_ASN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_ASN()
        {
            DIO_ASNBOL = new HashSet<DIO_ASNBOL>();
            DIO_ASNInvoice = new HashSet<DIO_ASNInvoice>();
            DIO_Historical_Info = new HashSet<DIO_Historical_Info>();
            DIO_Historical_Info1 = new HashSet<DIO_Historical_Info>();
            DIO_OrderStatusReport870Header = new HashSet<DIO_OrderStatusReport870Header>();
            DIO_PackDetail = new HashSet<DIO_PackDetail>();
            DIO_PackHeader = new HashSet<DIO_PackHeader>();
            DIO_PickHeader1 = new HashSet<DIO_PickHeader>();
            DIO_RoutingRequestHeader = new HashSet<DIO_RoutingRequestHeader>();
            DIO_WHOrderHeader = new HashSet<DIO_WHOrderHeader>();
            DIO_WHRecipientNoticeHeader = new HashSet<DIO_WHRecipientNoticeHeader>();
            DIO_WHShippingAdviceHeader = new HashSet<DIO_WHShippingAdviceHeader>();
            DIO_WHStockIn = new HashSet<DIO_WHStockIn>();
            DIO_WHStockOut = new HashSet<DIO_WHStockOut>();
            DIO_WSTReceiptAdviceCarton = new HashSet<DIO_WSTReceiptAdviceCarton>();
            DIO_WSTReceiptAdvicePalletPO = new HashSet<DIO_WSTReceiptAdvicePalletPO>();
            DIO_WSTReceiptAdvicePO = new HashSet<DIO_WSTReceiptAdvicePO>();
            DIO_WSTShipmentAdviceCarton = new HashSet<DIO_WSTShipmentAdviceCarton>();
            DIO_WSTShipmentAdvicePalletPO = new HashSet<DIO_WSTShipmentAdvicePalletPO>();
            DIO_WSTShipmentAdvicePO = new HashSet<DIO_WSTShipmentAdvicePO>();
            DIS_ASN1 = new HashSet<DIS_ASN>();
            DIS_ASN11 = new HashSet<DIS_ASN>();
            DIS_PurchaseInvoiceHeader1 = new HashSet<DIS_PurchaseInvoiceHeader>();
            InboundOutboundASNHeaders = new HashSet<InboundOutboundASNHeader>();
            InboundOutboundASNHeaders1 = new HashSet<InboundOutboundASNHeader>();
            DIS_ASNPO = new HashSet<DIS_ASNPO>();
            DIS_ASNSO = new HashSet<DIS_ASNSO>();
            DIS_SaleInvoiceHeader = new HashSet<DIS_SaleInvoiceHeader>();
        }

        [Key]
        public int ASNNo { get; set; }

        public int? HubID { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(8)]
        public string CreateTime { get; set; }

        [StringLength(5)]
        public string PackageCode { get; set; }

        public decimal? LadingQty { get; set; }

        public decimal? Weight { get; set; }

        public int? WeightUOM { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        [StringLength(2)]
        public string ShipmentStatusCode { get; set; }

        [StringLength(30)]
        public string BolNumber { get; set; }

        [StringLength(264)]
        public string ProNumber { get; set; }

        [StringLength(255)]
        public string LoadNumber { get; set; }

        public DateTime? ShippedDate { get; set; }

        [StringLength(8)]
        public string ShippedTime { get; set; }

        public DateTime? ScheduleDeliveryDate { get; set; }

        public int? FOBPaymentID { get; set; }

        [StringLength(255)]
        public string VendorCodeDuns { get; set; }

        [StringLength(255)]
        public string VendorEmailContact { get; set; }

        [StringLength(100)]
        public string ShipToQualifier { get; set; }

        [StringLength(100)]
        public string ShipFromQualifier { get; set; }

        [StringLength(30)]
        public string MasterBillOfLading { get; set; }

        [StringLength(255)]
        public string PortOfEntry { get; set; }

        public byte? Status { get; set; }

        [StringLength(255)]
        public string TraceStatus { get; set; }

        public int? ASNType { get; set; }

        public int? DICentral { get; set; }

        [StringLength(8)]
        public string ShipTimeCode { get; set; }

        public decimal? Volume { get; set; }

        public int? VolumeUOM { get; set; }

        public decimal? PalletLadingQty { get; set; }

        [StringLength(50)]
        public string POReleaseOrderNo { get; set; }

        public decimal? ShipmentToTALASQ { get; set; }

        [StringLength(50)]
        public string POContractNo { get; set; }

        [StringLength(50)]
        public string VendorContactName { get; set; }

        [StringLength(50)]
        public string VendorContactPhone { get; set; }

        [StringLength(50)]
        public string ShipToFacility { get; set; }

        [StringLength(50)]
        public string TransactionPurposeCode { get; set; }

        public int? RemitToAddressID { get; set; }

        public int? ShipToAddressID { get; set; }

        public int? ShipFromAddressID { get; set; }

        public int? BillToAddressID { get; set; }

        [StringLength(255)]
        public string FOB { get; set; }

        public int? ObjectType { get; set; }

        public bool? IsPallet { get; set; }

        [StringLength(50)]
        public string SCACCode { get; set; }

        [StringLength(255)]
        public string Carrier { get; set; }

        public bool? GeneratedSI { get; set; }

        [StringLength(4000)]
        public string ShipmentID { get; set; }

        public decimal? CalculatedWeight { get; set; }

        public decimal? CalculatedVolume { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string Receiver { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public int? MasterEventSONo { get; set; }

        [StringLength(500)]
        public string SpecialInstruction { get; set; }

        public int? ExceptionType { get; set; }

        public bool? FloorLoaded { get; set; }

        public bool? PrintPackingSlip { get; set; }

        public bool? PrintPackingInstruction { get; set; }

        public DateTime? ReplicationDate { get; set; }

        public bool? PickingASNWithoutPDA { get; set; }

        [StringLength(8)]
        public string ScheduleDeliveryTime { get; set; }

        public int? PackageTypeID { get; set; }

        public bool? IsShipped { get; set; }

        public int? ProviderID { get; set; }

        public int? TransportMethodID { get; set; }

        [StringLength(255)]
        public string UserDefined55 { get; set; }

        [StringLength(255)]
        public string UserDefined63 { get; set; }

        [StringLength(255)]
        public string UserDefined77 { get; set; }

        [StringLength(255)]
        public string UserDefined111 { get; set; }

        [StringLength(10)]
        public string OrderStatusCode { get; set; }

        [StringLength(10)]
        public string MerchandiseTypeCode { get; set; }

        public int? POLineNumber { get; set; }

        public int? MasterASNID { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        public bool? CreatedBOL { get; set; }

        [StringLength(255)]
        public string TransportationType { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightChargeAmount { get; set; }

        [StringLength(255)]
        public string EquipmentInitial { get; set; }

        [StringLength(255)]
        public string EquipmentNumber { get; set; }

        [StringLength(255)]
        public string EDISaleInvoiceNumber { get; set; }

        public bool? IsDropShip { get; set; }

        public bool? IsGeneratePI { get; set; }

        public int? PINo { get; set; }

        public int? OutboundASNNo { get; set; }

        public bool? CreateFromInboudASN { get; set; }

        [StringLength(100)]
        public string Forwarder { get; set; }

        [StringLength(100)]
        public string Vessel { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        [StringLength(100)]
        public string TrackingNo { get; set; }

        public DateTime? MustArriveDate { get; set; }

        public int? PrintUCCLabelStatus { get; set; }

        public int? STShipmentID { get; set; }

        [StringLength(250)]
        public string ManifestNo { get; set; }

        [StringLength(250)]
        public string SerialTrailerNo { get; set; }

        [StringLength(250)]
        public string SOPackingCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPOWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPOVolumn { get; set; }

        public DateTime? SalesOrderDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOLadingQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOLadingWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOLadingVolumn { get; set; }

        public DateTime? ActualShipDate { get; set; }

        public bool? IsDeletedByUser { get; set; }

        public int? WHShipmentAdviceID { get; set; }

        [StringLength(1000)]
        public string ShipmentIDOf943 { get; set; }

        public bool? SentWooCommerce { get; set; }

        [StringLength(50)]
        public string ServiceType { get; set; }

        [StringLength(200)]
        public string ShipmentIDByCarrier { get; set; }

        public byte[] BOLImage { get; set; }

        public int? PickHeaderNo { get; set; }

        public bool? IsFromSI { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        [StringLength(100)]
        public string MemDeliver { get; set; }

        [StringLength(100)]
        public string MemPayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? Height { get; set; }

        public int? HeightUOM { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(100)]
        public string TrailerNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        public int? TotalWeightUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLadingQty { get; set; }

        public int? TotalLadingQtyUOM { get; set; }

        public int? TotalVolumeUOM { get; set; }

        [StringLength(255)]
        public string AmazonReferenceNumber { get; set; }

        public bool? CreateFromInboundASN { get; set; }

        [StringLength(255)]
        public string SOOriginalNumber { get; set; }

        public bool? CancelNote { get; set; }

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

        [StringLength(100)]
        public string ShipFromLocationDuns { get; set; }

        [StringLength(50)]
        public string ServiceName { get; set; }

        public int? TypeOfService { get; set; }

        public byte? ECommerce { get; set; }

        public byte? SentUPSStatus { get; set; }

        [StringLength(3000)]
        public string UPSErrorMessage { get; set; }

        public int? RequireSendASN { get; set; }

        [StringLength(500)]
        public string UPS_Status_Type_Description { get; set; }

        public byte? UPS_Status_Type { get; set; }

        public byte? UPS_Status_Type_Code { get; set; }

        public int? MasterItemID { get; set; }

        [StringLength(3000)]
        public string FedexErrorMessage { get; set; }

        public byte? SentFedexStatus { get; set; }

        [StringLength(500)]
        public string Fedex_Status_Track_Description { get; set; }

        [StringLength(10)]
        public string Fedex_Status_Track_Code { get; set; }

        public DateTime? SentDateTimeToCarrier { get; set; }

        public DateTime? RespondedDateTimeFromCarrier { get; set; }

        public byte? TrackingStatus { get; set; }

        [StringLength(3000)]
        public string CarrierErrorMessage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ASNBOL> DIO_ASNBOL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ASNInvoice> DIO_ASNInvoice { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Historical_Info> DIO_Historical_Info { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Historical_Info> DIO_Historical_Info1 { get; set; }

        public virtual DIO_MasterEventSO DIO_MasterEventSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderStatusReport870Header> DIO_OrderStatusReport870Header { get; set; }

        public virtual DIO_PackageType DIO_PackageType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetail> DIO_PackDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackHeader> DIO_PackHeader { get; set; }

        public virtual DIO_PickHeader DIO_PickHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickHeader> DIO_PickHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RoutingRequestHeader> DIO_RoutingRequestHeader { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIO_TypeOfService DIO_TypeOfService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderHeader> DIO_WHOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHRecipientNoticeHeader> DIO_WHRecipientNoticeHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockIn> DIO_WHStockIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOut> DIO_WHStockOut { get; set; }

        public virtual DIO_WHStockOut DIO_WHStockOut1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceCarton> DIO_WSTReceiptAdviceCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePalletPO> DIO_WSTReceiptAdvicePalletPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePO> DIO_WSTReceiptAdvicePO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceCarton> DIO_WSTShipmentAdviceCarton { get; set; }

        public virtual DIO_WSTShipmentAdviceHeader DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePalletPO> DIO_WSTShipmentAdvicePalletPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePO> DIO_WSTShipmentAdvicePO { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN1 { get; set; }

        public virtual DIS_ASN DIS_ASN2 { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN11 { get; set; }

        public virtual DIS_ASN DIS_ASN3 { get; set; }

        public virtual DIS_PurchaseInvoiceHeader DIS_PurchaseInvoiceHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundOutboundASNHeader> InboundOutboundASNHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundOutboundASNHeader> InboundOutboundASNHeaders1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure4 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure5 { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNPO> DIS_ASNPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNSO> DIS_ASNSO { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader { get; set; }
    }
}
