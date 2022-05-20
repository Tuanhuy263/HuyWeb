namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SuggestionPrice
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? MasterItemID { get; set; }

        public int? HubItemID { get; set; }

        public int? VendorItemID { get; set; }

        public int? CurrencyID { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? UnitCost { get; set; }

        public decimal? MSRP { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? LocationManagementID { get; set; }

        [Column(TypeName = "money")]
        public decimal? WholeSalePrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? WholeSalesPrice { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIO_LocationManagement DIO_LocationManagement { get; set; }

        public virtual DIS_HubItem DIS_HubItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_VendorItem DIS_VendorItem { get; set; }
    }
}
