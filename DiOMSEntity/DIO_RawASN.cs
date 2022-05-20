namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawASN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawASN()
        {
            DIO_RawASNPO = new HashSet<DIO_RawASNPO>();
        }

        [Key]
        public int ASNNo { get; set; }

        [StringLength(255)]
        public string ReceiverID { get; set; }

        [StringLength(100)]
        public string ShipmentID { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateTime { get; set; }

        [StringLength(50)]
        public string PackageCode { get; set; }

        public decimal? LadingQty { get; set; }

        public decimal? Weight { get; set; }

        [StringLength(50)]
        public string WeightUOM { get; set; }

        [StringLength(50)]
        public string ScacCode { get; set; }

        [StringLength(255)]
        public string TransportationType { get; set; }

        [StringLength(50)]
        public string CarrierName { get; set; }

        [StringLength(50)]
        public string ShipmentStatusCode { get; set; }

        public decimal? PalletLadingQty { get; set; }

        [StringLength(50)]
        public string BolNumber { get; set; }

        [StringLength(50)]
        public string Pro_InvoiceNumber { get; set; }

        public decimal? ShipmentTotalVolume { get; set; }

        [StringLength(50)]
        public string LoadNumber { get; set; }

        public DateTime? ShippedDate { get; set; }

        [StringLength(50)]
        public string ShippedTime { get; set; }

        [StringLength(50)]
        public string ShippedTimeCode { get; set; }

        public DateTime? ScheduledDeliveryDate { get; set; }

        [StringLength(50)]
        public string ShipmentMethodOfPayment { get; set; }

        [StringLength(50)]
        public string RemitToCode { get; set; }

        [StringLength(255)]
        public string RemitToName { get; set; }

        [StringLength(255)]
        public string RemitToAddress { get; set; }

        [StringLength(255)]
        public string RemitToCity { get; set; }

        [StringLength(50)]
        public string RemitToZipCode { get; set; }

        [StringLength(255)]
        public string RemitToCountry { get; set; }

        [StringLength(50)]
        public string Duns { get; set; }

        [StringLength(255)]
        public string CustomerID { get; set; }

        [StringLength(50)]
        public string ShipmentTotalUnitShipped { get; set; }

        [StringLength(50)]
        public string POReleaseOrderNo { get; set; }

        [StringLength(50)]
        public string POContractNumber { get; set; }

        [StringLength(255)]
        public string VendorContactName { get; set; }

        [StringLength(255)]
        public string VendorContactEmail { get; set; }

        [StringLength(50)]
        public string VendorContactPhone { get; set; }

        [StringLength(255)]
        public string ShipToName { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(255)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToCity { get; set; }

        [StringLength(50)]
        public string ShipToState { get; set; }

        [StringLength(50)]
        public string ShipToZipCode { get; set; }

        [StringLength(50)]
        public string ShipToCountry { get; set; }

        [StringLength(50)]
        public string ShipToLocationNumber { get; set; }

        [StringLength(50)]
        public string ShipToLocationQualifier { get; set; }

        [StringLength(255)]
        public string ShipFromName { get; set; }

        [StringLength(255)]
        public string ShipFromAddress { get; set; }

        [StringLength(50)]
        public string ShipFromCity { get; set; }

        [StringLength(50)]
        public string ShipFromState { get; set; }

        [StringLength(50)]
        public string ShipFromZipCode { get; set; }

        [StringLength(50)]
        public string ShipFromLocationQualifier { get; set; }

        [StringLength(50)]
        public string ShipFromLocationDuns { get; set; }

        [StringLength(50)]
        public string MasterBillOfLading { get; set; }

        [StringLength(50)]
        public string PortOfEntry { get; set; }

        [StringLength(50)]
        public string PONumber { get; set; }

        [StringLength(50)]
        public string ShipToFacilityCode { get; set; }

        public byte? Status { get; set; }

        [StringLength(50)]
        public string BillToNo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

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

        [StringLength(100)]
        public string RemitToAddress2 { get; set; }

        [StringLength(100)]
        public string RemitToState { get; set; }

        [StringLength(100)]
        public string ShipFromAddress2 { get; set; }

        [StringLength(100)]
        public string ShipFromCountry { get; set; }

        [StringLength(100)]
        public string Forwarder { get; set; }

        [StringLength(100)]
        public string Vessel { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        [StringLength(100)]
        public string TrackingNo { get; set; }

        [StringLength(100)]
        public string ScheduledDeliveryTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawASNPO> DIO_RawASNPO { get; set; }
    }
}
