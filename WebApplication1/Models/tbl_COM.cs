//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_COM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_COM()
        {
            this.AGENTs = new HashSet<AGENT>();
            this.CARRIERs = new HashSet<CARRIER>();
            this.Quotations = new HashSet<Quotation>();
            this.tbl_CNEE = new HashSet<tbl_CNEE>();
            this.tbl_CUSTOMER = new HashSet<tbl_CUSTOMER>();
            this.tbl_DEPARTMENT = new HashSet<tbl_DEPARTMENT>();
            this.tbl_JOB = new HashSet<tbl_JOB>();
            this.tbl_SHIPPER = new HashSet<tbl_SHIPPER>();
            this.tbl_STAFF = new HashSet<tbl_STAFF>();
            this.tbl_SUPPLIER = new HashSet<tbl_SUPPLIER>();
            this.tbl_TAI_KHOAN = new HashSet<tbl_TAI_KHOAN>();
            this.tbl_TUTT = new HashSet<tbl_TUTT>();
        }
    
        public string Com_ID { get; set; }
        public string Com_nameE { get; set; }
        public string Com_nameV { get; set; }
        public string Com_shortname { get; set; }
        public string Com_addE { get; set; }
        public string com_addV { get; set; }
        public string Com_tel { get; set; }
        public string Com_email { get; set; }
        public string Com_email_nv { get; set; }
        public string Com_web { get; set; }
        public byte[] Com_logo { get; set; }
        public string WCA { get; set; }
        public string Cus_email { get; set; }
        public string Cus_tel { get; set; }
        public string Cus_name { get; set; }
        public string Cus_nickname { get; set; }
        public string Count_name { get; set; }
        public string Ceo_name { get; set; }
        public string BankAcountVND0 { get; set; }
        public string BankNameNVD0 { get; set; }
        public string BankAcountNoVND0 { get; set; }
        public string BankAcountVND1 { get; set; }
        public string BankNameNVD1 { get; set; }
        public string BankAcountNoVND1 { get; set; }
        public string BankAcountUSD0 { get; set; }
        public string ComAddressUSD0 { get; set; }
        public string BankAcountNoUSD0 { get; set; }
        public string BankNameUSD0 { get; set; }
        public string BankAddressUSD0 { get; set; }
        public string SWIFT0 { get; set; }
        public string BankAcountUSD1 { get; set; }
        public string ComAddressUSD1 { get; set; }
        public string BankAcountNoUSD1 { get; set; }
        public string BankNameUSD1 { get; set; }
        public string BankAddressUSD1 { get; set; }
        public string SWIFT1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENT> AGENTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRIER> CARRIERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quotation> Quotations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CNEE> tbl_CNEE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CUSTOMER> tbl_CUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DEPARTMENT> tbl_DEPARTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_JOB> tbl_JOB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SHIPPER> tbl_SHIPPER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_STAFF> tbl_STAFF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SUPPLIER> tbl_SUPPLIER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TAI_KHOAN> tbl_TAI_KHOAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TUTT> tbl_TUTT { get; set; }
    }
}
