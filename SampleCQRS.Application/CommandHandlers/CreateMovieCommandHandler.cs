using SampleCQRS.Contracts.Commands;
using SimpleCqrs.Commanding;
using SimpleCqrs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Application.CommandHandlers
{
    public enum CreateMovieStatus
    {
        Successful
    }
    public class CreateMovieCommandHandler : CommandHandler<CreateMovieCommand>
    {
        protected IDomainRepository _repository;

        public CreateMovieCommandHandler(IDomainRepository repository)
        {
            _repository = repository;
        }

public override void Handle(CreateMovieCommand command)
{
    Return(ValidateCommand(command));

    var location = new Domain.Movie(Guid.NewGuid(), command.Title, command.ReleaseDate, command.RunningTimeMinutes);

    _repository.Save(location);
}
        protected CreateMovieStatus ValidateCommand(CreateMovieCommand command)
        {
            return CreateMovieStatus.Successful;
        }
    }
}
