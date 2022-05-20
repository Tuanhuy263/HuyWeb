namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReceivingCartonItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReceivingCartonItem()
        {
            DIO_ReceivingCartonItemBatch = new HashSet<DIO_ReceivingCartonItemBatch>();
            DIO_ReceivingCartonItemSerial = new HashSet<DIO_ReceivingCartonItemSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceivingCartonItemNo { get; set; }

        public bool? IsScanned { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? ReceivingCartonNo { get; set; }

        public int? MasterItemID { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? MasterLocationID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReceiveQuantity { get; set; }

        public bool? IsAllowReceivingBigUom { get; set; }

        public virtual DIO_ReceivingCarton DIO_ReceivingCarton { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCartonItemBatch> DIO_ReceivingCartonItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCartonItemSerial> DIO_ReceivingCartonItemSerial { get; set; }
    }
}
