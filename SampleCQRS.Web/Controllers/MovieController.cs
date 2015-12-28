using SampleCQRS.Application.CommandHandlers;
using SampleCQRS.Contracts.Commands;
using SimpleCqrs;
using SimpleCqrs.Commanding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SampleCQRS.Web.Controllers
{
    [RoutePrefix("movie")]
    public class MovieController : ApiController
    {
        public ICommandBus CommandBus;

        public MovieController() : this(ServiceLocator.Current.Resolve<ICommandBus>())
        {

        }

        public MovieController(ICommandBus commandBus)
        {
            CommandBus = commandBus;
        }

        [HttpPost]
        [Route("add")]
        public CreateMovieStatus Create(CreateMovieCommand command)
        {
            return (CreateMovieStatus)CommandBus.Execute(command);
        }

        [HttpPost]
        [Route("update")]
        public void Update(UpdateMovieCommand command)
        {
            CommandBus.Execute(command);
        }
    }
}