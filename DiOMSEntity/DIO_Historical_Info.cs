namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Historical_Info
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? BatchID { get; set; }

        public int? SerialID { get; set; }

        [StringLength(250)]
        public string Last_Sold_By { get; set; }

        [StringLength(250)]
        public string Manufacturer_Name { get; set; }

        [StringLength(200)]
        public string Dosage_Form { get; set; }

        [StringLength(250)]
        public string Drug_Name { get; set; }

        [StringLength(50)]
        public string Container_Size { get; set; }

        [StringLength(10)]
        public string Strength { get; set; }

        [StringLength(20)]
        public string NDC { get; set; }

        [StringLength(15)]
        public string LotNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        [StringLength(20)]
        public string Serial_Number { get; set; }

        public DateTime? Expiration_Date { get; set; }

        [StringLength(10)]
        public string ReferenceNo { get; set; }

        [StringLength(25)]
        public string Type { get; set; }

        [StringLength(25)]
        public string Transaction_Type { get; set; }

        public DateTime? Reference_Date { get; set; }

        [StringLength(500)]
        public string Seller { get; set; }

        [StringLength(500)]
        public string Seller_Business_Address { get; set; }

        [StringLength(250)]
        public string SellerAddress1 { get; set; }

        [StringLength(250)]
        public string SellerAddress2 { get; set; }

        [StringLength(250)]
        public string SellerCity { get; set; }

        [StringLength(20)]
        public string SellerState { get; set; }

        [StringLength(20)]
        public string SellerZipCode { get; set; }

        [StringLength(250)]
        public string SellerCountry { get; set; }

        [StringLength(500)]
        public string Recipient { get; set; }

        [StringLength(500)]
        public string Recipient_Business_Address { get; set; }

        [StringLength(250)]
        public string RecipientAddress1 { get; set; }

        [StringLength(250)]
        public string RecipientAddress2 { get; set; }

        [StringLength(250)]
        public string RecipientCity { get; set; }

        [StringLength(20)]
        public string RecipientState { get; set; }

        [StringLength(20)]
        public string RecipientZipCode { get; set; }

        [StringLength(250)]
        public string RecipientCountry { get; set; }

        [StringLength(50)]
        public string Seller_License_Number { get; set; }

        [StringLength(200)]
        public string Seller_Signature { get; set; }

        [StringLength(200)]
        public string Seller_Certified_By { get; set; }

        [StringLength(50)]
        public string SaleInvoiceNumber { get; set; }

        public DateTime? InvoiceDate { get; set; }

        [StringLength(200)]
        public string Contact_Name { get; set; }

        [StringLength(100)]
        public string Contact_Title { get; set; }

        [StringLength(200)]
        public string Contact_Email { get; set; }

        [StringLength(50)]
        public string Contact_Phone { get; set; }

        [StringLength(200)]
        public string Contact_Url { get; set; }

        [StringLength(500)]
        public string Shipping_Address { get; set; }

        [StringLength(250)]
        public string ShippingAddress1 { get; set; }

        [StringLength(250)]
        public string ShippingAddress2 { get; set; }

        [StringLength(250)]
        public string ShippingCity { get; set; }

        [StringLength(20)]
        public string ShippingState { get; set; }

        [StringLength(20)]
        public string ShippingZipCode { get; set; }

        [StringLength(250)]
        public string ShippingCountry { get; set; }

        [StringLength(50)]
        public string Recipient_License_Number { get; set; }

        public DateTime? Received_Date { get; set; }

        [StringLength(200)]
        public string Received_Authenticated_By { get; set; }

        [StringLength(200)]
        public string Recipient_Signature { get; set; }

        [StringLength(200)]
        public string Inbound_Pedigree_Number { get; set; }

        [StringLength(200)]
        public string Outbound_Pedigree_Number { get; set; }

        [StringLength(25)]
        public string MasterLocationCode { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(30)]
        public string BatchCode { get; set; }

        public int? TransID { get; set; }

        public int? ASN { get; set; }

        [StringLength(30)]
        public string RANo { get; set; }

        [StringLength(10)]
        public string UOMCode { get; set; }

        public int? ASNNo { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_ASN DIS_ASN1 { get; set; }
    }
}
