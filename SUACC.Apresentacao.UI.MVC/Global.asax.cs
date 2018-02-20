using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SUACC.Apresentacao.UI.MVC.Models;
using SUACC.Infra.CrossCutting.IoC;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SUACC.Apresentacao.UI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();
            BootStrapper.Register(container);
            //container.Verify();            

            //container.Register<ApplicationDbContext>(Lifestyle.Singleton);
            //container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()), Lifestyle.Singleton);
            //container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>(), Lifestyle.Singleton);
            //container.Register<IAuthenticationManager>(() => HttpContext.Current.GetOwinContext().Authentication, Lifestyle.Singleton);

            //container.Register<ApplicationUserManager>(Lifestyle.Scoped);            
            //container.Register<ApplicationSignInManager>(Lifestyle.Scoped);
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));



            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
