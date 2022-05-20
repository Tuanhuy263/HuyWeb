namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_MasterBOL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_MasterBOL()
        {
            DIO_ASNBOL = new HashSet<DIO_ASNBOL>();
            DIO_BOLCarrierInfo = new HashSet<DIO_BOLCarrierInfo>();
            DIO_BOLCustomerInfo = new HashSet<DIO_BOLCustomerInfo>();
            DIO_MasterBOL1 = new HashSet<DIO_MasterBOL>();
        }

        public int ID { get; set; }

        public string StoreBills { get; set; }

        public string SONumbers { get; set; }

        public string PONumbers { get; set; }

        [StringLength(255)]
        public string MasterBOL { get; set; }

        [StringLength(255)]
        public string Carrier { get; set; }

        [StringLength(50)]
        public string TrackingNumber { get; set; }

        [StringLength(255)]
        public string MasterPro { get; set; }

        [StringLength(50)]
        public string SealNumber { get; set; }

        [StringLength(50)]
        public string Container { get; set; }

        [StringLength(50)]
        public string VICSBillOfLadingNumber { get; set; }

        [StringLength(255)]
        public string FreightChargeTerms { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        public int? ShipFromID { get; set; }

        [StringLength(50)]
        public string ShipFromPhone { get; set; }

        [StringLength(50)]
        public string ShipFromEmail { get; set; }

        [StringLength(5)]
        public string ShipFromFOB { get; set; }

        public int? ShipToID { get; set; }

        [StringLength(5)]
        public string ShipToFOB { get; set; }

        public int? BillToID { get; set; }

        [StringLength(250)]
        public string SpecialInstruction { get; set; }

        [StringLength(255)]
        public string DriverName { get; set; }

        public int? HubID { get; set; }

        [StringLength(255)]
        public string TrackingURL { get; set; }

        [StringLength(250)]
        public string TrackingInformation { get; set; }

        [StringLength(255)]
        public string FilePath { get; set; }

        [StringLength(50)]
        public string SCACCode { get; set; }

        [StringLength(50)]
        public string DriverIdentication { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string SID { get; set; }

        [StringLength(100)]
        public string CID { get; set; }

        [StringLength(10)]
        public string TrailerLoaded { get; set; }

        [StringLength(10)]
        public string FreightCounted { get; set; }

        [StringLength(1)]
        public string AttachedUnderlyingBOL { get; set; }

        [StringLength(100)]
        public string ShipToAttn { get; set; }

        [StringLength(100)]
        public string BillToAttn { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? DeliveryTime { get; set; }

        [StringLength(500)]
        public string DeliveryConfirmation { get; set; }

        [StringLength(100)]
        public string LoadNumber { get; set; }

        [StringLength(100)]
        public string InternalID { get; set; }

        public bool? IsPrinted { get; set; }

        public byte? Status { get; set; }

        public int? MasterBOLID { get; set; }

        public bool? IsSent { get; set; }

        public bool? IsImported { get; set; }

        [StringLength(100)]
        public string NMFC { get; set; }

        [StringLength(100)]
        public string Class { get; set; }

        [StringLength(100)]
        public string ShippingMethod { get; set; }

        [StringLength(100)]
        public string TransportationMethod { get; set; }

        public int? NoOfOriginalBOL { get; set; }

        [StringLength(100)]
        public string NoOfOriginalBOLText { get; set; }

        [StringLength(100)]
        public string LotNumber { get; set; }

        [StringLength(100)]
        public string FMCNumber { get; set; }

        [StringLength(100)]
        public string HBLNumber { get; set; }

        [StringLength(100)]
        public string SCAC { get; set; }

        [StringLength(100)]
        public string ShipperRefNo { get; set; }

        [StringLength(100)]
        public string PlaceOfReceipt { get; set; }

        [StringLength(100)]
        public string PreCarriage { get; set; }

        [StringLength(100)]
        public string Instructions { get; set; }

        [StringLength(100)]
        public string InLandRouting { get; set; }

        [StringLength(100)]
        public string SummaryColorDescription { get; set; }

        public string SOOriginalNumbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ASNBOL> DIO_ASNBOL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BOLCarrierInfo> DIO_BOLCarrierInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BOLCustomerInfo> DIO_BOLCustomerInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterBOL> DIO_MasterBOL1 { get; set; }

        public virtual DIO_MasterBOL DIO_MasterBOL2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }
    }
}
