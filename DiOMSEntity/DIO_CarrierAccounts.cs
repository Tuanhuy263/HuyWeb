namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CarrierAccounts
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(100)]
        public string OrderType { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShipmentWeight { get; set; }

        [StringLength(100)]
        public string Operator { get; set; }

        [StringLength(100)]
        public string Carrier { get; set; }

        [StringLength(200)]
        public string AccountNumber { get; set; }

        [StringLength(500)]
        public string CredentialKey { get; set; }

        [StringLength(200)]
        public string ShipperNumber { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string HubCode { get; set; }

        [StringLength(100)]
        public string LocationCode { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(200)]
        public string ThirdPartyAccount { get; set; }

        [StringLength(20)]
        public string ThirdPartyPostal { get; set; }

        [StringLength(10)]
        public string ThirdPartyCountry { get; set; }

        public bool? IsThirdParty { get; set; }

        public bool? ShowReleaseIndicator { get; set; }
    }
}
