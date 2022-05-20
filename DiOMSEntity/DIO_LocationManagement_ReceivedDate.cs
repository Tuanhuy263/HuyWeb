namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LocationManagement_ReceivedDate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_LocationManagement_ReceivedDate()
        {
            DIO_SelectItemOTS_FIFO = new HashSet<DIO_SelectItemOTS_FIFO>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public int? LocManagement { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? IndividualQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? QuantityInBox { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? UsedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? UsedIndividualQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? UsedInBoxQty { get; set; }

        public virtual DIO_LocationManagement DIO_LocationManagement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SelectItemOTS_FIFO> DIO_SelectItemOTS_FIFO { get; set; }
    }
}
