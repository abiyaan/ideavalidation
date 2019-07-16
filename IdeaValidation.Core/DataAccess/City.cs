namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.Cities")]
    public partial class City
    {
        public long ID { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        public long? StateID { get; set; }

        [StringLength(10)]
        public string CityCode { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(255)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual State State { get; set; }
    }
}
