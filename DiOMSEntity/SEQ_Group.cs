namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEQ_Group
    {
        [Key]
        public int SEQGroupID { get; set; }

        [Required]
        [StringLength(5)]
        public string Code { get; set; }

        public int? LastNumber { get; set; }

        public int SEQNoID { get; set; }

        public virtual SEQ_NO SEQ_NO { get; set; }
    }
}
