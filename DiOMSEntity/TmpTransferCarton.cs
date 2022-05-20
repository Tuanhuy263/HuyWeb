namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TmpTransferCarton")]
    public partial class TmpTransferCarton
    {
        [Key]
        public int TransferCartonNo { get; set; }

        public int TransferHeaderID { get; set; }

        public int CartonNo { get; set; }

        public int ToMasterLocationID { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual TmpTransferHeader TmpTransferHeader { get; set; }
    }
}
