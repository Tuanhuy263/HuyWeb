namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MessageInfo
    {
        public int ID { get; set; }

        [Required]
        [StringLength(40)]
        public string DestinationID { get; set; }

        public int Direction { get; set; }

        [Required]
        [StringLength(128)]
        public string MessageType { get; set; }

        public bool IsAsync { get; set; }

        public DateTime Timestamp { get; set; }

        public int DelayTime { get; set; }

        public int Lifetime { get; set; }

        [StringLength(256)]
        public string PersistentPath { get; set; }

        public int Status { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
