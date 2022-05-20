namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AccountPeriod
    {
        [Key]
        public int AccountPeriodID { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountPeriodName { get; set; }

        public DateTime StartDate { get; set; }

        public bool IsClosed { get; set; }
    }
}
