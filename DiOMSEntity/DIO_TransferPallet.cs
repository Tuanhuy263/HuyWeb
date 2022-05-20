namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TransferPallet
    {
        [Key]
        public int TransferPalletNo { get; set; }

        public int TransferHeaderID { get; set; }

        public int PalletNo { get; set; }

        public int ToMasterLocationID { get; set; }

        public int? FromMasterLocationID { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_InventoryPallet DIO_InventoryPallet { get; set; }

        public virtual DIO_TransferHeader DIO_TransferHeader { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }
    }
}
