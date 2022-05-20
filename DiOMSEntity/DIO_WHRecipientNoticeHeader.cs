namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHRecipientNoticeHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHRecipientNoticeHeader()
        {
            DIO_WHRecipientNoticeDetail = new HashSet<DIO_WHRecipientNoticeDetail>();
            DIO_WHStockIn = new HashSet<DIO_WHStockIn>();
        }

        [Key]
        public int WHRecipientNoticeNo { get; set; }

        public int? ASNNo { get; set; }

        public int? PONo { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public int? ShipFromCode { get; set; }

        public int? ShipToCode { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        [StringLength(30)]
        public string BillOfLadingNumber { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? ExpectedReceiptDate { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        [StringLength(100)]
        public string SealNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalQty { get; set; }

        public byte? Container_Type { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        public int? TransportationProviderID { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHRecipientNoticeDetail> DIO_WHRecipientNoticeDetail { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockIn> DIO_WHStockIn { get; set; }
    }
}
