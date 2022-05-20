namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHOrderHeader()
        {
            DIO_PickHeader = new HashSet<DIO_PickHeader>();
            DIO_PTSCarton = new HashSet<DIO_PTSCarton>();
            DIO_WHOrderDetail = new HashSet<DIO_WHOrderDetail>();
            DIO_WHStockOut = new HashSet<DIO_WHStockOut>();
        }

        [Key]
        public int WHOrderNo { get; set; }

        public int SONo { get; set; }

        public int? MasterLocationID { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public byte? Status { get; set; }

        [StringLength(250)]
        public string AdditionalName1 { get; set; }

        [StringLength(250)]
        public string AdditionalName2 { get; set; }

        [StringLength(8)]
        public string DateQualifier { get; set; }

        [StringLength(250)]
        public string NoteQualifier { get; set; }

        [StringLength(30)]
        public string ReferenceNumberQualifier { get; set; }

        public int? ShipToCode { get; set; }

        public int? ShipFromCode { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        public bool? IsPacking { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? MasterEventSONo { get; set; }

        public bool? PrintWHOrder { get; set; }

        public long? TraceStatus { get; set; }

        public bool? IsProccesedForPicking { get; set; }

        public int? ASNSOs { get; set; }

        public virtual DIO_MasterEventSO DIO_MasterEventSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickHeader> DIO_PickHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSCarton> DIO_PTSCarton { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderDetail> DIO_WHOrderDetail { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOut> DIO_WHStockOut { get; set; }
    }
}
