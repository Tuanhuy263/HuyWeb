namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TmpAdjustmentDetail")]
    public partial class TmpAdjustmentDetail
    {
        [Key]
        public int AdjustmentDetailNo { get; set; }

        public int AdjustmentHeaderNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? IndividualItemQty { get; set; }

        public decimal? Onhand { get; set; }

        public decimal? WarehouseCount { get; set; }

        public decimal? UnitCost { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual TmpAdjustmentHeader TmpAdjustmentHeader { get; set; }
    }
}
