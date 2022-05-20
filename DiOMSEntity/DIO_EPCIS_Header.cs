namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_EPCIS_Header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_EPCIS_Header()
        {
            DIO_EPCIS_AggregationEvent = new HashSet<DIO_EPCIS_AggregationEvent>();
            DIO_EPCIS_ObjectEvent = new HashSet<DIO_EPCIS_ObjectEvent>();
            DIO_EPCIS_TransactionEvent = new HashSet<DIO_EPCIS_TransactionEvent>();
            DIO_EPCIS_Vocabulary = new HashSet<DIO_EPCIS_Vocabulary>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(5)]
        public string Version { get; set; }

        [StringLength(10)]
        public string Sender_Authority { get; set; }

        public byte? Status { get; set; }

        [StringLength(10)]
        public string Receiver_Authority { get; set; }

        [StringLength(100)]
        public string Sender { get; set; }

        [StringLength(100)]
        public string Receiver { get; set; }

        [StringLength(100)]
        public string Standard { get; set; }

        [StringLength(5)]
        public string AffirmTransactionStatement { get; set; }

        [StringLength(500)]
        public string LegalNotice { get; set; }

        [StringLength(5)]
        public string TypeVersion { get; set; }

        [StringLength(100)]
        public string Identifier { get; set; }

        [StringLength(100)]
        public string Types { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(30)]
        public string PONo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_AggregationEvent> DIO_EPCIS_AggregationEvent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_ObjectEvent> DIO_EPCIS_ObjectEvent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_TransactionEvent> DIO_EPCIS_TransactionEvent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_Vocabulary> DIO_EPCIS_Vocabulary { get; set; }
    }
}
