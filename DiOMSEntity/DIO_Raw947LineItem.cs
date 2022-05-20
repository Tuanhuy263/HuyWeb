namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw947LineItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsValidData { get; set; }

        public bool? IsIgnored { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        [Key]
        public int WHIAADRawID { get; set; }

        public int? LineItemNo { get; set; }

        [StringLength(100)]
        public string ERPItemCode { get; set; }

        [StringLength(100)]
        public string ProductCode1 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(100)]
        public string ProductCode2 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(100)]
        public string ProductCode3 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(100)]
        public string ProductCode4 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(100)]
        public string ProductCode5 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(100)]
        public string ProductCode6 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(100)]
        public string ProductCode7 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(100)]
        public string ProductCode8 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(100)]
        public string ProductCode9 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(100)]
        public string ProductCode10 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(100)]
        public string ProductDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? OnhandQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(100)]
        public string InventoryStatusCode { get; set; }

        public int? UOMID { get; set; }

        [StringLength(100)]
        public string UOMCode { get; set; }

        public int? InnerPack { get; set; }

        public int? Pack { get; set; }

        public int? TotalCartons { get; set; }

        public int? UOMRate { get; set; }

        public int? MasterLocationID { get; set; }

        [StringLength(100)]
        public string WarehouseCode { get; set; }

        [StringLength(100)]
        public string WarehouseName { get; set; }

        [StringLength(100)]
        public string WarehouseCountry { get; set; }

        [StringLength(100)]
        public string WarehouseCity { get; set; }

        [StringLength(100)]
        public string WarehouseState { get; set; }

        [StringLength(200)]
        public string WarehouseAddress { get; set; }

        [StringLength(100)]
        public string WarehousePhone { get; set; }

        public int? WHIAAHRawID { get; set; }

        public int? MasterItemID { get; set; }

        public int? InventoryStatusID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_Raw947Header DIO_Raw947Header { get; set; }
    }
}
