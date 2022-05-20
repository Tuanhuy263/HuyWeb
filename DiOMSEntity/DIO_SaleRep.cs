namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SaleRep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_SaleRep()
        {
            DIO_BrokerPayment = new HashSet<DIO_BrokerPayment>();
            DIO_HubItemSaleRep = new HashSet<DIO_HubItemSaleRep>();
            DIO_HubSaleRep = new HashSet<DIO_HubSaleRep>();
            DIO_SaleRepSODetail = new HashSet<DIO_SaleRepSODetail>();
            DIO_SOCommission = new HashSet<DIO_SOCommission>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int SaleRepID { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Prefix { get; set; }

        public int? Gender { get; set; }

        [StringLength(20)]
        public string MobilePhone { get; set; }

        [StringLength(20)]
        public string HomePhone { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(250)]
        public string QBID { get; set; }

        [StringLength(250)]
        public string QBRealID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BrokerPayment> DIO_BrokerPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubItemSaleRep> DIO_HubItemSaleRep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubSaleRep> DIO_HubSaleRep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SaleRepSODetail> DIO_SaleRepSODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOCommission> DIO_SOCommission { get; set; }
    }
}
