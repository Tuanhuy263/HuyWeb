namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw943LineItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LineItemNo { get; set; }

        public int? POLineNo { get; set; }

        [StringLength(100)]
        public string ProductCode1 { get; set; }

        [StringLength(100)]
        public string ProductCode2 { get; set; }

        [StringLength(100)]
        public string ProductCode3 { get; set; }

        [StringLength(100)]
        public string ProductCode4 { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(4000)]
        public string ProductDescription { get; set; }

        [StringLength(100)]
        public string SizeDescription_PackWeight_Height { get; set; }

        [StringLength(100)]
        public string ColorDescription_Width { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQty { get; set; }

        [StringLength(100)]
        public string ShippedUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderedQty { get; set; }

        [StringLength(100)]
        public string OrderUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShippedToDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        [StringLength(100)]
        public string ProductCode5 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(100)]
        public string ProductCode6 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(100)]
        public string InnerPack { get; set; }

        [StringLength(100)]
        public string Pack { get; set; }

        [StringLength(100)]
        public string PackUOM { get; set; }

        [StringLength(100)]
        public string ProductCode7 { get; set; }

        [StringLength(100)]
        public string LineItemStatus { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier4 { get; set; }

        public byte? Status { get; set; }

        public int? Raw943PONo { get; set; }

        public int? WHRawShipmentID { get; set; }

        public int? PalletNo { get; set; }

        public int? CartonNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        public bool? IsValidData { get; set; }

        public bool? IsIgnored { get; set; }

        public int? MasterItemID { get; set; }

        public int? OrderUOMID { get; set; }

        public int? PackUOMID { get; set; }

        [StringLength(100)]
        public string ERPItemCode { get; set; }

        [StringLength(100)]
        public string CasePackInfo { get; set; }

        [Column(TypeName = "money")]
        public decimal? CommitQty { get; set; }

        public virtual DIO_Raw943Carton DIO_Raw943Carton { get; set; }

        public virtual DIO_Raw943Header DIO_Raw943Header { get; set; }

        public virtual DIO_Raw943Pallet DIO_Raw943Pallet { get; set; }

        public virtual DIO_Raw943PO DIO_Raw943PO { get; set; }
    }
}
