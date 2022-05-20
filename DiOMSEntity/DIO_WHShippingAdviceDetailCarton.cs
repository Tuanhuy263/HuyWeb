namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHShippingAdviceDetailCarton
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHShippingAdviceDetailCartonID { get; set; }

        public int? CartonID { get; set; }

        public int? WHShippingAdviceDetailID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }

        public virtual DIO_WHShippingAdviceDetail DIO_WHShippingAdviceDetail { get; set; }
    }
}
