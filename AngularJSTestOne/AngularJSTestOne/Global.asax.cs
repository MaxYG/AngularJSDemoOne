using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AngularJS.Data;
using Anjular.Service;
using AnjularJS.Repository;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace AngularJSTestOne
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static IWindsorContainer _container;
        protected void Application_Start()
        {
            

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());

            _container.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient());
            _container.Register(Component.For<IDbAccess>().ImplementedBy<DbAccess>().LifestylePerWebRequest());
            _container.Register(Component.For<IEmployeeRepository>().ImplementedBy<EmployeeRepository>().LifestylePerWebRequest());
            _container.Register(Component.For<IEmployeeService>().ImplementedBy<EmployeeService>().LifestylePerWebRequest());
            _container.Register(Component.For<AngularDb>().LifestyleSingleton());

            var controllerFactory = new WindsorControllerFactory(_container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
        protected void Application_End()
        {
            if (_container != null)
            {
                _container.Dispose();
            }

        }
    }
}
