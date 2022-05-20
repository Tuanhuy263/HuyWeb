namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackingOrderStatusHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_TrackingOrderStatusHeader()
        {
            DIO_TrackingOrderStatusDetail = new HashSet<DIO_TrackingOrderStatusDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? Status { get; set; }

        public int? SONo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string Doc870No { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingOrderStatusDetail> DIO_TrackingOrderStatusDetail { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }
    }
}
