namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_Function
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_Function()
        {
            DIO_PassCodePermission = new HashSet<DIO_PassCodePermission>();
            DIS_FunctionTypeInfo = new HashSet<DIS_FunctionTypeInfo>();
            DIS_PermissionAssignment = new HashSet<DIS_PermissionAssignment>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string FunctionName { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int AppID { get; set; }

        [StringLength(50)]
        public string GUIItemCode { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsVisible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PassCodePermission> DIO_PassCodePermission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_FunctionTypeInfo> DIS_FunctionTypeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PermissionAssignment> DIS_PermissionAssignment { get; set; }
    }
}
