namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TransferHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_TransferHeader()
        {
            DIO_TransferCarton = new HashSet<DIO_TransferCarton>();
            DIO_TransferDetail = new HashSet<DIO_TransferDetail>();
            DIO_TransferDocumentHeader = new HashSet<DIO_TransferDocumentHeader>();
            DIO_TransferPallet = new HashSet<DIO_TransferPallet>();
        }

        [Key]
        public int TransferHeaderID { get; set; }

        public int? FromMasterLocationID { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public DateTime? TransferDate { get; set; }

        public DateTime? ReceiptDate { get; set; }

        public DateTime? ShipmentDate { get; set; }

        [StringLength(50)]
        public string ShipmentMethod { get; set; }

        [StringLength(50)]
        public string ShipmentAgent { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? Status { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? ArrivePlanDate { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public DateTime? PlanReceiveDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferCarton> DIO_TransferCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDetail> DIO_TransferDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferDocumentHeader> DIO_TransferDocumentHeader { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferPallet> DIO_TransferPallet { get; set; }
    }
}
