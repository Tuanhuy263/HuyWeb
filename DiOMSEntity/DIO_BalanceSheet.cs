namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BalanceSheet
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(10)]
        public string Account { get; set; }

        [StringLength(50)]
        public string FromCode { get; set; }

        [StringLength(50)]
        public string ToCode { get; set; }

        public decimal BeginningAmount { get; set; }

        public decimal EndingAmount { get; set; }

        [StringLength(50)]
        public string DebitCredit { get; set; }
    }
}
