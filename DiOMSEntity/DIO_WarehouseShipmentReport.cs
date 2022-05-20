namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WarehouseShipmentReport
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(250)]
        public string Warehouse { get; set; }

        [StringLength(250)]
        public string ShipmentID { get; set; }

        [StringLength(250)]
        public string CustomerPO { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        [StringLength(255)]
        public string ShipToName { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(255)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToCity { get; set; }

        [StringLength(255)]
        public string ShipToState { get; set; }

        [StringLength(255)]
        public string ShipToZipCode { get; set; }

        [StringLength(255)]
        public string ShipToCountry { get; set; }

        [StringLength(255)]
        public string Carrier { get; set; }

        [StringLength(255)]
        public string CarrierService { get; set; }

        [StringLength(255)]
        public string FreightTerms { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        [StringLength(255)]
        public string TrackingNumber { get; set; }

        [StringLength(255)]
        public string ProNumber { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? ShipDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightCharges { get; set; }

        [Column(TypeName = "money")]
        public decimal? ContainerQty { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }

        [StringLength(250)]
        public string VendorPO { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPerCase { get; set; }

        [StringLength(255)]
        public string UOM { get; set; }

        public bool? IsUpdateSODetail { get; set; }
    }
}
