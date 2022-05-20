namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_nSerial
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? SerialID { get; set; }

        [Required]
        [StringLength(100)]
        public string SerialNumber { get; set; }

        [StringLength(100)]
        public string ManufactureNumber { get; set; }

        public bool? Activated { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }

        [StringLength(100)]
        public string LotNumber { get; set; }

        public DateTime? ManufacturingDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public int? OptimisticLockField { get; set; }

        public int ID { get; set; }

        public int? MasterItem { get; set; }

        public int? UOM { get; set; }

        public int? MasterLocation { get; set; }

        public int? UOMID { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? RequiredSerialQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? RequiredSerialQuantityCurrentLevel { get; set; }

        public int? TotalSerialsCreated { get; set; }

        public int? ReservedSerial { get; set; }

        public bool? IsFromBarcode { get; set; }

        [StringLength(100)]
        public string EPCIS_SerialNumber { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_ReserveSerial DIO_ReserveSerial { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
