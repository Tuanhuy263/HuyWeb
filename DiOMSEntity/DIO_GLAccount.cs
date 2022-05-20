namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_GLAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_GLAccount()
        {
            DIO_BankList = new HashSet<DIO_BankList>();
            DIO_CustomerPostingGroup = new HashSet<DIO_CustomerPostingGroup>();
            DIO_GLAccount1 = new HashSet<DIO_GLAccount>();
            DIO_ImportJournalLine = new HashSet<DIO_ImportJournalLine>();
            DIO_ProductPostingGroup = new HashSet<DIO_ProductPostingGroup>();
            DIO_ProductPostingGroup1 = new HashSet<DIO_ProductPostingGroup>();
            DIO_ProductPostingGroup2 = new HashSet<DIO_ProductPostingGroup>();
            DIO_ProductPostingGroup3 = new HashSet<DIO_ProductPostingGroup>();
            DIO_ProductPostingGroup4 = new HashSet<DIO_ProductPostingGroup>();
            DIO_ProductPostingGroup5 = new HashSet<DIO_ProductPostingGroup>();
            DIO_ProductPostingGroup6 = new HashSet<DIO_ProductPostingGroup>();
        }

        [Key]
        public int GLAccountID { get; set; }

        [Required]
        [StringLength(10)]
        public string AccountNo { get; set; }

        [Required]
        [StringLength(250)]
        public string AccountName { get; set; }

        [StringLength(50)]
        public string Income_Balance { get; set; }

        [StringLength(50)]
        public string Debit_Credit { get; set; }

        [StringLength(50)]
        public string AccountType { get; set; }

        public decimal? Balance { get; set; }

        public bool? IsDirectPosting { get; set; }

        public bool? IsForeignCurrency { get; set; }

        public bool? IsBlocked { get; set; }

        public int? ParentID { get; set; }

        public int? LevelAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BankList> DIO_BankList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerPostingGroup> DIO_CustomerPostingGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_GLAccount> DIO_GLAccount1 { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ImportJournalLine> DIO_ImportJournalLine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductPostingGroup> DIO_ProductPostingGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductPostingGroup> DIO_ProductPostingGroup1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductPostingGroup> DIO_ProductPostingGroup2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductPostingGroup> DIO_ProductPostingGroup3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductPostingGroup> DIO_ProductPostingGroup4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductPostingGroup> DIO_ProductPostingGroup5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductPostingGroup> DIO_ProductPostingGroup6 { get; set; }
    }
}
