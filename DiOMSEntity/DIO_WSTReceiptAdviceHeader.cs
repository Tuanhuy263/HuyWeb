namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTReceiptAdviceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WSTReceiptAdviceHeader()
        {
            DIO_WSTReceiptAdviceCarton = new HashSet<DIO_WSTReceiptAdviceCarton>();
            DIO_WSTReceiptAdvicePallet = new HashSet<DIO_WSTReceiptAdvicePallet>();
            DIO_WSTReceiptAdvicePO = new HashSet<DIO_WSTReceiptAdvicePO>();
            DIS_PurchaseInvoiceHeader1 = new HashSet<DIS_PurchaseInvoiceHeader>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WSTReceiptAdviceHeaderID { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(8)]
        public string CreateTime { get; set; }

        [StringLength(100)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        [StringLength(5)]
        public string PackageCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? LadingQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? WeightUOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? CalculatedWeight { get; set; }

        [StringLength(2)]
        public string ReceiptStatusCode { get; set; }

        [StringLength(2)]
        public string ReceiptMethodOfPayment { get; set; }

        [StringLength(30)]
        public string BolNumber { get; set; }

        [StringLength(264)]
        public string ProNumber { get; set; }

        [StringLength(2)]
        public string ShippedTimeCode { get; set; }

        public DateTime? PickedupDate { get; set; }

        public DateTime? ScheduleDeliveryDate { get; set; }

        [StringLength(255)]
        public string VendorCodeDuns { get; set; }

        [StringLength(80)]
        public string ShipToQualifier { get; set; }

        [StringLength(50)]
        public string ShipToFacility { get; set; }

        [StringLength(80)]
        public string ShipFromQualifier { get; set; }

        [StringLength(30)]
        public string MasterBillOfLading { get; set; }

        [StringLength(255)]
        public string MasterReference { get; set; }

        [StringLength(255)]
        public string LinkSequence { get; set; }

        [StringLength(50)]
        public string WarehouseCodeType { get; set; }

        [StringLength(50)]
        public string DepositorCodeType { get; set; }

        [StringLength(50)]
        public string EquipmentInitial { get; set; }

        [StringLength(50)]
        public string EquipmentNo { get; set; }

        [StringLength(255)]
        public string TraceStatus { get; set; }

        [StringLength(4000)]
        public string ReceiptID { get; set; }

        [StringLength(8)]
        public string ShipTimeCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        [Column(TypeName = "money")]
        public decimal? VolumeUOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReceiptTotalUnitShipped { get; set; }

        [StringLength(50)]
        public string VendorEmailContact { get; set; }

        [StringLength(50)]
        public string VendorContactName { get; set; }

        [StringLength(50)]
        public string VendorContactPhone { get; set; }

        [StringLength(50)]
        public string TransactionPurposeCode { get; set; }

        [StringLength(255)]
        public string TransportationType { get; set; }

        public bool? IsPallet { get; set; }

        [StringLength(50)]
        public string Receiver { get; set; }

        public DateTime? ReceivedDate { get; set; }

        [StringLength(8)]
        public string ReceivedTime { get; set; }

        [StringLength(50)]
        public string SCACCode { get; set; }

        [StringLength(500)]
        public string SpecialInstruction { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        [StringLength(8)]
        public string ScheduleDeliveryTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightChargeAmount { get; set; }

        public int? Status { get; set; }

        [StringLength(100)]
        public string OldLocation { get; set; }

        [StringLength(100)]
        public string OldLocationDescription { get; set; }

        public int? ShipmentID { get; set; }

        public int? Location { get; set; }

        public int? HubId { get; set; }

        public int? RemitToAddressId { get; set; }

        public int? ShipToAddressId { get; set; }

        public int? ShipFromAddressId { get; set; }

        public int? BillToAddressId { get; set; }

        public int? FOBPaymentId { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumeUOM { get; set; }

        public int? PackageTypeId { get; set; }

        public int? ProviderId { get; set; }

        public int? TransportMethodId { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ReportingType { get; set; }

        [StringLength(100)]
        public string SenderID { get; set; }

        [StringLength(100)]
        public string ReceiptTimeType { get; set; }

        [StringLength(100)]
        public string ReceiptNumber { get; set; }

        public int? TotalLineNumber { get; set; }

        public int? TotalCarton { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalReceivedQty { get; set; }

        [StringLength(255)]
        public string ContainerNo { get; set; }

        [StringLength(255)]
        public string TrailerNo { get; set; }

        [StringLength(255)]
        public string InvoiceNo { get; set; }

        public int? PurchaseInvoiceHeaderNo { get; set; }

        [StringLength(250)]
        public string SupplierName { get; set; }

        public bool? IsSentEDI { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        public virtual DIO_PackageType DIO_PackageType { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceCarton> DIO_WSTReceiptAdviceCarton { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_PurchaseInvoiceHeader DIS_PurchaseInvoiceHeader { get; set; }

        public virtual DIO_WSTShipmentAdviceHeader DIO_WSTShipmentAdviceHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePallet> DIO_WSTReceiptAdvicePallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePO> DIO_WSTReceiptAdvicePO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceHeader> DIS_PurchaseInvoiceHeader1 { get; set; }
    }
}
