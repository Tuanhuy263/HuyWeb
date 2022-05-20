namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DII_PACK_DETAIL
    {
        [Key]
        public int PACKDETAILID { get; set; }

        public int? PACKID { get; set; }

        public int? PO_LINE_ID { get; set; }

        public int? INNERPACKID { get; set; }

        [StringLength(20)]
        public string POLINE { get; set; }

        public Guid? PRODUCTCODES_ID { get; set; }

        [StringLength(20)]
        public string LINENUMBER { get; set; }

        [StringLength(80)]
        public string ITEMDESC { get; set; }

        [StringLength(80)]
        public string ITEMCOLOR { get; set; }

        [StringLength(20)]
        public string ITEMSTYLENO { get; set; }

        public decimal? SHIPPEDQTY { get; set; }

        [StringLength(2)]
        public string SHIPPEDUOM { get; set; }

        public decimal? ORDEREDQTY { get; set; }

        [StringLength(2)]
        public string ORDEREDUOM { get; set; }

        public DateTime? QTYSHIPPEDTODATE { get; set; }

        public decimal? MASTERPACK { get; set; }

        public decimal? PACKSIZE { get; set; }

        [StringLength(2)]
        public string PACKUNIT { get; set; }

        [StringLength(35)]
        public string ITEMLINESTATUS { get; set; }

        [StringLength(100)]
        public string PRODUCTCODE1 { get; set; }

        [StringLength(100)]
        public string PRODUCTCODE2 { get; set; }

        [StringLength(100)]
        public string PRODUCTCODE3 { get; set; }

        [StringLength(100)]
        public string PRODUCTCODE4 { get; set; }

        [StringLength(100)]
        public string ITEMSIZE { get; set; }

        [StringLength(100)]
        public string PACKSIZEUNIT { get; set; }

        [StringLength(100)]
        public string PRODUCTQUALIFIER1 { get; set; }

        [StringLength(100)]
        public string PRODUCTQUALIFIER2 { get; set; }

        [StringLength(100)]
        public string PRODUCTQUALIFIER3 { get; set; }

        [StringLength(100)]
        public string PRODUCTQUALIFIER4 { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DII_INNER_PACK DII_INNER_PACK { get; set; }

        public virtual DII_PACK DII_PACK { get; set; }
    }
}
