namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw943Carton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Raw943Carton()
        {
            DIO_Raw943LineItem = new HashSet<DIO_Raw943LineItem>();
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

        public int? SequentialNo { get; set; }

        [StringLength(100)]
        public string ContainerCodeQualifier { get; set; }

        [StringLength(100)]
        public string ContainerCode { get; set; }

        [StringLength(100)]
        public string SSC14 { get; set; }

        public byte? Status { get; set; }

        public int? Raw943PONo { get; set; }

        public int? WHRawShipmentID { get; set; }

        public int? PalletNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        public bool? IsValidData { get; set; }

        public bool? IsIgnored { get; set; }

        public virtual DIO_Raw943Pallet DIO_Raw943Pallet { get; set; }

        public virtual DIO_Raw943PO DIO_Raw943PO { get; set; }

        public virtual DIO_Raw943Header DIO_Raw943Header { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943LineItem> DIO_Raw943LineItem { get; set; }
    }
}
