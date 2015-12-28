using SampleCQRS.Application.ReadModel;
using SampleCQRS.Contracts.Events;
using SimpleCqrs.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Application.EventHandlers
{
    public class MovieEventHandler : IHandleDomainEvents<MovieCreatedEvent>,
                                        IHandleDomainEvents<MovieTitleChangedEvent>,
                                        IHandleDomainEvents<MovieReleaseDateChangedEvent>,
                                        IHandleDomainEvents<MovieRunningTimeChangedEvent>
    {
        public void Handle(MovieCreatedEvent createdEvent)
        {
            using (MoviesReadModel entities = new MoviesReadModel())
            {
                entities.Movies.Add(new Movie()
                {
                    Id = createdEvent.AggregateRootId,
                    Title = createdEvent.Title,
                    ReleaseDate = createdEvent.ReleaseDate,
                    RunningTimeMinutes = createdEvent.RunningTimeMinutes
                });

                entities.SaveChanges();
            }
        }

        public void Handle(MovieTitleChangedEvent domainEvent)
        {
            using (MoviesReadModel entities = new MoviesReadModel())
            {
                var movie = entities.Movies.Find(domainEvent.AggregateRootId);
                movie.Title = domainEvent.Title;

                entities.SaveChanges();
            }
        }

        public void Handle(MovieReleaseDateChangedEvent domainEvent)
        {
            using (MoviesReadModel entities = new MoviesReadModel())
            {
                var movie = entities.Movies.Find(domainEvent.AggregateRootId);
                movie.ReleaseDate = domainEvent.ReleaseDate;

                entities.SaveChanges();
            }
        }

        public void Handle(MovieRunningTimeChangedEvent domainEvent)
        {
            using (MoviesReadModel entities = new MoviesReadModel())
            {
                var movie = entities.Movies.Find(domainEvent.AggregateRootId);
                movie.RunningTimeMinutes = domainEvent.RunningTimeMinutes;

                entities.SaveChanges();
            }
        }
    }
}
