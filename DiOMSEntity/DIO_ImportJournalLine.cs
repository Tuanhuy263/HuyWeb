namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ImportJournalLine
    {
        [Key]
        public int Line_No { get; set; }

        public DateTime PostingDate { get; set; }

        [Required]
        [StringLength(50)]
        public string DocumentNo { get; set; }

        public DateTime DocumentDate { get; set; }

        public int GLAccountID { get; set; }

        [Required]
        [StringLength(10)]
        public string AccountNo { get; set; }

        public decimal Amount { get; set; }

        public decimal Debit { get; set; }

        public decimal Credit { get; set; }

        public int? SourceType { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount { get; set; }
    }
}
