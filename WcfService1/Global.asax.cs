using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WcfService1.Depandencies;

namespace WcfService1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // WCF integration docs are at:
            // https://autofac.readthedocs.io/en/latest/integration/wcf.html
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<Service1>().As<IService1>();

            // Register your dependencies.
            builder.RegisterType<Dependency>().As<IDependency>();

            // Set the dependency resolver. This works for both regular
            // WCF services and REST-enabled services.
            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}