namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProductCodes
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

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

        [StringLength(2)]
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

        public int? MasterItemID { get; set; }

        public int? HubItemID { get; set; }

        public int? VendorItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? HubID { get; set; }

        public int? VendorID { get; set; }

        public bool? IsMainProductCode { get; set; }

        [StringLength(20)]
        public string DIV { get; set; }

        [StringLength(20)]
        public string SEA { get; set; }

        [StringLength(20)]
        public string GRP { get; set; }

        [StringLength(20)]
        public string SIZE { get; set; }

        [StringLength(50)]
        public string Style { get; set; }

        [StringLength(20)]
        public string StyleCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(20)]
        public string Season { get; set; }

        [StringLength(20)]
        public string SKU { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_HubItem DIS_HubItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        public virtual DIS_VendorItem DIS_VendorItem { get; set; }
    }
}
