namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TmpTransferDetail")]
    public partial class TmpTransferDetail
    {
        [Key]
        public int TransferDetailID { get; set; }

        public int TransferHeaderID { get; set; }

        public int? ToMasterLocationID { get; set; }

        public int? MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? QtyBase { get; set; }

        [StringLength(10)]
        public string UnitOfMeasure { get; set; }

        public decimal? UnitCost { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual TmpTransferHeader TmpTransferHeader { get; set; }
    }
}
