namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.Businesses")]
    public partial class Business
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Business()
        {
            Business_HSN_Mapping = new HashSet<Business_HSN_Mapping>();
            BusinessAddresses = new HashSet<BusinessAddress>();
            BusinessFinances = new HashSet<BusinessFinance>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(500)]
        public string BusinessName { get; set; }

        [StringLength(100)]
        public string RegistrationNumber { get; set; }

        [StringLength(300)]
        public string RegisteredProvince { get; set; }

        public int? RegisteredProvinceID { get; set; }

        [StringLength(200)]
        public string RegisteredCountry { get; set; }

        public int? RegisteredCountryID { get; set; }

        [StringLength(200)]
        public string Website { get; set; }

        [StringLength(200)]
        public string EmailID { get; set; }

        public int? YearOfIncorporation { get; set; }

        public DateTime? IncorporationDate { get; set; }

        [StringLength(100)]
        public string BusinessType { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        [StringLength(500)]
        public string DataSourceName { get; set; }

        [StringLength(4000)]
        public string Tags { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(200)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string NoOfEmployees { get; set; }

        [StringLength(255)]
        public string ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [Required]
        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(255)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Business_HSN_Mapping> Business_HSN_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessAddress> BusinessAddresses { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessFinance> BusinessFinances { get; set; }
    }
}
