using SampleCQRS.Contracts.Commands;
using SampleCQRS.Domain;
using SimpleCqrs.Commanding;
using SimpleCqrs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Application.CommandHandlers
{
    public class UpdateMovieCommandHandler : AggregateRootCommandHandler<UpdateMovieCommand, Movie>
    {
        protected IDomainRepository _repository;

        public UpdateMovieCommandHandler(IDomainRepository repository) : base(repository) { }

        public override void Handle(UpdateMovieCommand command, Movie movie)
        {
            movie.Update(command.AggregateRootId, command.Title, command.ReleaseDate, command.RunningTimeMinutes);
        }
    }
}
