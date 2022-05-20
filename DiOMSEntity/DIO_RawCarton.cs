namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawCarton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawCarton()
        {
            DIO_RawLineItem = new HashSet<DIO_RawLineItem>();
        }

        [Key]
        public int CartonNo { get; set; }

        public int? SequentialNo { get; set; }

        [StringLength(150)]
        public string ContainerCodeQualifier { get; set; }

        [StringLength(150)]
        public string ContainerCode { get; set; }

        [StringLength(150)]
        public string SSC14 { get; set; }

        public int? ASNPONo { get; set; }

        public int? ASNPOPalletNo { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? ASNSONo { get; set; }

        public int? ASNSOPalletNo { get; set; }

        [StringLength(100)]
        public string TrackingNo { get; set; }

        public virtual DIO_RawASNPO DIO_RawASNPO { get; set; }

        public virtual DIO_RawASNPOPallet DIO_RawASNPOPallet { get; set; }

        public virtual DIO_RawSOASNSO DIO_RawSOASNSO { get; set; }

        public virtual DIO_RawSOASNSOPallet DIO_RawSOASNSOPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawLineItem> DIO_RawLineItem { get; set; }
    }
}
