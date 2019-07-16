namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.Business_HSN_Mapping")]
    public partial class Business_HSN_Mapping
    {
        public long ID { get; set; }

        public long BusinessID { get; set; }

        [StringLength(10)]
        public string Section { get; set; }

        [StringLength(10)]
        public string Chapter { get; set; }

        [StringLength(20)]
        public string ProductCode { get; set; }

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
