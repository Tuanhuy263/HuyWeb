namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RepackSerialDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RepackSerialDetailID { get; set; }

        [StringLength(30)]
        public string SerialNumber { get; set; }

        [StringLength(30)]
        public string ParentSerial { get; set; }

        [StringLength(20)]
        public string OldParentSerial { get; set; }

        public int? RepackSerialItemID { get; set; }

        public int? OldParentUOMID { get; set; }

        public int? ParentUOM { get; set; }

        public int? UOMID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ParentManufactureNumber { get; set; }

        [StringLength(100)]
        public string ParentLotNumber { get; set; }

        public DateTime? ParentManufacturingDate { get; set; }

        public DateTime? ParentExpiredDate { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIO_RepackSerialItem DIO_RepackSerialItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }
    }
}
