using SimpleCqrs.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Contracts.Events
{
    public class MovieReleaseDateChangedEvent : DomainEvent
    {
        public DateTime ReleaseDate { get; set; }

        public MovieReleaseDateChangedEvent(Guid movieId, DateTime releaseDate)
        {
            AggregateRootId = movieId;
            ReleaseDate = releaseDate;
        }
    }
}
