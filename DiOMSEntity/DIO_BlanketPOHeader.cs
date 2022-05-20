namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BlanketPOHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_BlanketPOHeader()
        {
            DIO_BlanketPODetail = new HashSet<DIO_BlanketPODetail>();
            DIS_POHeader = new HashSet<DIS_POHeader>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int BlanketPOHeaderNo { get; set; }

        [StringLength(250)]
        public string BlanketPONumber { get; set; }

        [StringLength(103)]
        public string ContractNumber { get; set; }

        public DateTime? ContractStartDate { get; set; }

        public DateTime? ContractEndDate { get; set; }

        public DateTime? ContractSignedDate { get; set; }

        [StringLength(250)]
        public string TermOfDelivery { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? CancelDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? ShippingDate { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExchangeRateAmount { get; set; }

        public int? HubID { get; set; }

        public int? VendorID { get; set; }

        public int? BillToCode { get; set; }

        public int? ShipToCode { get; set; }

        public int? ShipToID { get; set; }

        public int? BaseCurrencyCode { get; set; }

        public int? StoreNo { get; set; }

        public int? ShipFromCode { get; set; }

        public int? CurrencyCode { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(250)]
        public string RptTermOfDelivery { get; set; }

        public bool? IsCreatingPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPODetail> DIO_BlanketPODetail { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_Currency DIO_Currency1 { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader { get; set; }
    }
}
