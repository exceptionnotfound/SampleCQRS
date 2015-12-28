using SimpleCqrs.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Contracts.Events
{
public class MovieCreatedEvent : DomainEvent
{ 

    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int RunningTimeMinutes { get; set; }

    public MovieCreatedEvent(Guid movieId, string title, DateTime releaseDate, int runningTime)
    {
        AggregateRootId = movieId;
        Title = title;
        ReleaseDate = releaseDate;
        RunningTimeMinutes = runningTime;
    }
}
}
