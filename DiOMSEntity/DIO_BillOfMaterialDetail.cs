namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BillOfMaterialDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int BillOfMaterialDetailID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? BillOfMaterialID { get; set; }

        public int? ComponentItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_BillOfMaterial DIO_BillOfMaterial { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
