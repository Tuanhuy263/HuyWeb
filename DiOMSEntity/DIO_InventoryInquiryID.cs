namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryInquiryID
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string TempValue { get; set; }
    }
}
