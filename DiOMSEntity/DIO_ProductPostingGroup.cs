namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProductPostingGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ProductPostingGroup()
        {
            DIS_MasterItem = new HashSet<DIS_MasterItem>();
        }

        [Key]
        public int ProductPostingGroupID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductPostingGroupCode { get; set; }

        public int? SalesAccount { get; set; }

        public int? SalesDiscAccount { get; set; }

        public int? PurchaseAccount { get; set; }

        public int? PurchaseDiscAccount { get; set; }

        public int? COGSAccount { get; set; }

        public int? SalesCreditMemoAccount { get; set; }

        public int? PurchaseCreditMemoAccount { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount1 { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount2 { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount3 { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount4 { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount5 { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterItem> DIS_MasterItem { get; set; }
    }
}
