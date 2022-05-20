namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PTSASN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PTSASN()
        {
            DIO_PTSASNSO = new HashSet<DIO_PTSASNSO>();
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

        [StringLength(80)]
        public string ShipToQualifier { get; set; }

        [StringLength(80)]
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

        public int? ObjectType { get; set; }

        public bool? IsPallet { get; set; }

        [StringLength(50)]
        public string SCACCode { get; set; }

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

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSASNSO> DIO_PTSASNSO { get; set; }
    }
}
