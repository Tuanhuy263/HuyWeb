namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TmpAdjustmentHeader")]
    public partial class TmpAdjustmentHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TmpAdjustmentHeader()
        {
            TmpAdjustmentCartons = new HashSet<TmpAdjustmentCarton>();
            TmpAdjustmentDetails = new HashSet<TmpAdjustmentDetail>();
            TmpAdjustmentHeader1 = new HashSet<TmpAdjustmentHeader>();
            TmpAdjustmentPallets = new HashSet<TmpAdjustmentPallet>();
        }

        [Key]
        public int AdjustmentHeaderNo { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? MasterLocationID { get; set; }

        public int? ReasonCode { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public long? Status { get; set; }

        public int? AdjustmentID { get; set; }

        public bool IsWarehouseCount { get; set; }

        public virtual DIO_ReasonAdjustment DIO_ReasonAdjustment { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpAdjustmentCarton> TmpAdjustmentCartons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpAdjustmentDetail> TmpAdjustmentDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpAdjustmentHeader> TmpAdjustmentHeader1 { get; set; }

        public virtual TmpAdjustmentHeader TmpAdjustmentHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpAdjustmentPallet> TmpAdjustmentPallets { get; set; }
    }
}
