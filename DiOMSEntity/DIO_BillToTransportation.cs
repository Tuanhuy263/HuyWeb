namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BillToTransportation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_BillToTransportation()
        {
            DIO_CarrierInfo = new HashSet<DIO_CarrierInfo>();
            DIO_OrderChangeAcknowledgmentHeader = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIS_Hub = new HashSet<DIS_Hub>();
            DIS_Hub1 = new HashSet<DIS_Hub>();
            DIS_SOHeader = new HashSet<DIS_SOHeader>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(100)]
        public string BillToCode { get; set; }

        [StringLength(100)]
        public string BillToName { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CarrierInfo> DIO_CarrierInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Hub> DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Hub> DIS_Hub1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader { get; set; }
    }
}
