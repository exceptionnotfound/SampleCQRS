using SampleCQRS.Contracts.Events;
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

        public Movie() { }

        public Movie(Guid movieId, string title, DateTime releaseDate, int runningTimeMinutes)
        {
            Apply(new MovieCreatedEvent(movieId, title, releaseDate, runningTimeMinutes));
        }

        public void Update(Guid movieId, string newTitle, DateTime newReleaseDate, int newRunningTime)
        {
            if(newTitle != Title)
            {
                Apply(new MovieTitleChangedEvent(movieId, newTitle));
            }
            if(newReleaseDate != ReleaseDate)
            {
                Apply(new MovieReleaseDateChangedEvent(movieId, newReleaseDate));
            }
            if(newRunningTime != RunningTimeMinutes)
            {
                Apply(new MovieRunningTimeChangedEvent(movieId, newRunningTime));
            }
        }

        protected void OnMovieCreated(MovieCreatedEvent domainEvent)
        {
            Id = domainEvent.AggregateRootId;
            Title = domainEvent.Title;
            ReleaseDate = domainEvent.ReleaseDate;
            RunningTimeMinutes = domainEvent.RunningTimeMinutes;
        }

        protected void OnMovieTitleChanged(MovieTitleChangedEvent domainEvent)
        {
            Title = domainEvent.Title;
        }

        protected void OnMovieReleaseDateChanged(MovieReleaseDateChangedEvent domainEvent)
        {
            ReleaseDate = domainEvent.ReleaseDate;
        }

        protected void OnMovieRunningTimeChanged(MovieRunningTimeChangedEvent domainEvent)
        {
            RunningTimeMinutes = domainEvent.RunningTimeMinutes;
        }
    }
}
