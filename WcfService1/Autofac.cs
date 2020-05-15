using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.Depandencies;

namespace WcfService1
{
    public class Autofac
    {
        public static void boostraper()
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
    }
}