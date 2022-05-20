namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTShipmentAdvicePallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WSTShipmentAdvicePallet()
        {
            DIO_WSTShipmentAdvicePalletPO = new HashSet<DIO_WSTShipmentAdvicePalletPO>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ShipmentAdvicePalletId { get; set; }

        [StringLength(50)]
        public string PalletCode { get; set; }

        [StringLength(50)]
        public string SSC14 { get; set; }

        [StringLength(50)]
        public string SequentialNo { get; set; }

        public int? ShipmentAdviceHeaderId { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? To944 { get; set; }

        public virtual DIO_WSTShipmentAdviceHeader DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdvicePalletPO> DIO_WSTShipmentAdvicePalletPO { get; set; }
    }
}
