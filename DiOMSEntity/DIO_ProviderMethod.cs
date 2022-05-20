namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProviderMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ProviderMethod()
        {
            DIO_ServiceProviderMethod = new HashSet<DIO_ServiceProviderMethod>();
        }

        [Key]
        public int ProviderMethodID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? TransportationProviderID { get; set; }

        public int? TransportationMethodID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ServiceProviderMethod> DIO_ServiceProviderMethod { get; set; }
    }
}
