namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.BusinessFinances")]
    public partial class BusinessFinance
    {
        public long ID { get; set; }

        public long BusinessID { get; set; }

        public DateTime? FYDateFrom { get; set; }

        public DateTime? FYDateTo { get; set; }

        public int? FY { get; set; }

        public decimal? Networth { get; set; }

        public decimal? PnL { get; set; }

        public decimal? Sale { get; set; }

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
