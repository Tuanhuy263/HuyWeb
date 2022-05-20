namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TransferDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_TransferDetail()
        {
            DIO_TransferBatch = new HashSet<DIO_TransferBatch>();
            DIO_TransferSerial = new HashSet<DIO_TransferSerial>();
        }

        [Key]
        public int TransferDetailID { get; set; }

        public int TransferHeaderID { get; set; }

        public int? FromMasterLocationID { get; set; }

        public int? ToMasterLocationID { get; set; }

        public int? MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? QtyBase { get; set; }

        [StringLength(10)]
        public string UnitOfMeasure { get; set; }

        public decimal? UnitCost { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferBatch> DIO_TransferBatch { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        public virtual DIO_TransferHeader DIO_TransferHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TransferSerial> DIO_TransferSerial { get; set; }
    }
}
