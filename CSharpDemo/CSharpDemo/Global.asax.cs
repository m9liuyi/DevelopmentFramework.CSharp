using Autofac;
using Autofac.Integration.Mvc;
using CSharpDemo.Models.Common;
using CSharpDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CSharpDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            #region 配置Autofac

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            var IoCProjectNames = new List<string>()
            {
                "CSharpDemo.BL",
                "CSharpDemo.DAL",
                "CSharpDemo.Utility"
            };

            foreach (var IoCProjectName in IoCProjectNames)
            {
                var assembly = Assembly.Load(IoCProjectName);

                builder.RegisterAssemblyTypes(assembly)
                       .Where(t => typeof(IIoC).IsAssignableFrom(t) && t != typeof(IIoC))
                       .AsImplementedInterfaces()
                       .InstancePerLifetimeScope();
            }

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            #endregion

            MapperHelper.RegisterMappings();
        }
    }
}
