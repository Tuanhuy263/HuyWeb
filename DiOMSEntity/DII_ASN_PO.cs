namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DII_ASN_PO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DII_ASN_PO()
        {
            DII_PACK = new HashSet<DII_PACK>();
            DII_PALLET_PACK = new HashSet<DII_PALLET_PACK>();
        }

        [Key]
        public int ASNPOID { get; set; }

        public int ASNID { get; set; }

        public int? PO_ID { get; set; }

        [StringLength(22)]
        public string PONUMBER { get; set; }

        public DateTime? PODATE { get; set; }

        [StringLength(80)]
        public string PURCHASEORDERDESC { get; set; }

        [StringLength(5)]
        public string PACKINGCODE { get; set; }

        public decimal? POLADINGQUANTITY { get; set; }

        public decimal? POLADINGWEIGHT { get; set; }

        [StringLength(30)]
        public string VENDORORDERNUMBER { get; set; }

        [StringLength(30)]
        public string INVOICENUMBER { get; set; }

        [StringLength(30)]
        public string DEPARTMENTNUMBER { get; set; }

        [StringLength(80)]
        public string DEPARTMENTDESCRIPTION { get; set; }

        [StringLength(30)]
        public string VENDORNUMBER { get; set; }

        [StringLength(80)]
        public string STORENUMBER { get; set; }

        [StringLength(60)]
        public string STORENAME { get; set; }

        [StringLength(60)]
        public string STOREADDRESS1 { get; set; }

        [StringLength(60)]
        public string STOREADDRESS2 { get; set; }

        [StringLength(30)]
        public string STORECITY { get; set; }

        [StringLength(2)]
        public string STORESTATE { get; set; }

        [StringLength(15)]
        public string STOREZIPCODE { get; set; }

        [StringLength(80)]
        public string BILLTONUMBER { get; set; }

        [StringLength(50)]
        public string MECHANDISETYPE { get; set; }

        [StringLength(80)]
        public string BUYERCODE { get; set; }

        [StringLength(80)]
        public string PODESCRIPTIONCODE { get; set; }

        [StringLength(30)]
        public string PONUMBERFORDII { get; set; }

        public decimal? POLADINGVOLUME { get; set; }

        [StringLength(3)]
        public string TRANSTYPE { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DII_ASN DII_ASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DII_PACK> DII_PACK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DII_PALLET_PACK> DII_PALLET_PACK { get; set; }
    }
}
