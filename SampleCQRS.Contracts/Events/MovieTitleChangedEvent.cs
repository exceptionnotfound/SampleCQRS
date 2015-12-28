using SimpleCqrs.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Contracts.Events
{
    public class MovieTitleChangedEvent : DomainEvent
    {
        public string Title { get; set; }

        public MovieTitleChangedEvent(Guid movieId, string title)
        {
            AggregateRootId = movieId;
            Title = title;
        }
    }
}
