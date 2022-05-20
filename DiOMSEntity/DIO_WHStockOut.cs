namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHStockOut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHStockOut()
        {
            DIO_ReturnShipment = new HashSet<DIO_ReturnShipment>();
            DIS_ASN1 = new HashSet<DIS_ASN>();
            DIS_SaleInvoiceHeader = new HashSet<DIS_SaleInvoiceHeader>();
            DIO_WHStockOutDetail = new HashSet<DIO_WHStockOutDetail>();
        }

        [Key]
        public int WHStockOutNo { get; set; }

        public int? FromMasterLocationID { get; set; }

        public int? ToMasterLocationID { get; set; }

        public int? HubID { get; set; }

        [StringLength(250)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public DateTime? ShipmentDate { get; set; }

        [StringLength(20)]
        public string BillNo { get; set; }

        public int? WHOrderNo { get; set; }

        [StringLength(30)]
        public string BillOfLadingNo { get; set; }

        public int? MasterOrderNumber { get; set; }

        [StringLength(30)]
        public string ReferenceNumberQualifier { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        public byte? Status { get; set; }

        public int? SONo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? TransferDocumentHeaderID { get; set; }

        public int? ASNNO { get; set; }

        public bool? IsDropShip { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedValue { get; set; }

        [Column(TypeName = "money")]
        public decimal? HandlingCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippingCharge { get; set; }

        [Column(TypeName = "money")]
        public decimal? OtherCharge { get; set; }

        [StringLength(10)]
        public string WarehouseInvoiceNumber { get; set; }

        [StringLength(100)]
        public string WarehouseID { get; set; }

        [StringLength(255)]
        public string TrackingNumber { get; set; }

        [StringLength(255)]
        public string CarrierCode { get; set; }

        [StringLength(255)]
        public string CarrierName { get; set; }

        public bool? IsSentToShopify { get; set; }

        [StringLength(250)]
        public string SmartTurnDocumentNo { get; set; }

        public int? CRStatus { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        public int? ACKNo { get; set; }

        public bool? ConfirmedDraftASN { get; set; }

        public virtual DIO_ACKSOHeader DIO_ACKSOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipment> DIO_ReturnShipment { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_TransferDocumentHeader DIO_TransferDocumentHeader { get; set; }

        public virtual DIO_WHOrderHeader DIO_WHOrderHeader { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOutDetail> DIO_WHStockOutDetail { get; set; }
    }
}
