namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PrintTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PrintTemplate()
        {
            DIO_PickDetailBarcode = new HashSet<DIO_PickDetailBarcode>();
            DIO_PrintTemplateHubVendor = new HashSet<DIO_PrintTemplateHubVendor>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public int? LabelType { get; set; }

        public int? PrintType { get; set; }

        [StringLength(4000)]
        public string ReportFilePath { get; set; }

        public string ContentFile { get; set; }

        [StringLength(250)]
        public string StoreName { get; set; }

        [StringLength(250)]
        public string BarcodeTemplate { get; set; }

        [StringLength(250)]
        public string BarcodeTempt { get; set; }

        [StringLength(250)]
        public string Delimiter { get; set; }

        public bool? Default { get; set; }

        public bool? HaveAI { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? VendorID { get; set; }

        public int? HubID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailBarcode> DIO_PickDetailBarcode { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PrintTemplateHubVendor> DIO_PrintTemplateHubVendor { get; set; }
    }
}
