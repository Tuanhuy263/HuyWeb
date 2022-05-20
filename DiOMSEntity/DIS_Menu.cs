namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_Menu()
        {
            DIO_PassCodePermission = new HashSet<DIO_PassCodePermission>();
            DIS_FunctionTypeInfo = new HashSet<DIS_FunctionTypeInfo>();
            DIS_Menu1 = new HashSet<DIS_Menu>();
            DIS_PermissionAssignment = new HashSet<DIS_PermissionAssignment>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string MenuName { get; set; }

        [StringLength(250)]
        public string DisplayText { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? MenuOrder { get; set; }

        public int? ParentID { get; set; }

        public int? TypeInfoID { get; set; }

        public int MenuType { get; set; }

        public bool AlwaySelected { get; set; }

        public int AppID { get; set; }

        public int? BarGroupId { get; set; }

        [StringLength(250)]
        public string BarItemCaption { get; set; }

        public int? BarItemOrder { get; set; }

        [StringLength(50)]
        public string BarItemImage { get; set; }

        [StringLength(50)]
        public string GUIItemCode { get; set; }

        public bool? IsVisible { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PassCodePermission> DIO_PassCodePermission { get; set; }

        public virtual DIS_BarGroup DIS_BarGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_FunctionTypeInfo> DIS_FunctionTypeInfo { get; set; }

        public virtual DIS_TypeInfo DIS_TypeInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Menu> DIS_Menu1 { get; set; }

        public virtual DIS_Menu DIS_Menu2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PermissionAssignment> DIS_PermissionAssignment { get; set; }
    }
}
