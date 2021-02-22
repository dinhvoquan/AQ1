using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using Autofac.Integration.WebApi;
using AQ1.Data.Infrastructure;
using AQ1.Data;
using AQ1.Data.Repositories;
using AQ1.Service;
using System.Web.Mvc;
using System.Web.Http;

[assembly: OwinStartup(typeof(AQ1.Web.App_Start.Startup))]

namespace AQ1.Web.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutofac(app);
        }

        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            //Register
            builder.RegisterControllers(Assembly.GetExecutingAssembly());      
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DBFactory>().As<IDbFactory>().InstancePerRequest();
            builder.RegisterType<AQ1DbContext>().AsSelf().InstancePerRequest();

            //Repositories
            builder.RegisterAssemblyTypes(typeof(NewsletterCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            //Services
            builder.RegisterAssemblyTypes(typeof(NewsletterCategoryService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}
