using Autofac;
using Autofac.Integration.Mvc;
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

            
            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assembly)
                   .Where(t => t.Name.EndsWith("Manager"))
                   .AsImplementedInterfaces();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            #endregion

            MapperHelper.RegisterMappings();
        }
    }
}
