namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickDetailCarton
    {
        [Key]
        public int PickDetailNo { get; set; }

        public int PickNo { get; set; }

        public int InventoryCartonNo { get; set; }

        public int? FromLocationID { get; set; }

        public bool? IsPacked { get; set; }

        public int? PTSCartonNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? PickedUserID { get; set; }

        public int? PickDetailBarcodeID { get; set; }

        public bool? IsUnpack { get; set; }

        public bool? IsPalletUnpack { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }

        public virtual DIO_PickDetailBarcode DIO_PickDetailBarcode { get; set; }

        public virtual DIS_User DIS_User { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_PickHeader DIO_PickHeader { get; set; }

        public virtual DIO_PTSCarton DIO_PTSCarton { get; set; }
    }
}
