namespace SampleCQRS.Application.ReadModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            MovieReviews = new HashSet<MovieReview>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int RunningTimeMinutes { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieReview> MovieReviews { get; set; }
    }
}
