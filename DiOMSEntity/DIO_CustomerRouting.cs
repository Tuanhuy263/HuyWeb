namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomerRouting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_CustomerRouting()
        {
            DIO_CustomerRoutingDetail = new HashSet<DIO_CustomerRoutingDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RoutingID { get; set; }

        [StringLength(100)]
        public string RoutingGuideName { get; set; }

        [StringLength(100)]
        public string Division { get; set; }

        [StringLength(100)]
        public string MerchandiseType { get; set; }

        public int? FreightTerm { get; set; }

        [StringLength(100)]
        public string RoutingGuideNumber { get; set; }

        [StringLength(100)]
        public string SupercedesRoutingGuideNumber { get; set; }

        public DateTime? PublishDate { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [StringLength(100)]
        public string Contact { get; set; }

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerRoutingDetail> DIO_CustomerRoutingDetail { get; set; }
    }
}
