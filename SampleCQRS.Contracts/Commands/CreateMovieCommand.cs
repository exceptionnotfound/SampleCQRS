using SimpleCqrs.Commanding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Contracts.Commands
{
    public class CreateMovieCommand : ICommand
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }
        public CreateMovieCommand(string title, DateTime releaseDate, int runningTime)
        {
            Title = title;
            ReleaseDate = releaseDate;
            RunningTimeMinutes = runningTime;
        }
    }
}
