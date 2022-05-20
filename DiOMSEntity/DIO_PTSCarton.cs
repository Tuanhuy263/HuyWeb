namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PTSCarton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PTSCarton()
        {
            DIO_PickDetailCarton = new HashSet<DIO_PickDetailCarton>();
            DIS_Carton = new HashSet<DIS_Carton>();
            DIO_PTSLineItem = new HashSet<DIO_PTSLineItem>();
        }

        [Key]
        public int CartonNo { get; set; }

        [Required]
        [StringLength(50)]
        public string CartonCode { get; set; }

        public int? PalletNo { get; set; }

        public int WHOrderNo { get; set; }

        public int? ASNSONo { get; set; }

        [StringLength(255)]
        public string CartonStructure { get; set; }

        public decimal? CartonQty { get; set; }

        public decimal? FinishCartonQty { get; set; }

        public byte? Status { get; set; }

        public int? MasterLocationID { get; set; }

        public Guid? CartonID { get; set; }

        public int? ObjectType { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailCarton> DIO_PickDetailCarton { get; set; }

        public virtual DIO_PTSASNSO DIO_PTSASNSO { get; set; }

        public virtual DIO_WHOrderHeader DIO_WHOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Carton> DIS_Carton { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_PTSPallet DIO_PTSPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PTSLineItem> DIO_PTSLineItem { get; set; }
    }
}
