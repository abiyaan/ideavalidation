namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.BusinessAddresses")]
    public partial class BusinessAddress
    {
        public long ID { get; set; }

        public long BusinessID { get; set; }

        [Required]
        [StringLength(100)]
        public string AddressType { get; set; }

        [StringLength(250)]
        public string AddressLine1 { get; set; }

        [StringLength(250)]
        public string AddressLine2 { get; set; }

        [StringLength(500)]
        public string CityName { get; set; }

        [StringLength(500)]
        public string StateName { get; set; }

        [StringLength(150)]
        public string CountryName { get; set; }

        public bool IsActive { get; set; }

        [StringLength(500)]
        public string DataSourceName { get; set; }

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

        public virtual Business Business { get; set; }
    }
}
