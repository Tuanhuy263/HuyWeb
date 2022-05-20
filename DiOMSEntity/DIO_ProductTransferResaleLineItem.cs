namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProductTransferResaleLineItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(50)]
        public string ProductCode1 { get; set; }

        [StringLength(2)]
        public string ProductQualifier1 { get; set; }

        [StringLength(50)]
        public string ProductCode2 { get; set; }

        [StringLength(2)]
        public string ProductQualifier2 { get; set; }

        [StringLength(50)]
        public string ProductCode3 { get; set; }

        [StringLength(2)]
        public string ProductQualifier3 { get; set; }

        [StringLength(50)]
        public string ProductCode4 { get; set; }

        [StringLength(2)]
        public string ProductQualifier4 { get; set; }

        [StringLength(50)]
        public string ProductCode5 { get; set; }

        [StringLength(2)]
        public string ProductQualifier5 { get; set; }

        [StringLength(50)]
        public string ProductCode6 { get; set; }

        [StringLength(2)]
        public string ProductQualifier6 { get; set; }

        [StringLength(50)]
        public string ProductCode7 { get; set; }

        [StringLength(2)]
        public string ProductQualifier7 { get; set; }

        [StringLength(50)]
        public string ProductCode8 { get; set; }

        [StringLength(2)]
        public string ProductQualifier8 { get; set; }

        [StringLength(50)]
        public string ProductCode9 { get; set; }

        [StringLength(2)]
        public string ProductQualifier9 { get; set; }

        [StringLength(50)]
        public string ProductCode10 { get; set; }

        [StringLength(2)]
        public string ProductQualifier10 { get; set; }

        [StringLength(100)]
        public string ShipToName { get; set; }

        [StringLength(100)]
        public string ShipToCode { get; set; }

        [StringLength(100)]
        public string ShipToAddress1 { get; set; }

        [StringLength(100)]
        public string ShipToAddress2 { get; set; }

        [StringLength(100)]
        public string ShipToCity { get; set; }

        [StringLength(100)]
        public string ShipToState { get; set; }

        [StringLength(100)]
        public string ShipToZipCode { get; set; }

        [StringLength(100)]
        public string TransferCode { get; set; }

        [StringLength(100)]
        public string DistributorInvoiceNo { get; set; }

        [StringLength(100)]
        public string ChangeDocumentNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        [StringLength(100)]
        public string ContractNo { get; set; }

        [StringLength(100)]
        public string QtyType { get; set; }

        public int? QtyShipped { get; set; }

        [StringLength(100)]
        public string QtyUnitType { get; set; }

        [StringLength(100)]
        public string NationalDrugCode { get; set; }

        [StringLength(100)]
        public string UPCConsumerPackageCode { get; set; }

        [StringLength(100)]
        public string BuyersItemCode { get; set; }

        [StringLength(100)]
        public string ManufacturesPartNo { get; set; }

        [StringLength(100)]
        public string UOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [StringLength(100)]
        public string UnitPriceType { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineTotalAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubmittedChargebackClaimAmt { get; set; }

        [StringLength(100)]
        public string ItemDescription { get; set; }

        [StringLength(100)]
        public string LineDistributorInvoiceNo { get; set; }

        [StringLength(100)]
        public string LineSellerInvoiceNo { get; set; }

        public DateTime? LineInvoiceDate { get; set; }

        public int? ProductTransferResaleDetail { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ProductTransferResaleDetail DIO_ProductTransferResaleDetail { get; set; }
    }
}
