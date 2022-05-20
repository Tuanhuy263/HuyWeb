namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw947Header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Raw947Header()
        {
            DIO_Raw947LineItem = new HashSet<DIO_Raw947LineItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        [Key]
        public int WHIAAHRawID { get; set; }

        [StringLength(100)]
        public string DocumentNumber { get; set; }

        public DateTime? DocumentDate { get; set; }

        public int? MasterLocationID { get; set; }

        public byte? Status { get; set; }

        [StringLength(100)]
        public string TransactionTypeCode { get; set; }

        [StringLength(100)]
        public string TransactionPurposeCode { get; set; }

        [StringLength(100)]
        public string AccountCode { get; set; }

        [StringLength(100)]
        public string WarehouseCode { get; set; }

        [StringLength(100)]
        public string WarehouseName { get; set; }

        [StringLength(100)]
        public string WarehouseCountry { get; set; }

        [StringLength(100)]
        public string WarehouseCity { get; set; }

        [StringLength(100)]
        public string WarehouseState { get; set; }

        [StringLength(200)]
        public string WarehouseAddress { get; set; }

        [StringLength(100)]
        public string WarehousePhone { get; set; }

        [StringLength(100)]
        public string DepositorCode { get; set; }

        [StringLength(100)]
        public string DepositorName { get; set; }

        [StringLength(100)]
        public string DepositorCountry { get; set; }

        [StringLength(100)]
        public string DepositorCity { get; set; }

        [StringLength(100)]
        public string DepositorState { get; set; }

        [StringLength(200)]
        public string DepositorAddress { get; set; }

        [StringLength(100)]
        public string DepositorPhone { get; set; }

        [StringLength(100)]
        public string ContactCode { get; set; }

        [StringLength(100)]
        public string ContactName { get; set; }

        [StringLength(100)]
        public string ContactPhone { get; set; }

        [StringLength(100)]
        public string ContactEmail { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw947LineItem> DIO_Raw947LineItem { get; set; }
    }
}
