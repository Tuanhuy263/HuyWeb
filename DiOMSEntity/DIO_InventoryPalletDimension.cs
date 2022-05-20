namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryPalletDimension
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(225)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? Length { get; set; }

        [Column(TypeName = "money")]
        public decimal? Width { get; set; }

        [Column(TypeName = "money")]
        public decimal? Height { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        public int? UOM { get; set; }

        public int? WeightUOM { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }
    }
}
