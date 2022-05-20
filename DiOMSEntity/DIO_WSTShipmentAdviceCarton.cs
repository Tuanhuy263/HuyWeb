namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTShipmentAdviceCarton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WSTShipmentAdviceCarton()
        {
            DIO_WSTShipmentAdviceLineItem = new HashSet<DIO_WSTShipmentAdviceLineItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CartonNo { get; set; }

        [StringLength(2)]
        public string ContainerQualifer { get; set; }

        [StringLength(48)]
        public string ContainerCode { get; set; }

        [StringLength(48)]
        public string OriginalContainerCode { get; set; }

        [StringLength(50)]
        public string SSC14 { get; set; }

        [StringLength(5)]
        public string SequenceNo { get; set; }

        [StringLength(20)]
        public string TransactionNumber { get; set; }

        [StringLength(50)]
        public string PackageType { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(30)]
        public string Optional1 { get; set; }

        [StringLength(30)]
        public string Optional2 { get; set; }

        [StringLength(30)]
        public string Optional3 { get; set; }

        [StringLength(30)]
        public string Optional4 { get; set; }

        [StringLength(30)]
        public string Optional5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightCharges { get; set; }

        [Column(TypeName = "money")]
        public decimal? HandlingCharges { get; set; }

        public int? Status { get; set; }

        public bool? IsVerify { get; set; }

        public bool? IsPrintUCCLabel { get; set; }

        [StringLength(100)]
        public string UserPrint { get; set; }

        [StringLength(255)]
        public string UserPack { get; set; }

        public DateTime? PrintDate { get; set; }

        [StringLength(100)]
        public string CartonLocation { get; set; }

        [StringLength(50)]
        public string PONumber { get; set; }

        [StringLength(50)]
        public string ASNNumber { get; set; }

        public int? ShipmentAdviceHeaderId { get; set; }

        public int? ShipmentAdvicePalletPOId { get; set; }

        public int? PONo { get; set; }

        public int? ASNNo { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumeUOM { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? To944 { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }

        public virtual DIO_WSTShipmentAdviceHeader DIO_WSTShipmentAdviceHeader { get; set; }

        public virtual DIO_WSTShipmentAdvicePalletPO DIO_WSTShipmentAdvicePalletPO { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceLineItem> DIO_WSTShipmentAdviceLineItem { get; set; }
    }
}
