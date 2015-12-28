using SimpleCqrs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Domain
{
    public class Movie : AggregateRoot
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }
        public List<MovieReview> Reviews { get; set; }

        public Movie(Guid movieId, string title, DateTime releaseDate, int runningTimeMinutes)
        {
            Id = movieId;
            Title = title;
            ReleaseDate = releaseDate;
            RunningTimeMinutes = runningTimeMinutes;
            Reviews = new List<MovieReview>();
        }
    }
}
