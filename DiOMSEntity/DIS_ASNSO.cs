namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_ASNSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_ASNSO()
        {
            DIS_ASNSOPallet = new HashSet<DIS_ASNSOPallet>();
            DIS_Carton = new HashSet<DIS_Carton>();
        }

        [Key]
        public int ASNSONo { get; set; }

        public int? ASNNo { get; set; }

        public int? SONo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(80)]
        public string SODesc { get; set; }

        [StringLength(5)]
        public string PackingCode { get; set; }

        public decimal? SOLadingQuantity { get; set; }

        public decimal? SOLadingWeight { get; set; }

        [StringLength(255)]
        public string InvoiceNumber { get; set; }

        [StringLength(50)]
        public string MechandiseType { get; set; }

        [StringLength(80)]
        public string SODescriptionCode { get; set; }

        public decimal? SOLadingVolume { get; set; }

        [StringLength(80)]
        public string DICentralUse { get; set; }

        [StringLength(255)]
        public string OrderToTALASQ { get; set; }

        [StringLength(2)]
        public string OrderStatusCode { get; set; }

        [StringLength(30)]
        public string InternalVendorNumber { get; set; }

        [StringLength(10)]
        public string SpecialOrderType { get; set; }

        [StringLength(10)]
        public string SpecialTicketType { get; set; }

        [StringLength(9)]
        public string TransactionControlNo { get; set; }

        [StringLength(80)]
        public string ProductGroupDescription { get; set; }

        [StringLength(255)]
        public string EDISaleInvoiceNumber { get; set; }

        public int? MasterEventSONo { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOLadingHeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? NumberOfBox { get; set; }

        [StringLength(1000)]
        public string Special { get; set; }

        public virtual DIO_MasterEventSO DIO_MasterEventSO { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNSOPallet> DIS_ASNSOPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Carton> DIS_Carton { get; set; }
    }
}
