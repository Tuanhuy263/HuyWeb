namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReturnShipmentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReturnShipmentDetail()
        {
            DIO_ReturnShipmentBatch = new HashSet<DIO_ReturnShipmentBatch>();
            DIO_ReturnShipmentSerial = new HashSet<DIO_ReturnShipmentSerial>();
        }

        [Key]
        public int ReturnShipmentDetailNo { get; set; }

        public int ReturnShipmentNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? ReturnQuantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? MasterLocationID { get; set; }

        public int? SaleOrderDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReturnFee { get; set; }

        public int? RMAType { get; set; }

        [StringLength(100)]
        public string LOT { get; set; }

        [StringLength(350)]
        public string Reason { get; set; }

        [StringLength(100)]
        public string NPUOMCode { get; set; }

        [StringLength(100)]
        public string UOMCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        public virtual DIO_ReturnShipment DIO_ReturnShipment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipmentBatch> DIO_ReturnShipmentBatch { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnShipmentSerial> DIO_ReturnShipmentSerial { get; set; }
    }
}
