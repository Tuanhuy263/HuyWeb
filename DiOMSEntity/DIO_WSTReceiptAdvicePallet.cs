namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTReceiptAdvicePallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WSTReceiptAdvicePallet()
        {
            DIO_WSTReceiptAdvicePalletPO = new HashSet<DIO_WSTReceiptAdvicePalletPO>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceiptAdvicePalletId { get; set; }

        [StringLength(50)]
        public string PalletCode { get; set; }

        [StringLength(50)]
        public string SSC14 { get; set; }

        [StringLength(50)]
        public string SequentialNo { get; set; }

        public int? TmpInvPallet { get; set; }

        [StringLength(100)]
        public string OldLocation { get; set; }

        public int? InventoryStatus { get; set; }

        public int? InventoryReason { get; set; }

        [StringLength(100)]
        public string OldLocationDescription { get; set; }

        public int? Location { get; set; }

        public int? ReceiptAdviceHeaderId { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_InventoryPallet DIO_InventoryPallet { get; set; }

        public virtual DIO_InventoryReason DIO_InventoryReason { get; set; }

        public virtual DIO_InventoryStatus DIO_InventoryStatus { get; set; }

        public virtual DIO_WSTReceiptAdviceHeader DIO_WSTReceiptAdviceHeader { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdvicePalletPO> DIO_WSTReceiptAdvicePalletPO { get; set; }
    }
}
