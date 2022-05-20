namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_QuickBookAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_QuickBookAccount()
        {
            DIO_AdjustmentHeader = new HashSet<DIO_AdjustmentHeader>();
            DIO_Discount = new HashSet<DIO_Discount>();
            DIO_OpenPack = new HashSet<DIO_OpenPack>();
            DIO_PackItem = new HashSet<DIO_PackItem>();
            DIO_QuickBookAccount1 = new HashSet<DIO_QuickBookAccount>();
            DIO_ReasonAdjustment = new HashSet<DIO_ReasonAdjustment>();
            DIS_Hub = new HashSet<DIS_Hub>();
            DIS_Vendor = new HashSet<DIS_Vendor>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string QBID { get; set; }

        [StringLength(255)]
        public string AccountNumber { get; set; }

        [StringLength(255)]
        public string AccountName { get; set; }

        [StringLength(255)]
        public string AccountType { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        [StringLength(100)]
        public string TaxLine { get; set; }

        public DateTime? QBModified { get; set; }

        public int? ParentAccountID { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AdjustmentHeader> DIO_AdjustmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Discount> DIO_Discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OpenPack> DIO_OpenPack { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItem> DIO_PackItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_QuickBookAccount> DIO_QuickBookAccount1 { get; set; }

        public virtual DIO_QuickBookAccount DIO_QuickBookAccount2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReasonAdjustment> DIO_ReasonAdjustment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Hub> DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Vendor> DIS_Vendor { get; set; }
    }
}
