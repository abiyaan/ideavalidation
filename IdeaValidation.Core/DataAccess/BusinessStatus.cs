namespace IdeaValidation.Core.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masters.BusinessStatus")]
    public partial class BusinessStatus
    {
        public long ID { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public bool IsActive { get; set; }
    }
}
