using SampleCQRS.Web.App_Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace SampleCQRS.Web
{
public class Global : System.Web.HttpApplication
{
    public static SampleCQRSRuntime Runtime { get; set; }
    protected void Application_Start()
    {
        Runtime = new SampleCQRSRuntime();
        Runtime.Start();

        AreaRegistration.RegisterAllAreas();
        GlobalConfiguration.Configure(WebApiConfig.Register);
    }

    protected void Application_End()
    {
        Runtime.Shutdown();
    }
}
}