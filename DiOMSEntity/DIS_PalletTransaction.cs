namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_PalletTransaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int PalletNo { get; set; }

        public byte ActionType { get; set; }

        public byte Status { get; set; }

        public DateTime TransactionDate { get; set; }

        public int MasterLocationID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_Pallet DIS_Pallet { get; set; }
    }
}
