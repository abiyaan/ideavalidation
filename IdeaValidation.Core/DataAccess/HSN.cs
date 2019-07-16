namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.HSN")]
    public partial class HSN
    {
        public long ID { get; set; }

        [StringLength(10)]
        public string Section { get; set; }

        [StringLength(10)]
        public string Chapter { get; set; }

        [StringLength(20)]
        public string ProductCode { get; set; }

        [StringLength(4000)]
        public string DisplayName { get; set; }

        public long? CategoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(255)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
