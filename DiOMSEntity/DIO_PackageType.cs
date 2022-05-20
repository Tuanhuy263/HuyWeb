namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackageType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackageType()
        {
            DIO_WSTReceiptAdviceHeader = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIO_WSTShipmentAdviceHeader = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIS_ASN = new HashSet<DIS_ASN>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PackageTypeID { get; set; }

        [StringLength(250)]
        public string PackageTypeCode { get; set; }

        [StringLength(250)]
        public string PackageTypeName { get; set; }

        public int? TransportationProviderID { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? Length { get; set; }

        [Column(TypeName = "money")]
        public decimal? Width { get; set; }

        [Column(TypeName = "money")]
        public decimal? Height { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        public int? LengthUOMID { get; set; }

        public int? WeightUOMID { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN { get; set; }
    }
}
