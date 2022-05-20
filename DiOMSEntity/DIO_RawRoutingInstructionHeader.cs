namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawRoutingInstructionHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawRoutingInstructionHeader()
        {
            DIO_RawRoutingInstructionDetail = new HashSet<DIO_RawRoutingInstructionDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RoutingInstructionHeaderID { get; set; }

        [StringLength(20)]
        public string TransactionControlNo { get; set; }

        [StringLength(3)]
        public string TransType { get; set; }

        [StringLength(2)]
        public string TransPurposeCode { get; set; }

        [StringLength(50)]
        public string RoutingRequestNo { get; set; }

        public DateTime? TransDate { get; set; }

        [StringLength(4)]
        public string TransTime { get; set; }

        [StringLength(2)]
        public string TimeCode { get; set; }

        [StringLength(50)]
        public string RoutingInstructionNo { get; set; }

        [StringLength(60)]
        public string ContactName { get; set; }

        [StringLength(256)]
        public string ContactTel { get; set; }

        [StringLength(100)]
        public string ContactEmail { get; set; }

        [StringLength(80)]
        public string SCACCode { get; set; }

        [StringLength(60)]
        public string CarrierName { get; set; }

        [StringLength(255)]
        public string ShipFromName { get; set; }

        [StringLength(255)]
        public string ShipFromCode { get; set; }

        [StringLength(200)]
        public string ShipFromAddress1 { get; set; }

        [StringLength(200)]
        public string ShipFromAddress2 { get; set; }

        [StringLength(255)]
        public string ShipFromCity { get; set; }

        [StringLength(255)]
        public string ShipFromState { get; set; }

        [StringLength(255)]
        public string ShipFromZipcode { get; set; }

        [StringLength(255)]
        public string ShipFromCountry { get; set; }

        [StringLength(255)]
        public string ShipFromLocationQualifier { get; set; }

        [StringLength(255)]
        public string ShipFromLocationCode { get; set; }

        public int? ConfirmedASN { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(200)]
        public string ARNNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawRoutingInstructionDetail> DIO_RawRoutingInstructionDetail { get; set; }
    }
}
