namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestMultiUser")]
    public partial class TestMultiUser
    {
        public int id { get; set; }

        [StringLength(250)]
        public string IPAddress { get; set; }

        [StringLength(250)]
        public string HostName { get; set; }

        public DateTime Updateddate { get; set; }

        [StringLength(100)]
        public string username { get; set; }
    }
}
