namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RoutingRequestHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RoutingRequestHeader()
        {
            DIO_RoutingRequestDetail = new HashSet<DIO_RoutingRequestDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RoutingRequestHeaderId { get; set; }

        [StringLength(20)]
        public string TransactionControlNo { get; set; }

        [StringLength(3)]
        public string TransType { get; set; }

        [StringLength(20)]
        public string TransPurposeCode { get; set; }

        [StringLength(50)]
        public string RoutingRequestNo { get; set; }

        public DateTime? TransDate { get; set; }

        [StringLength(4)]
        public string TransTime { get; set; }

        [StringLength(2)]
        public string TimeCode { get; set; }

        [StringLength(60)]
        public string ContactName { get; set; }

        [StringLength(256)]
        public string ContactTel { get; set; }

        [StringLength(100)]
        public string ContactEmail { get; set; }

        [StringLength(60)]
        public string ShipFromName { get; set; }

        [StringLength(80)]
        public string ShipFromCode { get; set; }

        [StringLength(2)]
        public string ShipFromCodeQualifier { get; set; }

        [StringLength(200)]
        public string ShipFromAddress1 { get; set; }

        [StringLength(255)]
        public string ShipFromAddress2 { get; set; }

        [StringLength(255)]
        public string ShipFromCity { get; set; }

        [StringLength(255)]
        public string ShipFromState { get; set; }

        [StringLength(255)]
        public string ShipFromZipcode { get; set; }

        [StringLength(255)]
        public string ShipFromCountry { get; set; }

        public byte? Status { get; set; }

        [StringLength(40)]
        public string ShipmentId { get; set; }

        public bool? IsSentEdi { get; set; }

        public DateTime? EdiExportTime { get; set; }

        public int? ASNNo { get; set; }

        public int? TransactionSetPurposeId { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string HubCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RoutingRequestDetail> DIO_RoutingRequestDetail { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIO_TransactionSetPurpose DIO_TransactionSetPurpose { get; set; }
    }
}
