namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DII_ASN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DII_ASN()
        {
            DII_ASN_PO = new HashSet<DII_ASN_PO>();
        }

        [Key]
        public int ASNID { get; set; }

        [StringLength(255)]
        public string HUBNAME { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(8)]
        public string CREATETIME { get; set; }

        [StringLength(5)]
        public string PACKCODE { get; set; }

        public decimal? LADINGQTY { get; set; }

        public decimal? WEIGHT { get; set; }

        [StringLength(2)]
        public string WEIGHTUOM { get; set; }

        [StringLength(80)]
        public string SCACCODE { get; set; }

        [StringLength(2)]
        public string TRANSPORTATIONTYPE { get; set; }

        [StringLength(35)]
        public string CARRIERNAME { get; set; }

        [StringLength(2)]
        public string SHIPMENTSTATUSCODE { get; set; }

        [StringLength(10)]
        public string SERIALTRAILERNUMBER { get; set; }

        [StringLength(30)]
        public string BOLNUMBER { get; set; }

        [StringLength(264)]
        public string PRONUMBER { get; set; }

        [StringLength(255)]
        public string MANIFESTNUMBER { get; set; }

        [StringLength(255)]
        public string LOADNUMBER { get; set; }

        public DateTime? SHIPPEDDATE { get; set; }

        [StringLength(8)]
        public string SHIPPEDTIME { get; set; }

        public DateTime? SCHEDULEDDELIVERYDATE { get; set; }

        [StringLength(255)]
        public string FREIGHTMETHODPAYMENT { get; set; }

        [StringLength(255)]
        public string VENDORCODEDUNS { get; set; }

        [StringLength(80)]
        public string VENDOREMAILCONTACT { get; set; }

        [StringLength(80)]
        public string SHIPTOLOCATIONNUMBER { get; set; }

        [StringLength(80)]
        public string SHIPTOQUALIFIER { get; set; }

        [StringLength(2)]
        public string SHIPFROMLOCATIONQUALIFIER { get; set; }

        [StringLength(80)]
        public string SHIPFROMNUMBER { get; set; }

        [StringLength(80)]
        public string ASNROUTING { get; set; }

        [StringLength(255)]
        public string MASTERBILLOFLADING { get; set; }

        [StringLength(255)]
        public string PORTOFENTRY { get; set; }

        public byte? STATUS { get; set; }

        public short? TRACESTATUS { get; set; }

        public int? ASNTYPE { get; set; }

        public Guid? REMITTO_ADDRESS_ID { get; set; }

        public Guid? VENDOR_ADDRESS_ID { get; set; }

        public Guid? SHIPTO_ADDRESS_ID { get; set; }

        public Guid? SHIPFROM_ADDRESS_ID { get; set; }

        [StringLength(50)]
        public string HUB_VENDOR_ID { get; set; }

        [StringLength(30)]
        public string SHIPMENTID { get; set; }

        [StringLength(100)]
        public string REMITTOCODE { get; set; }

        [StringLength(100)]
        public string REMITTONAME { get; set; }

        [StringLength(255)]
        public string REMITTOADDRESS { get; set; }

        [StringLength(100)]
        public string REMITTOCITY { get; set; }

        [StringLength(100)]
        public string REMITTOZIPCODE { get; set; }

        [StringLength(100)]
        public string REMITTOCOUNTRY { get; set; }

        [StringLength(100)]
        public string VENDORNAME { get; set; }

        [StringLength(100)]
        public string VENDORCITY { get; set; }

        [StringLength(100)]
        public string VENDORSTATE { get; set; }

        [StringLength(100)]
        public string VENDORZIPCODE { get; set; }

        [StringLength(100)]
        public string VENDORNUMBER { get; set; }

        [StringLength(255)]
        public string VENDORADDRESS { get; set; }

        [StringLength(100)]
        public string SHIPTONAME { get; set; }

        [StringLength(255)]
        public string SHIPTOADDRESS1 { get; set; }

        [StringLength(255)]
        public string SHIPTOADDRESS2 { get; set; }

        [StringLength(100)]
        public string SHIPTOCITY { get; set; }

        [StringLength(100)]
        public string SHIPTOSTATE { get; set; }

        [StringLength(100)]
        public string SHIPTOZIPCODE { get; set; }

        [StringLength(100)]
        public string SHIPTOCOUNTRY { get; set; }

        [StringLength(100)]
        public string SHIPFROMNAME { get; set; }

        [StringLength(255)]
        public string SHIPFROMADDRESS { get; set; }

        [StringLength(100)]
        public string SHIPFROMCITY { get; set; }

        [StringLength(100)]
        public string SHIPFROMSTATE { get; set; }

        [StringLength(100)]
        public string SHIPFROMZIPCODE { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DII_ASN_PO> DII_ASN_PO { get; set; }
    }
}
