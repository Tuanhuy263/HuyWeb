namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProjectSales
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ProjectSalesID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ProjectSalesQty { get; set; }

        public int? HubID { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? ProjectSalesQtyPerCustomerSize { get; set; }

        public DateTime? ReportDate { get; set; }

        public int? CustomerSizeID { get; set; }

        public virtual DIO_CustomerSize DIO_CustomerSize { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }
    }
}
