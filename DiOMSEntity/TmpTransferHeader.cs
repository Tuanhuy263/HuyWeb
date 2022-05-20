namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TmpTransferHeader")]
    public partial class TmpTransferHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TmpTransferHeader()
        {
            TmpTransferCartons = new HashSet<TmpTransferCarton>();
            TmpTransferDetails = new HashSet<TmpTransferDetail>();
            TmpTransferPallets = new HashSet<TmpTransferPallet>();
        }

        [Key]
        public int TransferHeaderID { get; set; }

        public int? FromMasterLocationID { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public DateTime? TransferDate { get; set; }

        public DateTime? ReceiptDate { get; set; }

        public DateTime? ShipmentDate { get; set; }

        [StringLength(50)]
        public string ShipmentMethod { get; set; }

        [StringLength(50)]
        public string ShipmentAgent { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferCarton> TmpTransferCartons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferDetail> TmpTransferDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TmpTransferPallet> TmpTransferPallets { get; set; }
    }
}
