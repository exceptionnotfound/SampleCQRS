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
    public class MovieEventHandler : IHandleDomainEvents<MovieCreatedEvent>
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
    }
}
