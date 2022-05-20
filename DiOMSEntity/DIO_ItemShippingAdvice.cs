namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ItemShippingAdvice
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LineItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? CountQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQty { get; set; }

        public byte? Status { get; set; }

        public bool? NPIsUsedInTransaction { get; set; }

        public int? MasterLocationID { get; set; }

        public int? WHShippingAdviceDetailID { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_WHShippingAdviceDetail DIO_WHShippingAdviceDetail { get; set; }
    }
}
