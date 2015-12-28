using SimpleCqrs.Eventing;
using SimpleCqrs.EventStore.SqlServer;
using SimpleCqrs.EventStore.SqlServer.Serializers;
using SimpleCqrs.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleCQRS.Web
{
    public class SampleCQRSRuntime : SimpleCqrs.SimpleCqrsRuntime<UnityServiceLocator>
    {
        protected override IEventStore GetEventStore(SimpleCqrs.IServiceLocator serviceLocator)
        {
            var configuration = new SqlServerConfiguration(Constants.SampleCQRSConnectionString);
            return new SqlServerEventStore(configuration, new JsonDomainEventSerializer());
        }
    }
}