namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AllocatedPOSO
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string SONumber { get; set; }

        [StringLength(255)]
        public string SOOriginalNumber { get; set; }

        [StringLength(255)]
        public string EDISONumber { get; set; }

        [StringLength(255)]
        public string PONumber { get; set; }

        [StringLength(255)]
        public string POOriginalNumber { get; set; }

        [StringLength(255)]
        public string EDIPONumber { get; set; }

        [StringLength(255)]
        public string ERPItemCodeSO { get; set; }

        [StringLength(255)]
        public string ERPItemCodePO { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedQty { get; set; }

        public int? SONo { get; set; }

        public int? PONo { get; set; }

        public int? MasterItemIDSO { get; set; }

        public int? MasterItemIDPO { get; set; }

        public int? SODetailNo { get; set; }

        public int? PODetailNo { get; set; }

        public int? UOMID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? HubID { get; set; }

        [StringLength(100)]
        public string HubName { get; set; }

        public int? VendorID { get; set; }

        [StringLength(100)]
        public string VendorName { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem1 { get; set; }

        public virtual DIS_PODetail DIS_PODetail { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
