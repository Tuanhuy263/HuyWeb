namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SelectItemOTS_FIFO
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? SelectedQty { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public int? dioWHOrderDetail { get; set; }

        public int? dioLocReceivedDate { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_LocationManagement_ReceivedDate DIO_LocationManagement_ReceivedDate { get; set; }

        public virtual DIO_WHOrderDetail DIO_WHOrderDetail { get; set; }
    }
}
