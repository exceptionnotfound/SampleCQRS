namespace SampleCQRS.Application.ReadModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieReview")]
    public partial class MovieReview
    {
        public Guid Id { get; set; }

        public Guid MovieId { get; set; }

        [Required]
        [StringLength(100)]
        public string Reviewer { get; set; }

        [Required]
        [StringLength(100)]
        public string Publication { get; set; }

        [Required]
        public string Content { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
