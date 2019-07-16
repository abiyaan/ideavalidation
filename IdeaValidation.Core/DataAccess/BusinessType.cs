namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.BusinessTypes")]
    public partial class BusinessType
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TypeName { get; set; }

        [StringLength(50)]
        public string TypeCode { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(255)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
