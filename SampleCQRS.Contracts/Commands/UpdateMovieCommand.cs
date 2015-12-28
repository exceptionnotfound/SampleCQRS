using SimpleCqrs.Commanding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Contracts.Commands
{
    public class UpdateMovieCommand : CommandWithAggregateRootId
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }

        public UpdateMovieCommand(Guid movieId, string title, DateTime releaseDate, int runningTime)
        {
            AggregateRootId = movieId;
            Title = title;
            ReleaseDate = releaseDate;
            RunningTimeMinutes = runningTime;
        }
    }
}
