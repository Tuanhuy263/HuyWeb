namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw943Header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Raw943Header()
        {
            DIO_Raw943Carton = new HashSet<DIO_Raw943Carton>();
            DIO_Raw943LineItem = new HashSet<DIO_Raw943LineItem>();
            DIO_Raw943Pallet = new HashSet<DIO_Raw943Pallet>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHRawShipmentID { get; set; }

        [StringLength(100)]
        public string ReceiverID { get; set; }

        [StringLength(100)]
        public string ShipmentID { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(100)]
        public string CreateTime { get; set; }

        [StringLength(100)]
        public string PackageCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? LadingQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [StringLength(100)]
        public string WeightUOM { get; set; }

        [StringLength(100)]
        public string ScacCode { get; set; }

        [StringLength(100)]
        public string TransportationType { get; set; }

        [StringLength(100)]
        public string CarrierName { get; set; }

        [StringLength(100)]
        public string ShipmentStatusCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? PalletLadingQty { get; set; }

        [StringLength(100)]
        public string BolNumber { get; set; }

        [StringLength(100)]
        public string Pro_InvoiceNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShipmentTotalVolume { get; set; }

        [StringLength(100)]
        public string LoadNumber { get; set; }

        public DateTime? ShippedDate { get; set; }

        [StringLength(100)]
        public string ShippedTime { get; set; }

        [StringLength(100)]
        public string ShippedTimeCode { get; set; }

        public DateTime? ScheduledDeliveryDate { get; set; }

        [StringLength(100)]
        public string PaymentMethod { get; set; }

        [StringLength(100)]
        public string RemitToCode { get; set; }

        [StringLength(100)]
        public string RemitToName { get; set; }

        [StringLength(100)]
        public string RemitToAddress { get; set; }

        [StringLength(100)]
        public string RemitToCity { get; set; }

        [StringLength(100)]
        public string RemitToZipCode { get; set; }

        [StringLength(100)]
        public string RemitToCountry { get; set; }

        [StringLength(100)]
        public string Duns { get; set; }

        [StringLength(100)]
        public string CustomerID { get; set; }

        [StringLength(100)]
        public string ShipmentTotalUnitShipped { get; set; }

        [StringLength(100)]
        public string POReleaseOrderNo { get; set; }

        [StringLength(100)]
        public string POContractNumber { get; set; }

        [StringLength(100)]
        public string VendorContactName { get; set; }

        [StringLength(100)]
        public string VendorContactEmail { get; set; }

        [StringLength(100)]
        public string VendorContactPhone { get; set; }

        [StringLength(100)]
        public string ShipToName { get; set; }

        [StringLength(100)]
        public string ShipToAddress1 { get; set; }

        [StringLength(100)]
        public string ShipToAddress2 { get; set; }

        [StringLength(100)]
        public string ShipToCity { get; set; }

        [StringLength(100)]
        public string ShipToState { get; set; }

        [StringLength(100)]
        public string ShipToZipCode { get; set; }

        [StringLength(100)]
        public string ShipToCountry { get; set; }

        [StringLength(100)]
        public string ShipToLocationQualifier { get; set; }

        [StringLength(100)]
        public string ShipToLocationNumber { get; set; }

        [StringLength(100)]
        public string ShipFromName { get; set; }

        [StringLength(100)]
        public string ShipFromAddress { get; set; }

        [StringLength(100)]
        public string ShipFromCity { get; set; }

        [StringLength(100)]
        public string ShipFromState { get; set; }

        [StringLength(100)]
        public string ShipFromZipCode { get; set; }

        [StringLength(100)]
        public string ShipFromLocationQualifier { get; set; }

        [StringLength(100)]
        public string ShipFromLocationDuns { get; set; }

        [StringLength(100)]
        public string MasterBillOfLading { get; set; }

        [StringLength(100)]
        public string ShipToFacilityCode { get; set; }

        [StringLength(100)]
        public string PortOfEntry { get; set; }

        public byte? Status { get; set; }

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

        [StringLength(255)]
        public string DepositorOrderNumber { get; set; }

        [StringLength(255)]
        public string MasterReference { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        [StringLength(100)]
        public string KeyNumber { get; set; }

        public int? WeightUOMID { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string StatusInfo { get; set; }

        [StringLength(100)]
        public string SizeInfo { get; set; }

        [StringLength(100)]
        public string ShipToCode { get; set; }

        [StringLength(100)]
        public string ShipFromCode { get; set; }

        [StringLength(100)]
        public string ShipFromAddress2 { get; set; }

        [StringLength(100)]
        public string ShipFromCountry { get; set; }

        [StringLength(255)]
        public string ContainerNo { get; set; }

        [StringLength(255)]
        public string TrailerNo { get; set; }

        [StringLength(255)]
        public string InvoiceNo { get; set; }

        public int? TransportMethodId { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalShippedQuantity { get; set; }

        [StringLength(255)]
        public string TransID { get; set; }

        [StringLength(255)]
        public string TransType { get; set; }

        public int? ShipToAddressId { get; set; }

        public int? ShipFromAddressId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943Carton> DIO_Raw943Carton { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943LineItem> DIO_Raw943LineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943Pallet> DIO_Raw943Pallet { get; set; }
    }
}
