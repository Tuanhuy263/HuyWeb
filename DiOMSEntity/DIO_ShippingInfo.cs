namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ShippingInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ShippingInfo()
        {
            DIO_ACKSOHeader = new HashSet<DIO_ACKSOHeader>();
            DIO_ACKSOHeader1 = new HashSet<DIO_ACKSOHeader>();
            DIO_BlanketPOHeader = new HashSet<DIO_BlanketPOHeader>();
            DIO_BlanketPOHeader1 = new HashSet<DIO_BlanketPOHeader>();
            DIO_BlanketPOHeader2 = new HashSet<DIO_BlanketPOHeader>();
            DIO_BlanketPOHeader3 = new HashSet<DIO_BlanketPOHeader>();
            DIO_BlanketSOHeader = new HashSet<DIO_BlanketSOHeader>();
            DIO_BlanketSOHeader1 = new HashSet<DIO_BlanketSOHeader>();
            DIO_BlanketSOHeader2 = new HashSet<DIO_BlanketSOHeader>();
            DIO_BlanketSOHeader3 = new HashSet<DIO_BlanketSOHeader>();
            DIO_BlanketSOHeader4 = new HashSet<DIO_BlanketSOHeader>();
            DIO_ERP_Store = new HashSet<DIO_ERP_Store>();
            DIO_MasterBOL = new HashSet<DIO_MasterBOL>();
            DIO_MasterBOL1 = new HashSet<DIO_MasterBOL>();
            DIO_MasterBOL2 = new HashSet<DIO_MasterBOL>();
            DIO_OrderChangeAcknowledgmentHeader = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIO_OrderChangeAcknowledgmentHeader1 = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIO_OrderChangeAcknowledgmentHeader2 = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIO_OrderChangeAcknowledgmentHeader3 = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIO_OrderChangeAcknowledgmentHeader4 = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIO_OrderChangeRequestDetail = new HashSet<DIO_OrderChangeRequestDetail>();
            DIO_OrderChangeRequestDetail1 = new HashSet<DIO_OrderChangeRequestDetail>();
            DIO_OrderChangeRequestHeader = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_OrderChangeRequestHeader1 = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_OrderChangeRequestHeader2 = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_OrderChangeRequestHeader3 = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_OrderChangeRequestHeader4 = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_OrderChangeRequestHeader5 = new HashSet<DIO_OrderChangeRequestHeader>();
            DIO_OrderStatusReport870Header = new HashSet<DIO_OrderStatusReport870Header>();
            DIO_OrderStatusReport870Header1 = new HashSet<DIO_OrderStatusReport870Header>();
            DIO_ProductActivityHeader = new HashSet<DIO_ProductActivityHeader>();
            DIO_ProductActivityHeader1 = new HashSet<DIO_ProductActivityHeader>();
            DIO_PTSASN = new HashSet<DIO_PTSASN>();
            DIO_PTSASN1 = new HashSet<DIO_PTSASN>();
            DIO_PTSASN2 = new HashSet<DIO_PTSASN>();
            DIO_PTSASN3 = new HashSet<DIO_PTSASN>();
            DIO_PurchaseTransitTime = new HashSet<DIO_PurchaseTransitTime>();
            DIO_Raw943Header = new HashSet<DIO_Raw943Header>();
            DIO_Raw943Header1 = new HashSet<DIO_Raw943Header>();
            DIO_RawOrderChangeAcknowledgmentHeader = new HashSet<DIO_RawOrderChangeAcknowledgmentHeader>();
            DIO_RawOrderChangeAcknowledgmentHeader1 = new HashSet<DIO_RawOrderChangeAcknowledgmentHeader>();
            DIO_RawOrderChangeAcknowledgmentHeader2 = new HashSet<DIO_RawOrderChangeAcknowledgmentHeader>();
            DIO_RawOrderChangeAcknowledgmentHeader3 = new HashSet<DIO_RawOrderChangeAcknowledgmentHeader>();
            DIO_ReturnReceipt = new HashSet<DIO_ReturnReceipt>();
            DIO_ReturnShipment = new HashSet<DIO_ReturnShipment>();
            DIO_SaleTransitTime = new HashSet<DIO_SaleTransitTime>();
            DIO_SaleTransitTime1 = new HashSet<DIO_SaleTransitTime>();
            DIO_WHRecipientNoticeHeader = new HashSet<DIO_WHRecipientNoticeHeader>();
            DIO_WHShippingAdviceHeader = new HashSet<DIO_WHShippingAdviceHeader>();
            DIO_WHShippingAdviceHeader1 = new HashSet<DIO_WHShippingAdviceHeader>();
            DIO_WHShippingAdviceHeader2 = new HashSet<DIO_WHShippingAdviceHeader>();
            DIO_WHShippingOrderHeader = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WHShippingOrderHeader1 = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WHShippingOrderHeader2 = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WHShippingOrderHeader3 = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WHShippingOrderHeader4 = new HashSet<DIO_WHShippingOrderHeader>();
            DIO_WSTReceiptAdviceHeader = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIO_WSTReceiptAdviceHeader1 = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIO_WSTReceiptAdviceHeader2 = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIO_WSTReceiptAdviceHeader3 = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIO_WSTReceiptAdvicePalletPO = new HashSet<DIO_WSTReceiptAdvicePalletPO>();
            DIO_WSTReceiptAdvicePalletPO1 = new HashSet<DIO_WSTReceiptAdvicePalletPO>();
            DIO_WSTReceiptAdvicePO = new HashSet<DIO_WSTReceiptAdvicePO>();
            DIO_WSTReceiptAdvicePO1 = new HashSet<DIO_WSTReceiptAdvicePO>();
            DIO_WSTShipmentAdviceHeader = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIO_WSTShipmentAdviceHeader1 = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIO_WSTShipmentAdviceHeader2 = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIO_WSTShipmentAdviceHeader3 = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIO_WSTShipmentAdvicePalletPO = new HashSet<DIO_WSTShipmentAdvicePalletPO>();
            DIO_WSTShipmentAdvicePalletPO1 = new HashSet<DIO_WSTShipmentAdvicePalletPO>();
            DIO_WSTShipmentAdvicePO = new HashSet<DIO_WSTShipmentAdvicePO>();
            DIO_WSTShipmentAdvicePO1 = new HashSet<DIO_WSTShipmentAdvicePO>();
            DIS_Hub = new HashSet<DIS_Hub>();
            DIS_POHeader = new HashSet<DIS_POHeader>();
            DIS_POHeader1 = new HashSet<DIS_POHeader>();
            DIS_PurchaseInvoiceHeader = new HashSet<DIS_PurchaseInvoiceHeader>();
            DIS_PurchaseInvoiceHeader1 = new HashSet<DIS_PurchaseInvoiceHeader>();
            DIS_PurchaseInvoiceHeader2 = new HashSet<DIS_PurchaseInvoiceHeader>();
            DIS_SaleInvoiceHeader = new HashSet<DIS_SaleInvoiceHeader>();
            DIS_SOHeader = new HashSet<DIS_SOHeader>();
            DIS_ASN = new HashSet<DIS_ASN>();
            DIS_ASN1 = new HashSet<DIS_ASN>();
            DIS_ASN2 = new HashSet<DIS_ASN>();
            DIS_ASN3 = new HashSet<DIS_ASN>();
            DIS_MasterLocation = new HashSet<DIS_MasterLocation>();
            DIS_POHeader2 = new HashSet<DIS_POHeader>();
            DIS_POHeader3 = new HashSet<DIS_POHeader>();
            DIS_PurchaseInvoiceHeader3 = new HashSet<DIS_PurchaseInvoiceHeader>();
            DIS_SaleInvoiceHeader1 = new HashSet<DIS_SaleInvoiceHeader>();
            DIS_SaleInvoiceHeader2 = new HashSet<DIS_SaleInvoiceHeader>();
            DIS_SaleInvoiceHeader3 = new HashSet<DIS_SaleInvoiceHeader>();
            DIS_SOHeader1 = new HashSet<DIS_SOHeader>();
            DIS_SOHeader2 = new HashSet<DIS_SOHeader>();
            DIS_SOHeader3 = new HashSet<DIS_SOHeader>();
            DIS_SOHeader4 = new HashSet<DIS_SOHeader>();
            DIO_WHOrderHeader = new HashSet<DIO_WHOrderHeader>();
            DIO_WHOrderHeader1 = new HashSet<DIO_WHOrderHeader>();
        }

        [Key]
        public int ShippingInfoID { get; set; }

        [StringLength(250)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string Address1 { get; set; }

        [StringLength(1000)]
        public string Address2 { get; set; }

        public int? CityID { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        public int? StateID { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string ZipCode { get; set; }

        public int? CountryID { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        public int? HubID { get; set; }

        public bool? DefaultShipping { get; set; }

        public bool? DefaultBillTo { get; set; }

        public bool? DefaultRemitTo { get; set; }

        public bool? IsStore { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        public bool? DefaultShipFrom { get; set; }

        public int? AddressTypeID { get; set; }

        [StringLength(250)]
        public string AdditionalName { get; set; }

        [StringLength(250)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string Region { get; set; }

        [StringLength(255)]
        public string AddressQualifier { get; set; }

        [StringLength(1000)]
        public string Address3 { get; set; }

        [StringLength(255)]
        public string WebSite { get; set; }

        [StringLength(255)]
        public string QBID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSOHeader> DIO_ACKSOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSOHeader> DIO_ACKSOHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPOHeader> DIO_BlanketPOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPOHeader> DIO_BlanketPOHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPOHeader> DIO_BlanketPOHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPOHeader> DIO_BlanketPOHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSOHeader> DIO_BlanketSOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSOHeader> DIO_BlanketSOHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSOHeader> DIO_BlanketSOHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSOHeader> DIO_BlanketSOHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketSOHeader> DIO_BlanketSOHeader4 { get; set; }

        public virtual DIO_City DIO_City { get; set; }

        public virtual DIO_Country DIO_Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ERP_Store> DIO_ERP_Store { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterBOL> DIO_MasterBOL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterBOL> DIO_MasterBOL1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterBOL> DIO_MasterBOL2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestDetail> DIO_OrderChangeRequestDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestDetail> DIO_OrderChangeRequestDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeRequestHeader> DIO_OrderChangeRequestHeader5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderStatusReport870Header> DIO_OrderStatusReport870Header { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderStatusReport870Header> DIO_OrderStatusReport870Header1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductActivityHeader> DIO_ProductActivityHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductActivityHeader> DIO_ProductActivityHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSASN> DIO_PTSASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSASN> DIO_PTSASN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSASN> DIO_PTSASN2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSASN> DIO_PTSASN3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PurchaseTransitTime> DIO_PurchaseTransitTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943Header> DIO_Raw943Header { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943Header> DIO_Raw943Header1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawOrderChangeAcknowledgmentHeader> DIO_RawOrderChangeAcknowledgmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawOrderChangeAcknowledgmentHeader> DIO_RawOrderChangeAcknowledgmentHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawOrderChangeAcknowledgmentHeader> DIO_RawOrderChangeAcknowledgmentHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawOrderChangeAcknowledgmentHeader> DIO_RawOrderChangeAcknowledgmentHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceipt> DIO_ReturnReceipt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipment> DIO_ReturnShipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SaleTransitTime> DIO_SaleTransitTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SaleTransitTime> DIO_SaleTransitTime1 { get; set; }

        public virtual DIO_ShippingAddressType DIO_ShippingAddressType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHRecipientNoticeHeader> DIO_WHRecipientNoticeHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceHeader> DIO_WHShippingAdviceHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingOrderHeader> DIO_WHShippingOrderHeader4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePalletPO> DIO_WSTReceiptAdvicePalletPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePalletPO> DIO_WSTReceiptAdvicePalletPO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePO> DIO_WSTReceiptAdvicePO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePO> DIO_WSTReceiptAdvicePO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePalletPO> DIO_WSTShipmentAdvicePalletPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePalletPO> DIO_WSTShipmentAdvicePalletPO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePO> DIO_WSTShipmentAdvicePO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePO> DIO_WSTShipmentAdvicePO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Hub> DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterLocation> DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader3 { get; set; }

        public virtual DIS_Hub DIS_Hub1 { get; set; }

        public virtual DIO_State DIO_State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderHeader> DIO_WHOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderHeader> DIO_WHOrderHeader1 { get; set; }
    }
}
