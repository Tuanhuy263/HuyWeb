namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawOrgSOHeader
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawOrgSOHeaderId { get; set; }

        [StringLength(20)]
        public string OrderNo { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? EndShipDate { get; set; }

        [StringLength(255)]
        public string PONumber { get; set; }

        [StringLength(255)]
        public string StyleNo { get; set; }

        [StringLength(100)]
        public string StyleDescription { get; set; }

        [StringLength(100)]
        public string Size { get; set; }

        [StringLength(255)]
        public string ColorCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? LinePrice { get; set; }

        [StringLength(250)]
        public string SKU { get; set; }

        [StringLength(250)]
        public string UPCCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrePrice { get; set; }

        [StringLength(250)]
        public string ArtCode { get; set; }

        [StringLength(250)]
        public string GraphicDescription { get; set; }

        [StringLength(250)]
        public string CustomerCode { get; set; }

        [StringLength(250)]
        public string CustomerName { get; set; }

        [StringLength(250)]
        public string BillToName { get; set; }

        [StringLength(50)]
        public string BillToCode { get; set; }

        [StringLength(250)]
        public string BillToAddress { get; set; }

        [StringLength(250)]
        public string BillToAddress2 { get; set; }

        [StringLength(250)]
        public string BillToAddress3 { get; set; }

        [StringLength(250)]
        public string BillToCity { get; set; }

        [StringLength(20)]
        public string BillToState { get; set; }

        [StringLength(20)]
        public string BillToZipCode { get; set; }

        [StringLength(250)]
        public string BillToCountry { get; set; }

        [StringLength(250)]
        public string BillToQualifier { get; set; }

        [StringLength(250)]
        public string BillToAddName { get; set; }

        [StringLength(50)]
        public string BillToContactTel { get; set; }

        [StringLength(50)]
        public string BillToContactFax { get; set; }

        [StringLength(250)]
        public string BillToContactEmail { get; set; }

        [StringLength(100)]
        public string BillToWeb { get; set; }

        [StringLength(100)]
        public string BillToContact { get; set; }

        [StringLength(250)]
        public string ShipToQualifier { get; set; }

        [StringLength(250)]
        public string ShipToLocation { get; set; }

        [StringLength(250)]
        public string ShipToName { get; set; }

        [StringLength(250)]
        public string ShipToAddName { get; set; }

        [StringLength(250)]
        public string ShipToAddress3 { get; set; }

        [StringLength(250)]
        public string ShipToAddress2 { get; set; }

        [StringLength(250)]
        public string ShipToAddress1 { get; set; }

        [StringLength(250)]
        public string ShipToCity { get; set; }

        [StringLength(250)]
        public string ShipToState { get; set; }

        [StringLength(250)]
        public string ShipToZipCode { get; set; }

        [StringLength(250)]
        public string ShipToEmail { get; set; }

        [StringLength(250)]
        public string ShipToWeb { get; set; }

        [StringLength(250)]
        public string ShipToContact { get; set; }

        [StringLength(250)]
        public string ShipToFax { get; set; }

        [StringLength(250)]
        public string ShipToPhone { get; set; }

        [StringLength(250)]
        public string ShipToCountry { get; set; }

        [StringLength(250)]
        public string ShipVia { get; set; }

        [StringLength(250)]
        public string RoyaltyCode { get; set; }

        [StringLength(250)]
        public string RoyaltyRate { get; set; }

        public byte? Status { get; set; }

        [StringLength(250)]
        public string OrderType { get; set; }

        public DateTime? EventDate { get; set; }

        [StringLength(250)]
        public string StoreNo { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
