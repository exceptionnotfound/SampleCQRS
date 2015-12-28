using SimpleCqrs.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Contracts.Events
{
    public class MovieRunningTimeChangedEvent : DomainEvent
    {
        public int RunningTimeMinutes { get; set; }

        public MovieRunningTimeChangedEvent(Guid movieId, int runningTime)
        {
            AggregateRootId = movieId;
            RunningTimeMinutes = runningTime;
        }
    }
}
