namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_VendorLedgerEntry
    {
        [Key]
        public int EntryNo { get; set; }

        public int VendorID { get; set; }

        [Required]
        [StringLength(10)]
        public string VendorPostingGroupCode { get; set; }

        public DateTime PostingDate { get; set; }

        [Required]
        [StringLength(50)]
        public string DocumentNo { get; set; }

        public DateTime DocumentDate { get; set; }

        [StringLength(10)]
        public string CurrencyCode { get; set; }

        public decimal Amount { get; set; }

        public decimal Debit { get; set; }

        public decimal Credit { get; set; }

        public virtual DIO_VendorPostingGroup DIO_VendorPostingGroup { get; set; }
    }
}
