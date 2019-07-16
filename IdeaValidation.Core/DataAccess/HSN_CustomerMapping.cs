namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.HSN_CustomerMapping")]
    public partial class HSN_CustomerMapping
    {
        public long ID { get; set; }

        [StringLength(20)]
        public string Product_Code { get; set; }

        [StringLength(1000)]
        public string Customer_Codes { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(2550)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
