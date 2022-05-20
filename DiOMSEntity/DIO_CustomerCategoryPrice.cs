namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomerCategoryPrice
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? CustomerCategoriesID { get; set; }

        public int? CurrencyID { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIO_CustomerCategories DIO_CustomerCategories { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
